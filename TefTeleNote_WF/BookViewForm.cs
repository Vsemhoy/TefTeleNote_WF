using Booker_WF;
using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using TefTeleNote_WF.Collections;
using TefTeleNote_WF.Data;
using TefTeleNote_WF.Generators;
using TefTeleNote_WF.Templates;
using TefTeleNote_WF.Transfer;
using TefTeleNote_WF.Transfer;
using static System.Net.Mime.MediaTypeNames;

namespace TefTeleNote_WF
{
    public partial class BookViewForm : Form
    {
        /// <summary>
        /// Current opened book file (defined in MainForm)
        /// </summary>
        private BookFile openedBook;
        private TabPage selectedTab = new TabPage();
        private int mouseX;
        /// <summary>
        /// File structure of the book (name, order, folders, id's etc)
        /// </summary>
        public List<ItemStructure> bookStructure;
        /// <summary>
        /// List of the pages opened AS TABS
        /// </summary>
        public List<Page> tabList;
        /// <summary>
        /// ID of the active TAB (tag = id of the page)
        /// </summary>
        public string activeItemId = string.Empty;
        public string activeItemName = string.Empty;
        public string activeDirectory = string.Empty;
        public int activeLevel = 0;
        public string contextSelectedId = string.Empty;
        public ItemStructure contextStruct = null;

        private string activeFolderPath = string.Empty;


        private int tabViewPadding = 6;
        private int tabViewTopOffset = 28;

        /// <summary>
        /// Root of the book's directory
        /// </summary>
        public string root;

        public Color treeFolderNameColor;
        public int tabHeight;
        public int tabWidth;

        public bool editItemMode = false;
        public bool tabSaved = false;

        private TreeNode _selectedNode;

        public BookViewForm(BookFile bf)
        {
            InitializeComponent();
            this.tabList = bf.tabs;
            this.panel_bookNavigation.Visible = false;
            this.activeItemId = bf.itemIdOfActiveTab;

            this.menuStrip_main.BackColor = Color.LightGray;
            this.BackColor = Color.LightGray;
            this.treeFolderNameColor = Color.DimGray;
            


            this.tabHeight = this.tabControl_browser.Height;
            this.tabWidth = this.tabControl_browser.Width;

            this.panel_bookNavigation.Top = this.menuStrip_main.Height;
            this.panel_bookNavigation.Height = this.ClientSize.Height - this.menuStrip_main.Height;
            this.panel_bookNavBottomManage.Top = this.panel_bookNavigation.Height - this.panel_bookNavBottomManage.Height;
            this.panel_bookNavigation.Left = 0;

            tabControl_browser.MouseDown += tabControl_browser_MouseDown;
            tabControl_browser.MouseUp += tabControl_browser_MouseUp;
            tabControl_browser.MouseDoubleClick += TabControl_browser_MouseDoubleClick;
            //this.tabControl_browser.ItemSize = new Size(200, 40);
            openedBook = bf;
            this.root = bf.directory;
            this.bookStructure = BooksFilesUtils.LoadBookStructure(new DirectoryInfo(root));

            
            this.treeview_docStruct.ItemDrag += Treeview_docStr_ItemDrag;
            this.treeview_docStruct.DragDrop += Treeview_docStr_DragDrop;
            this.treeview_docStruct.DragEnter += Treeview_docStr_DragEnter;
            
            this.Load += BookViewForm_Load;
            this.treeview_docStruct.NodeMouseClick += Treeview_docStr_NodeMouseClick;
            this.treeview_docStruct.NodeMouseDoubleClick += Treeview_docStruct_NodeMouseDoubleClick;

            this.LoadTabsOnLoad(bf);

            this.btn_addPage.MouseEnter += Btn_addPage_MouseEnter;
            this.btn_addPage.MouseLeave += Btn_addPage_MouseLeave;
            this.btn_applyItem.MouseEnter += Btn_applyItem_MouseEnter;
            this.btn_applyItem.MouseLeave += Btn_applyItem_MouseLeave;
            this.btn_addFolder.MouseEnter += Btn_addFolder_MouseEnter;
            this.btn_addFolder.MouseLeave += Btn_addFolder_MouseLeave;
            this.btn_removeItem.MouseEnter += Btn_removeItem_MouseEnter;
            this.btn_removeItem.MouseLeave += Btn_removeItem_MouseLeave;

            this.btn_openNavigationPanel.MouseHover += Btn_openNavigationPanel_MouseHover;

            this.panel_bookNavigation.MouseLeave += Panel_bookNavigation_MouseLeave;

            this.Resize += BookViewForm_Resize;

            this.tool_savePage.Click += Tool_savePage_Click;
            this.tool_saveBook.Click += Tool_saveBook_Click;

            /// Add colors
            HtmlColors.FillColors();
            foreach (HtmlColors htc in HtmlColors.colors)
            {
                ToolStripMenuItem tsm = new ToolStripMenuItem(htc.htmlName);
                tsm.Tag = htc;
                tsm.Text = htc.htmlName;
                tsm.BackColor = htc.color;
                tsm.ForeColor = htc.foreColor;
                tsm.Click += HighlightHtmlText;
                this.btn_tool_highlight.DropDownItems.Add(tsm);
            }
        }







        /// <summary>
        /// Get messages from View (open tabs, go to browser and so on...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private async void Wv_WebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            try
            {
                String content = args.TryGetWebMessageAsString();
                string target = string.Empty; 
                string reference = string.Empty; 
                string anchor = string.Empty; 
                // <button onclick="window.chrome.webview.postMessage('getData');">BUtton</button> // -- TEMPLATE REQUEST
                if (content != null)
                {
                    var array = content.Split('$');
                    foreach(var item in array)
                    {
                        var smarr = item.Split(':');
                        if (smarr.Length > 1)
                        {
                            switch (smarr[0])
                            {
                                case "target":
                                    target = smarr[1].Trim();
                                    break;
                                case "ref":
                                    reference = smarr[1].Trim();
                                    break;
                                case "anchor":
                                    anchor = smarr[1].Trim();
                                    break ;
                            }
                        }
                    }
                    if (target == "page" && !string.IsNullOrEmpty(reference))
                    {
                        // Open new tab or go to tab
                        this.OpenTabPage((object)reference);
                    }
                    //MessageBox.Show(reference);
                }

            }
             catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadTabsOnLoad(BookFile bf)
        {
            this.tabControl_browser.TabPages.Clear();
            if (this.activeItemId == String.Empty)
            {
                this.activeItemId = this.openedBook.itemIdOfActiveTab;
            }

            int order = 0;
            foreach (Page tab in bf.tabs)
            {
                foreach (var item in bookStructure)
                {
                    if (item.id == tab.id)
                    {
                        //this.tabList.Add(new Page(item.id, item.name, order));
                        TabPage tp = new TabPage();
                        tp.Name = item.id;
                        tp.Tag = item.id;
                        tp.Text = item.name;
                        tp.DoubleClick += Tp_DoubleClick;
                        tp.Click += Tp_Click;


                        WebView2 wv = new WebView2();
                        //CoreWebView2 cww2 = new CoreWebView2("http://jfkasdj.kk");
                        //wv.CoreWebView2.
                        wv.Height = tabControl_browser.Height - this.tabViewTopOffset;
                        wv.Width = tabControl_browser.Width - this.tabViewPadding;

                        string filePath = Path.Combine(root, item.path, item.name + ".html");
                        string content = File.ReadAllText(filePath);
                        string context = content;

                        if (content != null)
                        {
                            // Content should be written withid <section id='bookerContent'... tag
                            // Check if file opened (by header "<!DOCTYPE html>")
                            if (content.Contains("<!DOCTYPE html>"))
                            {

                                // okay, it is opened file
                                // check if there are no body tags
                                if (content.Contains("<body") && content.Contains("</body>"))
                                {
                                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                                    doc.Load(filePath);
                                    doc.OptionFixNestedTags = true;
                                    HtmlNode node = doc.DocumentNode.SelectSingleNode("//section");
                                    if (node != null)
                                    {
                                        context = node.InnerHtml;
                                    }
                                    else
                                    {
                                        MessageBox.Show("There are some problems with document " + item.name + ".html. Try to remove all document data except content placed <section> and </section> tags (section tags should be removed).", "Document structure error!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("There are some problems with document " + item.name + ".html. Try to remove all document data except content placed <section> and </section> tags (section tags should be removed).", "Document structure error!");
                                }
                            }
                            // Renew template of the page based on Template and Styel
                            HtmlTemplates htm = new HtmlTemplates(UserConfig.languageCode);
                            string resultHtml = HtmlTemplates.HtmlBuildHtmlPage(bf, item, context, htm.GetScriptSection(), true);
                            File.WriteAllText(filePath, resultHtml);
                            //wv.CoreWebView2.NavigateToString(content);
                            Uri uri = new Uri(filePath);
                            // wv.CoreWebView2.Navigate("file:///" + Path.Combine(root, item.path, item.name + ".html"));
                            wv.Source = (uri);
                            tp.Controls.Add(wv);
                            wv.WebMessageReceived += Wv_WebMessageReceived;
                            wv.KeyPress += Wv_KeyPress;
                            // wv.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
                            tabControl_browser.Controls.Add(tp);
                            if (this.activeItemId == tab.id)
                            {
                                tabControl_browser.SelectedIndex = order;
                            }
                            order++;
                        }
                        else
                        {
                            MessageBox.Show("Document " + item.name + ".html. not found!", "Document not found error!");
                        }
                    }
                }
            }
        }


        private void Wv_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (this.tabSaved == true)
            {
                var act = this.activeItemId;
                foreach (TabPage tp in tabControl_browser.Controls)
                {
                    if (tp.Tag == act)
                    {
                        tp.Text = tp.Text + "*";
                        break;
                    }
                }
                this.tabSaved = false;
            }
        }


        private void Btn_openNavigationPanel_MouseHover(object? sender, EventArgs e)
        {
            if (!this.panel_bookNavigation.Visible)
            {
                this.panel_bookNavigation.Visible = true;
            }
            else
            {
                this.panel_bookNavigation.Visible = false;

            }
        }

        private void Panel_bookNavigation_MouseLeave(object? sender, EventArgs e)
        {
            if (Cursor.Position.X > this.panel_bookNavigation.Width + this.Left + 10)
            {
                this.panel_bookNavigation.Visible = false;
            }
        }



        #region decorators
        private void Btn_removeItem_MouseLeave(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox != null)
            {
                this.MakeBtnUnhovered(pictureBox);
            }
        }

        private void Btn_removeItem_MouseEnter(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox != null)
            {
                this.MakeBtnHovered(pictureBox);
            }
        }

        private void Btn_addFolder_MouseLeave(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox != null)
            {
                this.MakeBtnUnhovered(pictureBox);
            }
        }

        private void Btn_addFolder_MouseEnter(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox != null)
            {
                this.MakeBtnHovered(pictureBox);
            }
        }

        private void Btn_applyItem_MouseLeave(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox != null)
            {
                this.MakeBtnUnhovered(pictureBox);
            }
        }

        private void Btn_applyItem_MouseEnter(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox != null)
            {
                this.MakeBtnHovered(pictureBox);
            }
        }

        private void Btn_addPage_MouseLeave(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox != null)
            {
                this.MakeBtnUnhovered(pictureBox);
            }
        }

        private void Btn_addPage_MouseEnter(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox != null)
            {
                this.MakeBtnHovered(pictureBox);
            }
        }

        public void MakeBtnHovered(PictureBox pictureBox)
        {
            
            pictureBox.BackColor = Color.FromArgb(120, 40, 170, 255);
        }

        public void MakeBtnUnhovered(PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.White;
        }
        #endregion decorators

        private void TabControl_browser_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedTab = tabControl_browser.SelectedTab;
                string id = (string)selectedTab.Tag;
                if (id != null)
                {
                    int index = tabControl_browser.SelectedIndex;
                    tabControl_browser.TabPages.Remove(selectedTab);
                    int counter = 0;
                    foreach (var item in this.bookStructure)
                    {
                        if (item.id == id)
                        {
                            item.tabIndex = -1;
                        }
                        else
                        {
                            item.order = counter;
                            counter++;
                        }
                    }
                    int itemToRemoveIndex = -1;
                    for (int i = 0; i < tabList.Count; i++)
                    {
                        if (tabList[i].id == id)
                        {
                            itemToRemoveIndex = i;
                        }
                        if (itemToRemoveIndex != -1)
                        {
                            tabList[i].order = tabList[i].order - 1;
                        }
                    }
                    if (itemToRemoveIndex > -1)
                    {
                        tabList.RemoveAt(itemToRemoveIndex);
                    }
                }
                this.UpdateTabList();
            }
        }

        private void Tp_Click(object? sender, EventArgs e)
        {
            var tnode = (TabPage)sender;
        }

        private void Tp_DoubleClick(object? sender, EventArgs e)
        {
            var tnode = (TabPage)sender;
        }



        private void BookViewForm_Resize(object? sender, EventArgs e)
        {
            this.tabControl_browser.Height = this.ClientSize.Height - this.tabControl_browser.Top;
            this.tabControl_browser.Width = this.ClientSize.Width - this.tabControl_browser.Left + 2;
            this.panel_bookNavigation.BackColor = Color.RebeccaPurple;
            this.panel_bookNavigation.Height = this.ClientSize.Height - this.menuStrip_main.Height - 1;
            this.panel_bookNavBottomManage.Top = this.panel_bookNavigation.Height - this.panel_bookNavBottomManage.Height - 2;

            this.treeview_docStruct.Width = this.panel_bookNavigation.Width;
            this.treeview_docStruct.Left = 0;
            this.treeview_docStruct.Height = this.panel_bookNavigation.Height - this.panel_bookNavBottomManage.Height - this.treeview_docStruct.Top - this.tabViewPadding * 2;


            foreach (TabPage tabPage in this.tabControl_browser.Controls)
            {
                if (tabPage != null)
                {

                
                foreach (Control c in tabPage.Controls)
                {
                    if (c.GetType() == typeof(WebView2))
                    {
                        c.Width = this.tabControl_browser.Width - this.tabViewPadding;
                        c.Height = this.tabControl_browser.Height - this.tabViewTopOffset;
                    }
                }
                }
            }
        }


        private void Treeview_docStruct_NodeMouseDoubleClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            var tnode = (TreeNode)e.Node;
            if (tnode != null)
            {
                var id = tnode.Tag;
                _selectedNode = tnode;
                treeview_docStruct.SelectedNode = tnode;
                this._selectedNode = tnode;
                if (e.Button == MouseButtons.Left)
                {
                    this.OpenTabPage(id);
                }
                else
                {
                  /// If double click
                }

            }
        }


        public void OpenTabPage(object id)
        {
            if (!this.tabList.Contains(id))
            {
                ItemStructure item = null;
                foreach (var page in this.bookStructure)
                {
                    if (page.id == (string)id)
                    {
                        // Is it folder?
                        if (page.type == 2)
                        {
                            this.activeDirectory = Path.Combine(page.path, page.name);
                            this.activeLevel = page.level;
                            this.activeItemId = page.id;
                            return;
                        }
                        item = page;
                        this.activeDirectory = page.path;
                        this.activeLevel = page.level;
                        this.activeItemId = page.id;
                        foreach (Page opens in this.tabList)
                        {
                            if (opens.id == item.id)
                            {
                                this.tabControl_browser.SelectedIndex = opens.order;
                                return;
                            }
                        }
                    }
                }

                if (item == null)
                {
                    MessageBox.Show("The page you request can be removed =(", "Can't find target page");
                    return;
                }


                this.tabList.Add(new Page(item.id, item.name, tabList.Count));
                TabPage tp = new TabPage();
                tp.Name = item.id;
                tp.Tag = item.id;
                tp.Text = item.name;

                WebView2 wv = new WebView2();
                //CoreWebView2 cww2 = new CoreWebView2("http://jfkasdj.kk");
                //wv.CoreWebView2.
                wv.Height = tabControl_browser.Height - 28;
                wv.Width = tabControl_browser.Width - this.tabViewPadding;

                string filePath = Path.Combine(this.root, item.path, item.name + ".html");
                string content = File.ReadAllText(filePath);
                string context = content;

                if (content != null)
                {
                    // Content should be written withid <section id='bookerContent'... tag
                    // Check if file opened (by header "<!DOCTYPE html>")
                    if (content.Contains("<!DOCTYPE html>"))
                    {

                        // okay, it is opened file
                        // check if there are no body tags
                        if (content.Contains("<body") && content.Contains("</body>"))
                        {
                            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                            doc.Load(filePath);
                            doc.OptionFixNestedTags = true;
                            HtmlNode node = doc.DocumentNode.SelectSingleNode("//section");
                            if (node != null)
                            {
                                context = node.InnerHtml;
                            }
                            else
                            {
                                MessageBox.Show("There are some problems with document " + item.name + ".html. Try to remove all document data except content placed <section> and </section> tags (section tags should be removed).", "Document structure error!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("There are some problems with document " + item.name + ".html. Try to remove all document data except content placed <section> and </section> tags (section tags should be removed).", "Document structure error!");
                        }
                    }
                    // Renew template of the page based on Template and Styel
                    HtmlTemplates htm = new HtmlTemplates(UserConfig.languageCode);
                    string resultHtml = HtmlTemplates.HtmlBuildHtmlPage(this.openedBook, item, context, htm.GetScriptSection(), true);
                    File.WriteAllText(filePath, resultHtml);
                    //wv.CoreWebView2.NavigateToString(content);
                    Uri uri = new Uri(filePath);
                    // wv.CoreWebView2.Navigate("file:///" + Path.Combine(root, item.path, item.name + ".html"));
                    wv.Source = (uri);
                    wv.KeyPress += Wv_KeyPress;
                    tp.Controls.Add(wv);
                    wv.WebMessageReceived += Wv_WebMessageReceived;
                    tabControl_browser.Controls.Add(tp);
                    this.tabControl_browser.SelectedIndex = tabList.Count - 1;
                    this.activeItemId = item.id;
                    this.panel_bookNavigation.Visible = false;
                    this.UpdateTabList();
                }
                else
                {
                    MessageBox.Show("Document " + item.name + ".html. not found!", "Document not found error!");
                }

            }
        }

        private void Treeview_docStr_NodeMouseClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            var tnode = (TreeNode)e.Node;
            if (tnode != null)
            {
                var id = tnode.Tag;
                treeview_docStruct.SelectedNode = tnode;
                this._selectedNode = tnode;
                ItemStructure its = ItemStructure.GetItemStructById(this.bookStructure, (string)id);
                this.activeLevel = its.level;
                this.activeDirectory = its.path;
                this.activeItemId = its.id;
                this.activeItemName = its.name;
                if (this.activeLevel == 0) { this.activeLevel = 1; };
                if (e.Button == MouseButtons.Left)
                {

                }
                else
                {
                    // Open CONTEXT MENU
                    //  MessageBox.Show((string) id);
                    var positionX = Cursor.Position.X;
                    var positionY = Cursor.Position.Y;
                    //this.contextMenuStrip_treeNode.Location = new Point(positionX, positionY);
                    this.contextMenuStrip_treeNode.Items.Clear();
                    this.contextMenuStrip_treeNode.Visible = true;
                    //Point loc = new Point(positionX - this.Left, positionY - this.Top);
                    Point loc = e.Location;
                    //this.contextMenuStrip_treeNode.Location = loc;

                    this.contextSelectedId = (string)id;

                    this.contextStruct = ItemStructure.GetItemStructById(this.bookStructure, (string)id);
                    if (contextStruct == null) { return; }
                    if (contextStruct.type == 1)
                    {
                        ToolStripMenuItem tsmi = new ToolStripMenuItem();
                        tsmi.Text = "Rename Page";
                        tsmi.Tag = this.contextSelectedId;
                        tsmi.Click += Tsmi_Click_RENAME;
                        this.contextMenuStrip_treeNode.Items.Add(tsmi);

                        tsmi = new ToolStripMenuItem();
                        tsmi.Text = "Remove Page";
                        tsmi.Tag = this.contextSelectedId;
                        tsmi.Click += Tsmi_Click_REMOVE;
                        this.contextMenuStrip_treeNode.Items.Add(tsmi);
                    }
                    else if (contextStruct.type == 2)
                    {
                        ToolStripMenuItem tsmi = new ToolStripMenuItem();
                        tsmi.Text = "Rename Folder";
                        tsmi.Tag = this.contextSelectedId;
                        tsmi.Click += Tsmi_Click_RENAME;
                        this.contextMenuStrip_treeNode.Items.Add(tsmi);

                        tsmi = new ToolStripMenuItem();
                        tsmi.Text = "Remove Folder";
                        tsmi.Tag = this.contextSelectedId;
                        tsmi.Click += Tsmi_Click_REMOVE;
                        this.contextMenuStrip_treeNode.Items.Add(tsmi);
                    }
                    this.contextMenuStrip_treeNode.Show((Control)sender, loc);
                }
            }
        }


        private void Tsmi_Click_REMOVE(object? sender, EventArgs e)
        {
            if (this.contextStruct.type == 1)
            {
                var prompt = MessageBox.Show("Do you really want to remove page '" + this.contextStruct.name + "' ?", "Item destruction", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (prompt == DialogResult.OK)
                {
                    var idToDel = this.contextSelectedId;
                    var path = Path.Combine(this.root, this.contextStruct.path, this.contextStruct.name) + ".html";
                    File.Delete(path);
                    treeview_docStruct.BeginUpdate();
                    treeview_docStruct.Nodes.Remove(_selectedNode);
                    treeview_docStruct.EndUpdate();

                    foreach (var its in this.bookStructure)
                    {
                        if (its.id == idToDel)
                        {
                            this.bookStructure.Remove(its);
                            break;
                        }
                    }

                    int index = 0;
                    foreach (TabPage tab in this.tabControl_browser.Controls)
                    {
                        if (tab.Tag == idToDel)
                        {
                            this.tabControl_browser.Controls.RemoveAt(index);
                            break;
                        }
                        index++;
                    }

                    index = 0;
                    foreach (ItemStructure its in this.bookStructure)
                    {
                        if (its.id == idToDel)
                        {
                            this.bookStructure.RemoveAt(index);
                            break;
                        }
                    }

                    this.UpdateTabList();
                    this.SaveBookStruture();
                    this.SaveBookManifest();
                }

            } 
            else if (this.contextStruct.type == 2)
            {
                var prompt = MessageBox.Show("Do you really want to remove folder '" + this.contextStruct.name + " ?", "Item destruction", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (prompt == DialogResult.OK)
                {
                    var idToDel = this.contextSelectedId;
                    var path = Path.Combine(this.root, this.contextStruct.path, this.contextStruct.name);
                    if (Directory.Exists(path))
                    {
                        if (Directory.GetFiles(path).Length > 0)
                        {
                            MessageBox.Show("Move or remove all Pages before remove directory.", "Directory not empty!");
                            return;
                        }

                        Directory.Delete(path);
                        treeview_docStruct.BeginUpdate();
                        treeview_docStruct.Nodes.Remove(_selectedNode);
                        treeview_docStruct.EndUpdate();

                        foreach (var its in this.bookStructure)
                        {
                            if (its.id == idToDel)
                            {
                                this.bookStructure.Remove(its);
                                break;
                            }
                        }

                        int index = 0;
                        foreach (ItemStructure its in this.bookStructure)
                        {
                            if (its.id == idToDel)
                            {
                                this.bookStructure.RemoveAt(index);
                                break;
                            }
                        }

                        this.SaveBookStruture();
                        this.SaveBookManifest();
                    }
                }
            }
        }

        private void Tsmi_Click_RENAME(object? sender, EventArgs e)
        {
            MessageBox.Show(this.contextSelectedId);
        }


        private void Treeview_docStr_DragEnter(object? sender, DragEventArgs e)
        {

                    e.Effect = DragDropEffects.Move;

        }

        private void Treeview_docStr_DragDrop(object? sender, DragEventArgs e)
        {
            TreeNode sourceNode = _selectedNode;
            if (sourceNode != null)
            {
                if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
                {
                    Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                    TreeNode destinationNode = ((TreeView)sender).GetNodeAt(pt);
                    if (destinationNode != null)
                    {
                        //MessageBox.Show(pt.Y.ToString(), pt.X.ToString());
                        ItemStructure sourcePage = ItemStructure.GetItemStructById(this.bookStructure, sourceNode.Tag.ToString());
                        ItemStructure targetPage = ItemStructure.GetItemStructById(this.bookStructure, destinationNode.Tag.ToString());

                        if (targetPage.type == 1)
                        {
                            // if Plain page
                            if (sourcePage.type == 1)
                            {
                                bool ou = File.Exists(Path.Combine(this.root, targetPage.path, sourcePage.name + ".html"));
                                if (ou)
                                {
                                    MessageBox.Show("File with the same name is already exists!", "Warning!");
                                    return;
                                }
                                // Move Page to Page level and reorder
                                int newLevel = targetPage.level;
                                string sourceFile = Path.Combine(this.root, sourcePage.path, sourcePage.name + ".html");
                                File.Move(sourceFile, Path.Combine(this.root, targetPage.path, sourcePage.name + ".html"));

                                sourcePage.path = targetPage.path;
                                sourcePage.level = newLevel;
                                sourcePage.order = targetPage.order + 1;

                                this.bookStructure = ItemStructure.Reorder(this.bookStructure, sourcePage);

                            }
                            else if (sourcePage.type == 2)
                            {
                                // Move folder to page level and reorder
                                return;
                                /// too hard
                            }
                        }
                        else  if (targetPage.type == 2)
                        {
                            // If FOLDER
                            if (sourcePage.type == 1)
                            {
                                bool ou = File.Exists(Path.Combine(this.root, targetPage.path, targetPage.name, sourcePage.name + ".html"));
                                if (ou)
                                {
                                    MessageBox.Show("File with the same name is already exists!", "Warning!");
                                    return;
                                }
                                // Move Page to Page level and reorder
                                int newLevel = targetPage.level + 1;
                                string targetFolder = Path.Combine(targetPage.path, targetPage.name);
                                string sourceFile = Path.Combine(this.root, sourcePage.path, sourcePage.name + ".html");
                                File.Move(sourceFile, Path.Combine(this.root, targetFolder, sourcePage.name + ".html"));

                                sourcePage.path = targetFolder;
                                sourcePage.level = newLevel;
                                sourcePage.order = targetPage.order + 1;

                                this.bookStructure = ItemStructure.Reorder(this.bookStructure, sourcePage);

                            }
                            else if (sourcePage.type == 2)
                            {
                                // Move folder to folder level and reorder
                                if (targetPage.level < 2) { return; }
                                return;

                                /// too hard
                            }
                        }
                        //this.LoadTabsOnLoad(this.openedBook);
                        this.SaveBookStruture();
                        this.FillBookTree();
                    }
                }
            }
        }

        private void Treeview_docStr_ItemDrag(object? sender, ItemDragEventArgs e)
        {
            var tnode = (TreeNode)e.Item;
            if (tnode != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    _selectedNode = tnode;
                    treeview_docStruct.SelectedNode = tnode;
                    DoDragDrop(e.Item, DragDropEffects.Move);
                }
            }


        }

        private async void BookViewForm_Load(object? sender, EventArgs e)
        {
            FillBookTree();
        }

        private async void FillBookTree()
        {
            try
            {
                this.treeview_docStruct.Nodes.Clear();
                if (bookStructure.Count > 0)
                {
                    treeview_docStruct.BeginUpdate();
                    int lastlevel = 1;
                    int lastCounter = 0;
                    TreeNode parentNode = new TreeNode();
                    List<TreeNode> tn = new List<TreeNode>();
                    List<TreeNode> levels = new List<TreeNode>();
                    /// first and second elements are nothing
                    levels.Add(parentNode);
                    levels.Add(parentNode);
                    foreach (ItemStructure item in bookStructure)
                    {
                    
                        //Contents item = Library.collection[Library.idCollection.Count - 1];
                        TreeNode tren = new TreeNode(item.name);
                        tren.Tag = item.id;
                        tren.Name = item.name;


                        if (item.type == 1)
                        {
                            tren.Text =  item.name;
                        }
                        foreach (Page tab in this.tabList)
                        {
                            if (tab.id == item.id)
                            {

                                tren.ForeColor = Color.DarkBlue;
                                tren.Text = "● " + item.name;
                            }
                        }
                        if (item.type == 2)
                        {
                            string names  = "/ " + item.name;
                            tren.Text = names;
                            tren.ForeColor = this.treeFolderNameColor;
                            if (item.isOpen)
                            {
                                tren.Expand();
                            }

                            if (levels.Count <= item.level)
                            {
                                levels.Add(tren);

                            } 
                            else
                            {
                                levels[item.level] = tren;
                            }
                        }
                        if (item.level == 1 || item.level == 0)
                        {
                            this.treeview_docStruct.Nodes.Add(tren);
                        } 
                        else
                        {
                            levels[item.level - 1].Nodes.Add(tren);
                        }

                        lastlevel = item.level;
                    }
                    
                    treeview_docStruct.EndUpdate();
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 919");
            }

    
        }

        private void tabControl_browser_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int currentX  = Cursor.Position.X;
                int itemWidth = tabControl_browser.ItemSize.Width;
                if (currentX  < mouseX - itemWidth / 2)
                {
                    int index = tabControl_browser.SelectedIndex;
                    if (index > 0)
                    {
                        tabControl_browser.TabPages.Remove(selectedTab);
                        tabControl_browser.TabPages.Insert(index - 1, selectedTab);
                        tabControl_browser.SelectedTab = selectedTab;
                    }
                }
                else if (currentX > mouseX + itemWidth / 2)
                {
                    int index = (int)tabControl_browser.SelectedIndex;
                    if (index < tabControl_browser.TabPages.Count - 1)
                    {
                        tabControl_browser.TabPages.Remove(selectedTab);
                        tabControl_browser.TabPages.Insert(index + 1, selectedTab);
                        tabControl_browser.SelectedTab = selectedTab;
                    }
                }
                //else
                //{
                //    tabControl_browser.TabPages.Remove(selectedTab);
                //    tabControl_browser.TabPages.Insert(2, selectedTab);
                //    tabControl_browser.SelectedTab = selectedTab;
                //}
                this.UpdateTabList();
            }
        }

        private void tabControl_browser_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedTab = tabControl_browser.SelectedTab;
                mouseX = Cursor.Position.X;
                activeItemId = tabControl_browser.SelectedTab.Name;
            }
        }

        public void UpdateTabList()
        {
            this.tabList.Clear();
            int counter = 0;
            foreach(TabPage tab in tabControl_browser.TabPages)
            {
                Page pg = new Page((string)tab.Tag, (string)tab.Text, counter);
                this.tabList.Add(pg);
                counter++;
            }
            this.UpdateTreeItemState();
        }

        public void UpdateTreeItemState()
        {
            foreach (TreeNode tren in this.treeview_docStruct.Nodes)
            {
                tren.Text = tren.Name.Trim();
                tren.ForeColor = Color.Black;
                foreach (Page pg in this.tabList)
                {
                    if (pg.id == tren.Tag)
                    {
                        tren.ForeColor = Color.DarkBlue;
                        tren.Text = "● " + tren.Name;
                        break;
                    }
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //string Text = await webVisor.ExecuteScriptAsync("document.getElementsByTagName('body')[0].innerHTML;");
            //MessageBox.Show(Text);
            //await webVisor2.ExecuteScriptAsync("document.getElementsByTagName('body')[0].setAttribute('contenteditable', true);");
        }

        private async void Tool_savePage_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(activeItemId))
            {
                WebView2 wew = null;
                foreach (TabPage tp in tabControl_browser.TabPages)
                {
                    if (tp.Name == activeItemId)
                    {
                        foreach (var control in tp.Controls)
                        {
                            WebView2 v = control as WebView2;
                            if (v != null)
                            {
                                wew = v;
                                break;
                            }
                        }
                    }

                }
                if (wew != null)
                {
                    string result = await wew.ExecuteScriptAsync("document.getElementById('bookerContent').innerHTML;");
                    if (!string.IsNullOrEmpty(result))
                    {
                        result = Regex.Unescape(result);
                        result = result.TrimStart('"');
                        result = result.TrimEnd('"');

                        foreach (var page in bookStructure)
                        {
                            if (page.id == activeItemId)
                            {
                                string path = Path.Combine(openedBook.directory, page.path, page.name + ".html");
                                File.WriteAllText(path, result);
                                break;
                            }
                        }
                    }
                    this.tabSaved = true;
                }
            }
        }


        private async void Tool_saveBook_Click(object? sender, EventArgs e)
        {
            this.SaveBookManifest();
        }


        #region TRASH
        public string EntityToUnicode(string html)
        {
            var replacements = new Dictionary<string, string>();
            var regex = new Regex("(&[a-z]{2,5};)");
            foreach (Match match in regex.Matches(html))
            {
                if (!replacements.ContainsKey(match.Value))
                {
                    var unicode = HttpUtility.HtmlDecode(match.Value);
                    if (unicode.Length == 1)
                    {
                        replacements.Add(match.Value, string.Concat("&#", Convert.ToInt32(unicode[0]), ";"));
                    }
                }
            }
            foreach (var replacement in replacements)
            {
                html = html.Replace(replacement.Key, replacement.Value);
            }
            return html;
        }

        private void btn_openNavigationPanel_Click(object sender, EventArgs e)
        {
            if (panel_bookNavigation.Visible)
            {
                this.panel_bookNavigation.Visible = false;
            }
            else
            {
                this.panel_bookNavigation.Visible = true;
            }
        }


        private async Task FillGeneratedCollection(int i)
        {
            int lastLevel = 1;
            string iden = ID.Generate();
            while (Library.idCollection.Contains(iden))
            {
                iden = ID.Generate();
            }
            var random = new Random();
            //if (lastLevel == 1)
            //{
            lastLevel = random.Next(1, 2);
            //} 
            //else if (lastLevel == 2)
            //{
            //    lastLevel = random.Next(1, 3);
            //} 
            //else if (lastLevel == 3)
            //{
            //    lastLevel = random.Next(2, 4);
            //} 
            //else if (lastLevel == 4)
            //{
            //    lastLevel = random.Next(3, 4);
            //}

            Contents drow = new Contents(iden, DataType.Sheet, Format.Text, i);
            drow.Author = RandomText.generateRandomString(10);
            drow.Description = RandomText.generateRandomString(50);
            drow.Name = i.ToString() + " " + RandomText.generateRandomString(6);
            drow.Data = drow.Name + "\r\n" + RandomText.generateRandomString(random.Next(100, 11200));
            drow.Parent = ID.Root;
            drow.Edits = 0;
            drow.Views = 1;
            drow.Level = lastLevel;
            drow.Order = i;
            drow.DateC = DateTime.Now.ToFileTime();
            drow.DateM = DateTime.Now.ToFileTime();
            Library.collection.Add(drow);
            Library.idCollection.Add(iden);
            UpdateTree(Library.collection);
            await Task.Delay(10);

        }
        #endregion TRASH


        public void UpdateTree(List<Contents> collection)
        {
            if (collection.Count > 0)
            {
                //TreeNodeCollection tnk = treeview_docStr.Nodes;
                //tnk.Clear();
                treeview_docStruct.BeginUpdate();
                int lastlevel = 0;
                int lastCounter = 0;

                Contents item = Library.collection[Library.idCollection.Count - 1];
                TreeNode tren = new TreeNode(item.Name);
                tren.Tag = item.Id;
                if (item.Type == 2)
                {
                    tren.ForeColor = this.treeFolderNameColor;
                }
                treeview_docStruct.Nodes.Add(tren);

                //foreach (var item in collection)
                //{
                //    TreeNode tren = new TreeNode(item.Name);
                //    tren.Tag = item.Id;
                //    treeview_docStr.Nodes.Add(tren);

                //}
                treeview_docStruct.EndUpdate();
            }
        }

        /// <summary>
        /// Rremove Item (Select item in the tree -> click -> Prompt -> ok -> remove());
        /// Discard: write something -> click -> empty input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            this.editItemMode = false;
        }

        /// <summary>
        /// Onclick rewrite item name (and file name)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_applyItem_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Creates new folder in the tree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addFolder_Click(object sender, EventArgs e)
        {
            if (this.activeLevel == 0) { this.activeLevel = 1; };
            if (!string.IsNullOrEmpty(this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.')))
            {
                if (BookFile.IsValidFilename(this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.')))
                {
                    string fullPath = Path.Combine(this.root, this.activeDirectory, this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.'));
                    bool ou = Directory.Exists(fullPath);
                    if (ou)
                    {
                        MessageBox.Show("Folder is already exists!", "Warning!");
                        return;
                    }
                    var fs = Directory.CreateDirectory(fullPath);
                    
                        UserConfig.OpenFileSequrity(fullPath);
                        if (fs != null)
                        {
                            ItemStructure its = new ItemStructure();
                            its.order = this.bookStructure.Count;
                            its.path = this.activeDirectory;
                            its.level = this.activeLevel;
                            its.type = 2;
                            its.name = this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.');
                            its.id = ID.Generate(32);
                            its.tabIndex = -1;
                            this.bookStructure.Add(its);

                            this.openedBook.folderCount++;
                            this.SaveBookManifest();
                            this.SaveBookStruture();

                            this.AddItemIntoTreeView(its);
                        this.textBox_itemEditName.Text = String.Empty;

                    };
                }
                else
                {
                    MessageBox.Show("Folder name is invalid!", "Warning!");
                }
            }
            else
            {
                this.textBox_itemEditName.BackColor = Color.LightPink;
                MessageBox.Show("Input should not be empty!", "Warning!");
                this.textBox_itemEditName.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Creates new page in the tree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addPage_Click(object sender, EventArgs e)
        {
            if (this.activeLevel == 0) { this.activeLevel = 1; };
            if (!string.IsNullOrEmpty(this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.')))
            {
                if (BookFile.IsValidFilename(this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.')))
                {
                    string fullPath = Path.Combine(this.root, this.activeDirectory, this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.') + ".html");
                    bool ou = File.Exists(fullPath);
                    if (ou)
                    {
                        MessageBox.Show("File is already exists!", "Warning!");
                        return;
                    }
                    using (var fs = File.Create(fullPath))
                    {
                        UserConfig.OpenFileSequrity(fullPath);
                        if (fs != null)
                        {
                            ItemStructure its = new ItemStructure();
                            its.order = this.bookStructure.Count;
                            its.path = this.activeDirectory;
                            its.level = this.activeLevel;
                            its.type = 1;
                            its.name = this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.');
                            its.id = ID.Generate(32);
                            its.tabIndex = -1;
                            this.bookStructure.Add(its);

                            this.openedBook.pageCount++;
                            this.SaveBookManifest();
                            this.SaveBookStruture();

                            this.AddItemIntoTreeView(its);
                            this.textBox_itemEditName.Text = String.Empty;
                        }
                    };
                }
                else
                {
                    MessageBox.Show("File name is invalid!", "Warning!");
                }
            }
            else
            {
                this.textBox_itemEditName.BackColor = Color.LightPink;
                MessageBox.Show("Input should not be empty!", "Warning!");
                this.textBox_itemEditName.BackColor = Color.White;
            }
        }


        private void SaveBookManifest()
        {
            this.openedBook.itemIdOfActiveTab = this.activeItemId;
            this.openedBook.updated = DateTime.Now;
            this.openedBook.updator = UserConfig.userName;
            string manifest = BooksFilesUtils.BuildBookManifest(this.openedBook);
            File.WriteAllText(this.openedBook.manifestPath, manifest);
        }

        private void SaveBookStruture()
        {
            string structure = BooksFilesUtils.BuildBookStructure(this.bookStructure);
            File.WriteAllText(this.openedBook.structPath, structure);
        }

        private void AddItemIntoTreeView(ItemStructure item)
        {
            treeview_docStruct.BeginUpdate();

                int lastlevel = 0;
                int lastCounter = 0;

            //Contents item = Library.collection[Library.idCollection.Count - 1];
            TreeNode tren = new TreeNode("New");
            if (item.type == 1)
            {


                tren = new TreeNode(item.name);
                tren.Text = item.name;
            }
            else
            {
                tren = new TreeNode("/ " + item.name);
                tren.Text = "/ " + item.name;
                tren.ForeColor = this.treeFolderNameColor;
            }
                tren.Tag = item.id;
                treeview_docStruct.Nodes.Add(tren);

            treeview_docStruct.EndUpdate();
        }







        private async void btn_tool_header_Click(object sender, EventArgs e)
        {
            WebView2 wew = this.GetActiveWebView();
            if (wew != null)
            {
                await wew.ExecuteScriptAsync("document.execCommand('formatBlock', false, '<h3>');");
            }
        }


        private async void btn_tool_hr_Click(object sender, EventArgs e)
        {
            WebView2 wew = this.GetActiveWebView();
            if (wew != null)
            {
                await wew.ExecuteScriptAsync("document.execCommand('insertHorizontalRule',false,'');");
            }
        }


        private async  void btn_tool_ol_Click(object sender, EventArgs e)
        {
            WebView2 wew = this.GetActiveWebView();
            if (wew != null)
            {
                await wew.ExecuteScriptAsync("document.execCommand('insertOrderedList', false, '');");
            }
        }

        private async void btn_tool_ul_Click(object sender, EventArgs e)
        {
            WebView2 wew = this.GetActiveWebView();
            if (wew != null)
            {
                await wew.ExecuteScriptAsync("document.execCommand('insertUnorderedList', false, '');");
            }
        }

        private async void btn_tool_code_Click(object sender, EventArgs e)
        {
            WebView2 wew = this.GetActiveWebView();
            if (wew != null)
            {
                await wew.ExecuteScriptAsync("document.execCommand('formatBlock', false, '<pre>');");
            }
        }

        private async  void btn_tool_insertAnchor_Click(object sender, EventArgs e)
        {
            WebView2 wew = this.GetActiveWebView();
            if (wew != null)
            {
                string text = "target:page$ref:df7g89745hjkhjkhtgsjk$anchor:bid";
                await wew.ExecuteScriptAsync("document.execCommand('insertHTML', false, '<a class=\"goto\" href=\"blank.html\"  goto=\"" + text + "\">Blank Named anchor</a>');");
            }
        }

        private async void btn_tool_clearFormat_Click(object sender, EventArgs e)
        {
            WebView2 wew = this.GetActiveWebView();
            if (wew != null)
            {
                //await wew.ExecuteScriptAsync("document.execCommand('formatBlock', false, 'div'); ");
                await wew.ExecuteScriptAsync("function clearFormat(e){\r\n\r\nconst selection = window.getSelection();\r\nif (!selection.isCollapsed) {\r\n  if (selection.anchorNode.parentNode.tagName === 'FONT'\r\n  || selection.anchorNode.parentNode.tagName === 'SPAN'\r\n  || selection.anchorNode.parentNode.tagName === 'B'\r\n  || selection.anchorNode.parentNode.tagName === 'U'\r\n  || selection.anchorNode.parentNode.tagName === 'U'\r\n  || selection.anchorNode.parentNode.tagName === 'I'\r\n  || selection.anchorNode.parentNode.tagName === 'HREF'\r\n  || selection.anchorNode.parentNode.tagName === 'STRIKE'\r\n  || selection.anchorNode.parentNode.tagName === 'CODE'\r\n  || selection.anchorNode.parentNode.tagName === 'H3'\r\n  || selection.anchorNode.parentNode.tagName === 'H1'\r\n\r\n  ){\r\n    selection.anchorNode.parentNode.replaceWith(selection.anchorNode);\r\n\r\n    e.preventDefault();\r\n  }\r\n}\r\n}");
                await wew.ExecuteScriptAsync("clearFormat();");
                await wew.ExecuteScriptAsync("document.execCommand('formatBlock', false, 'div'); ");
            }
        }


        private async void HighlightHtmlText(object? sender, EventArgs e)
        {
            ToolStripMenuItem tdb  = (ToolStripMenuItem)sender;
            string color = "lightgreen";
            string fcol = null;
            if (tdb != null)
            {
                HtmlColors htc = tdb.Tag as HtmlColors;
                color = htc.htmlColor.ToLower();
                if (htc.foreColor != Color.Black)
                {
                    fcol = htc.textColor.ToLower();
                }
            }
            WebView2 wew = this.GetActiveWebView();
            if (wew != null)
            {
                await wew.ExecuteScriptAsync("document.execCommand('hiliteColor', false, '" + color + "');");
                if (fcol != null)
                {
                    await wew.ExecuteScriptAsync("document.execCommand('forecolor', false, '" + fcol + "');");
                }
            }
        }

        private async void btn_tool_highlight_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Get active Webview to Apply modifiers
        /// </summary>
        /// <returns></returns>
        public WebView2 GetActiveWebView()
        {
            if (!string.IsNullOrEmpty(this.activeItemId))
            {
                WebView2 wew = null;
                foreach (TabPage tp in tabControl_browser.TabPages)
                {
                    if (tp.Name == this.activeItemId)
                    {
                        foreach (var control in tp.Controls)
                        {
                            WebView2 v = control as WebView2;
                            if (v != null)
                            {
                                return v;
                            }
                        }
                    }
                }
            }
            return null;
        }

        private async void toolBtn_insertRofToPage_Click(object sender, EventArgs e)
        {
            TransReferenceGoToPage trdp = new TransReferenceGoToPage();
            Prompt_PageRefer_Form pf = new Prompt_PageRefer_Form(this.bookStructure, trdp);
            
            pf.ShowDialog();
    
                    if (string.IsNullOrEmpty(trdp.referencePage))
                    {
                        return;
                    }

            WebView2 wew = this.GetActiveWebView();
            if (wew != null)
            {
                string text = "target:page$ref:" + trdp.referencePage + "$anchor:" + trdp.referenceAnch;
                string href = string.Empty;
                ItemStructure its = ItemStructure.GetItemStructById(this.bookStructure, trdp.referencePage);
                ItemStructure source = ItemStructure.GetItemStructById(this.bookStructure, this.activeItemId);
                if (its != null)
                {
                    string down = string.Empty;
                    for (int i = 1; i < source.level; i++)
                    {
                        down += "../";
                    }
                    string path = string.Empty;
                            if (its.path.Length > 0)
                            {
                                path = its.path.Replace('\\', '/') + "/"; ;
                            }
                    href = down + path + its.name + ".html";
                }

                await wew.ExecuteScriptAsync("document.execCommand('insertHTML', false, '<a class=\"goto\" href=\"" + href + "\"  goto=\"" + text + "\">" + trdp.referenceText + "</a>');");
            }
        }

        private async void toolStripMenuItem_replaceText_Click(object sender, EventArgs e)
        {
            if (tabControl_browser.TabCount > 0)
            {
                WebView2 wew = null;

                    if (tabControl_browser.SelectedTab != null)
                    {
                        foreach (var control in tabControl_browser.SelectedTab.Controls)
                        {
                            WebView2 v = control as WebView2;
                            if (v != null)
                            {
                                wew = v;
                                break;
                            }
                        }
                    }

                
                if (wew != null)
                {
                    try
                    {
                        string result = await wew.ExecuteScriptAsync("document.getElementById('bookerContent').innerHTML;");
                        if (!string.IsNullOrEmpty(result))
                        {
                            //result = Regex.Unescape(result);
                            result = result.TrimStart('"');
                            result = result.TrimEnd('"');
                            Page temp = new Page();
                            temp.name = result;

                            Prompt_page_textReplace_Form prf = new Prompt_page_textReplace_Form(temp);
                            prf.Visible = true;
                            prf.WindowState = FormWindowState.Normal;
                            prf.TopMost = true;

                           
                             while (prf.ToDestroy != true)
                            {
                                await Task.Delay(1);
                            }
                            //prf.Close();

                            if (temp.name != result && prf.NotClosed == false)
                            {
                                await wew.ExecuteScriptAsync("document.getElementById('bookerContent').innerHTML = \"" + temp.name + "\";");
                            }
                            prf.Close();
                        }

                    } 
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        //    if(e.Button == MouseButtons.Right)
        //    {
        //        TreeNode destinationNode = ((TreeView)sender).GetNodeAt(new Point(e.X, e.Y));
        //    //Do stuff
        //}

    }
}

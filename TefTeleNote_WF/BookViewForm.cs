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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using TefTeleNote_WF.Data;
using TefTeleNote_WF.Generators;
using TefTeleNote_WF.Templates;
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
        public List<ItemStructure> itemStructure;
        /// <summary>
        /// List of the pages opened AS TABS
        /// </summary>
        public List<Page> openedPageList;
        /// <summary>
        /// ID of the active TAB (tag = id of the page)
        /// </summary>
        public string activeItemId = string.Empty;
        public string activeItemName = string.Empty;
        public string activeDirectory = string.Empty;
        public int activeLevel = 0;


        private int tabViewPadding = 6;
        private int tabViewTopOffset = 28;

        /// <summary>
        /// Root of the book's directory
        /// </summary>
        public string root;

        public int tabHeight;
        public int tabWidth;

        public bool editItemMode = false;


        private TreeNode _selectedNode;

        public BookViewForm(BookFile bf)
        {
            InitializeComponent();
            this.openedPageList = new List<Page>();
            this.panel_bookNavigation.Visible = false;

            this.menuStrip_main.BackColor = Color.LightGray;
            this.BackColor = Color.LightGray;


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
            this.itemStructure = BooksFilesUtils.LoadBookStructure(new DirectoryInfo(root));

            this.tabControl_browser.TabPages.Clear();
            int activeTabs = 0;

            int order = 0;
            foreach (var item in itemStructure)
            {
                if (item.tabIndex != -1)
                {
                    this.openedPageList.Add(new Page(item.id, item.name, order));
                    TabPage tp = new TabPage();
                    tp.Name = item.id;
                    tp.Tag = item.id;
                    tp.Text = item.name;
                    tp.DoubleClick += Tp_DoubleClick;
                    tp.Click += Tp_Click;
                    order++;

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
                        string resultHtml = HtmlTemplates.HtmlBuildHtmlPage(bf, item, context, "", true);
                        File.WriteAllText(filePath, resultHtml);
                        //wv.CoreWebView2.NavigateToString(content);
                        Uri uri = new Uri(filePath);
                        // wv.CoreWebView2.Navigate("file:///" + Path.Combine(root, item.path, item.name + ".html"));
                        wv.Source = (uri);
                        tp.Controls.Add(wv);
                        tabControl_browser.Controls.Add(tp);
                        if (activeTabs == 0)
                        {
                            if (activeItemId == string.Empty)
                            {
                                activeItemId = item.id;
                            }
                        }
                        activeTabs++;
                    }
                    else
                    {
                        MessageBox.Show("Document " + item.name + ".html. not found!", "Document not found error!");
                    }
                }
            }
            this.treeview_docStr.ItemDrag += Treeview_docStr_ItemDrag;
            this.treeview_docStr.DragDrop += Treeview_docStr_DragDrop;
            this.treeview_docStr.DragEnter += Treeview_docStr_DragEnter;
            
            this.Load += BookViewForm_Load;
            this.treeview_docStr.NodeMouseClick += Treeview_docStr_NodeMouseClick;

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
                    foreach (var item in this.itemStructure)
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
                    for (int i = 0; i < openedPageList.Count; i++)
                    {
                        if (openedPageList[i].id == id)
                        {
                            itemToRemoveIndex = i;
                        }
                        if (itemToRemoveIndex != -1)
                        {
                            openedPageList[i].order = openedPageList[i].order - 1;
                        }
                    }
                    if (itemToRemoveIndex > -1)
                    {
                        openedPageList.RemoveAt(itemToRemoveIndex);
                    }
                }

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
            this.tabControl_browser.Width = this.ClientSize.Width - this.tabControl_browser.Left;
            this.panel_bookNavigation.BackColor = Color.RebeccaPurple;
            this.panel_bookNavigation.Height = this.ClientSize.Height - this.menuStrip_main.Height - 1;
            this.panel_bookNavBottomManage.Top = this.panel_bookNavigation.Height - this.panel_bookNavBottomManage.Height - 2;

            this.treeview_docStr.Width = this.panel_bookNavigation.Width;
            this.treeview_docStr.Left = 0;
            this.treeview_docStr.Height = this.panel_bookNavigation.Height - this.panel_bookNavBottomManage.Height - this.treeview_docStr.Top - this.tabViewPadding * 2;


            foreach (TabPage tabPage in this.tabControl_browser.Controls)
            {
                if (tabPage != null)
                {

                
                foreach (Control c in tabPage.Controls)
                {
                    if (c.GetType() == typeof(WebView2))
                    {
                        c.Width = this.tabControl_browser.Width - this.tabViewPadding  * 3 ;
                        c.Height = this.tabControl_browser.Height - this.tabViewTopOffset - this.tabViewPadding * 3;
                    }
                }
                }
            }
        }

        private void Treeview_docStr_NodeMouseClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            var tnode = (TreeNode)e.Node;
            if (tnode != null)
            {
                var id = tnode.Tag;
                if (!this.openedPageList.Contains(id))
                {
                    ItemStructure item = null;
                    foreach (var page in this.itemStructure)
                    {
                        if (page.id == id)
                        {
                            item = page;
                            foreach (Page opens in this.openedPageList)
                            {
                                if (opens.id == item.id)
                                {
                                    this.tabControl_browser.SelectedIndex = opens.order;
                                    return;
                                }
                            }
                        }
                    }

                    this.openedPageList.Add(new Page(item.id, item.name, openedPageList.Count));
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
                        string resultHtml = HtmlTemplates.HtmlBuildHtmlPage(this.openedBook, item, context, "", true);
                        File.WriteAllText(filePath, resultHtml);
                        //wv.CoreWebView2.NavigateToString(content);
                        Uri uri = new Uri(filePath);
                        // wv.CoreWebView2.Navigate("file:///" + Path.Combine(root, item.path, item.name + ".html"));
                        wv.Source = (uri);
                        tp.Controls.Add(wv);
                        tabControl_browser.Controls.Add(tp);
                        this.tabControl_browser.SelectedIndex = openedPageList.Count - 1;
                        this.activeItemId = item.id;
                        this.panel_bookNavigation.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Document " + item.name + ".html. not found!", "Document not found error!");
                    }
                }

            }
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
                        //ur target
                        MessageBox.Show(pt.Y.ToString(), pt.X.ToString());
                    }
                }
            }
        }

        private void Treeview_docStr_ItemDrag(object? sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
            _selectedNode = (TreeNode)e.Item;
        }

        private async void BookViewForm_Load(object? sender, EventArgs e)
        {
            FillBookTree();
        }

        private async void FillBookTree()
        {
            if (itemStructure.Count > 0)
            {
                treeview_docStr.BeginUpdate();
                foreach (ItemStructure item in itemStructure)
                {
                    int lastlevel = 0;
                    int lastCounter = 0;

                    //Contents item = Library.collection[Library.idCollection.Count - 1];
                    TreeNode tren = new TreeNode(item.name);
                    tren.Tag = item.id;
                    treeview_docStr.Nodes.Add(tren);

                }
                //TreeNodeCollection tnk = treeview_docStr.Nodes;
                //tnk.Clear();

                //foreach (var item in collection)
                //{
                //    TreeNode tren = new TreeNode(item.Name);
                //    tren.Tag = item.Id;
                //    treeview_docStr.Nodes.Add(tren);

                //}
                treeview_docStr.EndUpdate();
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

        private async void button1_Click(object sender, EventArgs e)
        {
            //string Text = await webVisor.ExecuteScriptAsync("document.getElementsByTagName('body')[0].innerHTML;");
            //MessageBox.Show(Text);
            //await webVisor2.ExecuteScriptAsync("document.getElementsByTagName('body')[0].setAttribute('contenteditable', true);");
        }

        private async void tool_savePage_Click(object sender, EventArgs e)
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

                        foreach (var page in itemStructure)
                        {
                            if (page.id == activeItemId)
                            {
                                string path = Path.Combine(openedBook.directory, page.path, page.name + ".html");
                                File.WriteAllText(path, result);
                                break;
                            }
                        }
                    }
                }


            }
        }

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

        public void UpdateTree(List<Contents> collection)
        {
            if (collection.Count > 0)
            {
                //TreeNodeCollection tnk = treeview_docStr.Nodes;
                //tnk.Clear();
                treeview_docStr.BeginUpdate();
                int lastlevel = 0;
                int lastCounter = 0;

                Contents item = Library.collection[Library.idCollection.Count - 1];
                TreeNode tren = new TreeNode(item.Name);
                tren.Tag = item.Id;
                treeview_docStr.Nodes.Add(tren);

                //foreach (var item in collection)
                //{
                //    TreeNode tren = new TreeNode(item.Name);
                //    tren.Tag = item.Id;
                //    treeview_docStr.Nodes.Add(tren);

                //}
                treeview_docStr.EndUpdate();
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
                            its.order = this.itemStructure.Count;
                            its.path = this.activeDirectory;
                            its.level = this.activeLevel;
                            its.type = 2;
                            its.name = this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.');
                            its.id = ID.Generate(32);
                            its.tabIndex = -1;
                            this.itemStructure.Add(its);

                            this.openedBook.folderCount++;
                            this.SaveBookManifest();
                            this.SaveBookStruture();

                            this.AddItemInTreeView(its);
                        
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
                            its.order = this.itemStructure.Count;
                            its.path = this.activeDirectory;
                            its.level = this.activeLevel;
                            its.type = 1;
                            its.name = this.textBox_itemEditName.Text.Trim().TrimStart('.').TrimEnd('.');
                            its.id = ID.Generate(32);
                            its.tabIndex = -1;
                            this.itemStructure.Add(its);

                            this.openedBook.pageCount++;
                            this.SaveBookManifest();
                            this.SaveBookStruture();

                            this.AddItemInTreeView(its);
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
            string structure = BooksFilesUtils.BuildBookStructure(this.itemStructure);
            File.WriteAllText(this.openedBook.structPath, structure);
        }

        private void AddItemInTreeView(ItemStructure item)
        {
            treeview_docStr.BeginUpdate();

                int lastlevel = 0;
                int lastCounter = 0;

            //Contents item = Library.collection[Library.idCollection.Count - 1];
            TreeNode tren = new TreeNode("New");
            if (item.type == 1)
            {
                string marger = string.Empty;
                for (int i = 0; i < item.level; i++)
                {
                    marger += "- ";
                }
                tren = new TreeNode(marger + item.name);

            }
            else
            {
                string marger = string.Empty;
                for (int i = 0; i < item.level; i++)
                {
                    marger += "/ ";
                }
                tren = new TreeNode("/ " + marger + item.name);
            }
                tren.Tag = item.id;
                treeview_docStr.Nodes.Add(tren);

            treeview_docStr.EndUpdate();
        }
    }
}

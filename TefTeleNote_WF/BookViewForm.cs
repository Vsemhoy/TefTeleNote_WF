using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private TabPage selectedTab = new TabPage();
        private int mouseX;
        public List<ItemStructure> itemStructure;
        public List<Page> openedPageList;
        public string activeItemId = string.Empty;
        private int tabViewPadding = 6;
        private int tabViewTopOffset = 28;
        private BookFile thisBook;

        public string root;

        public int tabHeight;
        public int tabWidth;


        private TreeNode _selectedNode;

        public BookViewForm(BookFile bf)
        {
            InitializeComponent();
            this.openedPageList = new List<Page>();

            this.tabHeight = this.tabControl_browser.Height;
            this.tabWidth = this.tabControl_browser.Width;

            tabControl_browser.MouseDown += tabControl_browser_MouseDown;
            tabControl_browser.MouseUp += tabControl_browser_MouseUp;
            tabControl_browser.MouseDoubleClick += TabControl_browser_MouseDoubleClick;
            //this.tabControl_browser.ItemSize = new Size(200, 40);
            thisBook = bf;
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

            this.Resize += BookViewForm_Resize;
        }

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
            this.tabControl_browser.Height = this.Height - this.tabControl_browser.Top;
            this.tabControl_browser.Width = this.Width - this.tabControl_browser.Left;

            this.panel_bookNavigation.Height = this.Height - this.panel_bookNavigation.Top;

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
                        string resultHtml = HtmlTemplates.HtmlBuildHtmlPage(this.thisBook, item, context, "", true);
                        File.WriteAllText(filePath, resultHtml);
                        //wv.CoreWebView2.NavigateToString(content);
                        Uri uri = new Uri(filePath);
                        // wv.CoreWebView2.Navigate("file:///" + Path.Combine(root, item.path, item.name + ".html"));
                        wv.Source = (uri);
                        tp.Controls.Add(wv);
                        tabControl_browser.Controls.Add(tp);
                        this.tabControl_browser.SelectedIndex = openedPageList.Count - 1;
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
                                string path = Path.Combine(thisBook.directory, page.path, page.name + ".html");
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
    }
}

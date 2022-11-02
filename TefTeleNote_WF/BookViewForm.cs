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
        public string activeItemId = string.Empty;
        private int tabViewPadding = 6;
        private BookFile thisBook;

        private TreeNode _selectedNode;

        public BookViewForm(BookFile bf)
        {
            InitializeComponent();

            tabControl_browser.MouseDown += tabControl_browser_MouseDown;
            tabControl_browser.MouseUp += tabControl_browser_MouseUp;
            //this.tabControl_browser.ItemSize = new Size(200, 40);
            thisBook = bf;
            var root = bf.directory;
            itemStructure = BooksFilesUtils.LoadBookStructure(new DirectoryInfo(root));

            tabControl_browser.TabPages.Clear();
            int activeTabs = 0;

            foreach (var item in itemStructure)
            {
                if (item.tabIndex != -1)
                {
                    TabPage tp = new TabPage();
                    tp.Name = item.id;
                    tp.Tag = item.id;
                    tp.Text = item.name;

                    WebView2 wv = new WebView2();
                    //CoreWebView2 cww2 = new CoreWebView2("http://jfkasdj.kk");
                    //wv.CoreWebView2.
                    wv.Height = tabControl_browser.Height - 28;
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
            for (int i = 0; i < 65; i++)
            {
                await FillGeneratedCollection(i);
                //if (i % 10 == 0)
                //{
                //    UpdateTree(collection);
                //}
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

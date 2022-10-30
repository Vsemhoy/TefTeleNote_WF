using System.Data;
using TefTeleNote_WF.Controllers;
using TefTeleNote_WF.Data;
using TefTeleNote_WF.Generators;
using TefTeleNote_WF.Operators;
using TefTeleNote_WF.Transfer;

namespace TefTeleNote_WF
{
    public partial class MainForm : Form
    {
        

        HeaderReader hdr = null;
        string activeSheet = "";
        public MainForm()
        {
            InitializeComponent();
            //treeview_docStr.BeginUpdate();
            //treeview_docStr.Nodes.Add("Parent");
            //treeview_docStr.Nodes[0].Nodes.Add("Child 1");
            //treeview_docStr.Nodes[0].Nodes.Add("Child 2");
            //treeview_docStr.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            //treeview_docStr.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            //treeview_docStr.Nodes.Add("Parent");
            //treeview_docStr.Nodes[1].Nodes.Add("Child 1");
            //treeview_docStr.Nodes[1].Nodes.Add("Child 2");
            //treeview_docStr.Nodes[1].Nodes[1].Nodes.Add("Grandchild");
            //treeview_docStr.Nodes[1].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            //treeview_docStr.EndUpdate();

            textbox_main.Text = Generators.RandomText.generateRandomString(1200);
            treeview_docStr.NodeMouseClick += Treeview_docStr_NodeMouseClick;

            textbox_main.TextChanged += Textbox_main_TextChanged;
            
            //if (UserConfig.ReadConfig())
            //{

            //}
            //else
            //{
            //    UserConfig.author = "New User";
            //    UserConfig.formWidth = this.Width;
            //    UserConfig.formHeight = this.Height;
            //    if (tab_navigation.SelectedTab == tab_books)
            //    {
            //        UserConfig.tabIndexSection = 0;
            //    } else
            //    {
            //        UserConfig.tabIndexSection = 1;
            //    }

            //    FolderBrowserDialog fbd = new FolderBrowserDialog();
            //    fbd.UseDescriptionForTitle = true;
            //    fbd.Description = "Choose default folder with books to autoload";
            //    if (fbd.ShowDialog() == DialogResult.OK)
            //    {
            //        UserConfig.directoryFiles = fbd.SelectedPath;
            //        //MessageBox.Show(UserConfig.directoryFiles);
            //        UserConfig.WriteConfig();
            //    }
            //}
        }


        

        private void Textbox_main_TextChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(activeSheet))
            {
                int index = 0;
                int counter = 0;
                foreach (string st in Library.idCollection)
                {
                    if (st == activeSheet)
                    {
                        index = counter;
                    }
                    counter++;
                }

                Library.collection[index].Data = textbox_main.Text;
            }
        }

        private void Treeview_docStr_NodeMouseClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            var id = e.Node.Tag as string;
            Contents cont = null;
            if (!string.IsNullOrEmpty(id))
            {
                foreach (Contents cc in Library.collection)
                {
                    if (cc.Id == id)
                    {
                        cont = cc;
                        break;
                    }
                }
                if (cont != null)
                {
                    activeSheet = id;
                    textbox_main.Text = cont.Data.ToString();
                }
            }
        }



        private async  void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 255; i++)
            {
                await FillGeneratedCollection(i);
                //if (i % 10 == 0)
                //{
                //    UpdateTree(collection);
                //}
            }
            //UpdateTree(collection);
            
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
            drow.Data = drow.Name + "\r\n" +  RandomText.generateRandomString(random.Next(100,11200));
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

        private void saveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteBook wb = new WriteBook(Library.collection, HeaderReader.GetFHeaderString(), "", "");
            wb.WriteFile();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string bookName = "Book.teff";
            int index  = 0;
            Library.collection.Clear();
            foreach (string line in System.IO.File.ReadLines(path + Path.DirectorySeparatorChar + bookName))
            {
                if (index == 0)
                {
                    hdr = new HeaderReader(line);
                } else
                {
                    Library.collection.Add(new Contents(line, hdr));

                }
                index++;
            }

            UpdateTree(Library.collection);
        }

        private void toolStripButton2_CreateNew(object sender, EventArgs e)
        {
            datagrid_books.Rows.Add((object) 1, (object)"New Book...");
        }
    }
}
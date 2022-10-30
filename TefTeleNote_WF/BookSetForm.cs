using Diga.Core.Api.Win32.Com;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TefTeleNote_WF.Data;
using TefTeleNote_WF.Templates;
using TefTeleNote_WF.Transfer;

namespace TefTeleNote_WF
{
    public partial class BookSetForm : Form
    {
        bool editMode;
        string selectedIcon;
        string selectdCover;
        string selectdSuper;

        public BookSetForm(bool isEdit = false)
        {
            InitializeComponent();
            this.editMode = isEdit;

            this.combox_language.Items.Clear();
            int lanIndex = 0;
            int counter = 0;
            foreach(var lan in Language.languageList)
            {
                combox_language.Items.Add(lan.nativeName);
                if (UserConfig.languageCode == lan.code)
                {
                    lanIndex = counter;
                }
                counter++;
            }
            if (combox_language.Items.Count > 0)
            {
                combox_language.SelectedIndex = lanIndex;
            }
        }

        private void BookSetForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_selectIcon_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                if (this.editMode == false)
                {
                    ofd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                    ofd.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
                    ofd.FilterIndex = 0;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFileName = ofd.FileName;
                        //...
                        this.pictureBox_icon.Image = Image.FromFile(selectedFileName);
                        this.selectedIcon = ofd.FileName;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_selectCover_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                if (this.editMode == false)
                {
                    ofd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                    ofd.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
                    ofd.FilterIndex = 0;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFileName = ofd.FileName;
                        this.pictureBox_cover.Image = Image.FromFile(selectedFileName);
                        this.selectdCover = ofd.FileName;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_selecSuperCover_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                if (this.editMode == false)
                {
                    ofd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                    ofd.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
                    ofd.FilterIndex = 0;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFileName = ofd.FileName;
                        this.pictureBox_super.Image = Image.FromFile(selectedFileName);
                        this.selectdSuper = ofd.FileName;
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_createBook_Click(object sender, EventArgs e)
        {

            BookFile bf = new BookFile();
            HtmlTemplates htmp = new HtmlTemplates("Russian");
            bf.titleName = this.texbox_title.Text.Trim();
            bf.description = this.textbox_description.Text.Trim();
            bf.author = UserConfig.userName;
            bf.categoryName = this.combox_categories.Text.Trim();
            bf.meta_descr = this.textBox_metaDescription.Text.Trim();
            bf.meta_keys = this.textBox_metaKeywords.Text.Trim();
            bf.meta_title = this.textBox_metaTitle.Text.Trim();


            string style = SanitizeStyle( this.textbox_css.Text);
            if (bf.titleName.Length < 3)
            {
                MessageBox.Show("Name is too short");
            }
            // Try to create folder
            try
            {
                var newDir = Path.Combine(UserConfig.folderShelf, bf.titleName);
                bool exists = Directory.Exists(newDir);

                if (!exists)
                {
                    Directory.CreateDirectory(newDir);
                    UserConfig.OpenFileSequrity(newDir);
                }
                else
                {
                    MessageBox.Show("Directory also exists!");
                    return;
                }
                // Okay, try to create assets folder and create new files
                Directory.CreateDirectory(Path.Combine(newDir, BookFile.fileFolderName));
                UserConfig.OpenFileSequrity(Path.Combine(newDir, BookFile.fileFolderName));

                var blankFile = Path.Combine(newDir, BookFile.defaultFileName);
                File.WriteAllText(blankFile, htmp.GetBlankContent());

                var assdir = Path.Combine(newDir, ".assets");
                Directory.CreateDirectory(assdir);
                UserConfig.OpenFileSequrity(assdir);

                // Transfer image files
                if (!string.IsNullOrEmpty(selectedIcon))
                {
                    string name = Path.GetFileName(selectedIcon);
                    string ext = name.Split('.')[name.Split('.').Length - 1];
                    string newName = BookFile.iconname + "." + ext;
                    newName = Path.Combine(assdir, newName);
                    System.IO.File.Copy(selectedIcon, newName, true);
                    selectedIcon = newName;
                }
                if (!string.IsNullOrEmpty(selectdCover))
                {
                    string name = Path.GetFileName(selectdCover);
                    string ext = name.Split('.')[name.Split('.').Length - 1];
                    string newName = BookFile.covername + "." + ext;
                    newName = Path.Combine(assdir, newName);
                    System.IO.File.Copy(selectdCover, newName, true);
                    selectdCover = newName;
                }
                if (!string.IsNullOrEmpty(selectdSuper))
                {
                    string name = Path.GetFileName(selectdSuper);
                    string ext = name.Split('.')[name.Split('.').Length - 1];
                    string newName = BookFile.supercovername + "." + ext;
                    newName = Path.Combine(assdir, newName);
                    System.IO.File.Copy(selectdSuper, newName, true);
                    selectdSuper = newName;
                }

                bf.iconPath = selectedIcon;
                bf.coverPath = selectdCover;
                bf.superCoverPath = selectdSuper;


                var styleFile = Path.Combine(assdir, BookFile.stylename);
                File.WriteAllText(styleFile, style);
                bf.stylePath = styleFile;

                var templateFile = Path.Combine(assdir, BookFile.templatename);
                File.WriteAllText(templateFile, htmp.GetHtmlTemplate());
                bf.templatPath = templateFile;

                var manifestFile = Path.Combine(assdir, BookFile.manifestname);
                bf.manifestPath = manifestFile;
                File.WriteAllText(manifestFile, BooksFilesUtils.BuildBookManifest(bf));





                //File.WriteAllText(configPath, string.Empty);
                //File.WriteAllText(configPath, result);
                //return true;
            }
            catch (Exception eex)
            {
                MessageBox.Show("Cannot create directory with that name", eex.Message);
            }



            bf.description = this.textbox_description.Text;
            bf.author = UserConfig.userName;
            
        }


        public static string SanitizeStyle(string style)
        {
            style = style.Replace("<style>", "");
            style = style.Replace("</style>", "");
            style = style.Replace("body", ".mainBody");
            style = style.Replace("<", "");
            style = style.Replace(">", "");
            style = style.Replace("/", "");
            style = style.Replace("\\", "");

            style = style.Replace("#bookerContent ", "");
            style = style.Trim();


            int countOpen = 0;
            int countClose = 0;
            string final = string.Empty;
            foreach (char c in style)
            {
                if (c == '{')
                {
                    countOpen++;
                }

                if (c == '}')
                {
                    countClose++;
                }
                final += c;
            }
            if (countOpen > countClose)
            {
                for (int i = 0; i < countOpen - countClose; i++)
                {
                    final += "\n}";
                }
            }
            if (countOpen > 0)
            {
                final = "#bookerContent " + final;
            }
            final = final.Replace("}\r\n", "}\n#bookerContent ");
            final = final.Replace("} \r\n", "}\n#bookerContent ");
            final = final.Replace("}  \r\n", "}\n#bookerContent ");
            return final;
        }
    }
}

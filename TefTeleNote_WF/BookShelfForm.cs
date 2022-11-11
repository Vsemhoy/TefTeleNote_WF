using Diga.WebView2.Wrapper.EventArguments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TefTeleNote_WF.Data;
using TefTeleNote_WF.Transfer;

namespace TefTeleNote_WF
{
    public partial class BookShelfForm : Form
    {
        public Color col;
        private int itemWidth;
        private int itemHeight;
        private int itemPadding;
        private int scrollWidth;
        private int cardPadding;
        private int cardInfoSectionWidth;

        private Color editedItemColor = Color.CornflowerBlue;
        private Color editedItemForeColor = Color.White;

        public List<BookViewForm> viewCollection;
        public BookShelfForm()
        {
            InitializeComponent();
           //panel2.MouseHover += Panel2_MouseHover;
            //panel2.MouseLeave += Panel2_MouseLeave;
            panel_bookList.MouseEnter += Panel2_MouseLeave;
            panel_bookList.DragDrop += Panel_bookList_DragDrop;
            this.col = Color.LightGray;

            this.cardPadding = 3;
            this.scrollWidth = 34;
            this.itemPadding = 1;
            this.itemHeight = 62;
            this.itemWidth = this.panel_bookList.Width - this.itemPadding * 2 - this.scrollWidth;
            this.cardInfoSectionWidth = 140;

            ReloadBookListInRows();

            this.viewCollection = new List<BookViewForm>();
        }

        private void Panel_bookList_DragDrop(object? sender, DragEventArgs e)
        {
            
        }

        private void Panel2_MouseLeave(object? sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.None;
            if (panel2.BackColor != this.editedItemColor)
            {
                panel2.BackColor = col;
            }
        }

        private void Panel2_MouseHover(object? sender, EventArgs e)
        {
            if (panel2.BackColor != this.editedItemColor)
            {
                panel2.BorderStyle = BorderStyle.FixedSingle;
                panel2.BackColor = Color.White;

            }
            if (!string.IsNullOrEmpty((string)panel2.Tag))
            {
                this.FillSidebarInfoById((string)panel2.Tag);
            }
        }

        private void FillSidebarInfoById(string id)
        {
            // Load data
            BookFile bkf = BooksFilesUtils.GetBookById(id);
            int totalHeight = 0;
            if (bkf != null)
            {
                this.panel_bookDescription.Controls.Clear();
                var width = this.panel_bookDescription.Width;

                if (!string.IsNullOrEmpty(bkf.coverPath))
                {
                    if (File.Exists(bkf.coverPath))
                    {
                        Image img = Image.FromFile(bkf.coverPath);
                        var imW = img.Width;
                        var imH = img.Height;

                        double rat = (double)imH / (double)imW;

                        PictureBox cover = new PictureBox();
                        cover.ImageLocation = bkf.coverPath;
                        cover.Width = width;
                        cover.Height = Convert.ToInt32( width * rat );
                        cover.SizeMode = PictureBoxSizeMode.Zoom;
                        totalHeight += cover.Height;

                        this.panel_bookDescription.Controls.Add(cover);
                    }
                }

                if (!string.IsNullOrEmpty(bkf.titleName))
                {
                    Label title = new Label();
                    title.Text = bkf.titleName;
                    title.Location = new Point(this.itemPadding* 6, totalHeight + this.itemPadding * 6);
                    title.Height = 40;
                    title.Font = new Font("Serif", 14);
                    title.Width = width - this.itemPadding * 6;
                    totalHeight += this.itemPadding * 6 + 40;
                    this.panel_bookDescription.Controls.Add(title);
                }

                if (!string.IsNullOrEmpty(bkf.description))
                {
                    Label descr = new Label();
                    descr.Text = bkf.description;
                    descr.Location = new Point(this.itemPadding * 6, totalHeight + this.itemPadding * 6);
                    descr.Height = 300;
                    //descr.Font = new Font("Serif", 14);
                    descr.Width = width - this.itemPadding * 6;
                    this.panel_bookDescription.Controls.Add(descr);
                }
            }
        }

        private void MouseHoverItemRow(object? sender, EventArgs e)
        {
            ResetMouseHoverInRow();
            Panel pan = sender as Panel;
            pan.BorderStyle = BorderStyle.FixedSingle;
            if (pan.BackColor != this.editedItemColor)
            {
                pan.BackColor = Color.White;

            }
            if (!string.IsNullOrEmpty((string)pan.Tag))
            {
                this.FillSidebarInfoById((string)pan.Tag);
            }
        }

        private void ResetMouseHoverInRow()
        {
            var panels = this.panel_bookList.Controls;
            foreach (Panel book in panels)
            {
                if (book.GetType() == typeof(Panel))
                {

                    book.BorderStyle = BorderStyle.FixedSingle;
                    if (book.BackColor != this.editedItemColor)
                    {

                        book.BackColor = col;
                    }
                }
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }


        public void ReloadBookListInRows()
        {
            int nextPositionY = 0;
            this.panel_bookList.Controls.Clear();
            
            foreach (var item in Library.fileCollection)
            {
                nextPositionY += this.itemPadding;
                int picOffset = 0;
                Panel panel = new Panel();
                panel.Name = item.id;
                panel.Tag = item.id;
                panel.Height = this.itemHeight;
                panel.Width = this.itemWidth;
                panel.Location = new Point(this.itemPadding, nextPositionY);
                panel.BackColor = this.col;
                nextPositionY += this.itemPadding + this.itemHeight;

                panel.MouseEnter += this.MouseHoverItemRow;
                

                //if (!string.IsNullOrEmpty(item.coverPath))
                //{
                //    int pixPad = this.cardPadding;
                //    PictureBox pictureBox = new PictureBox();
                //    pictureBox.ImageLocation = item.coverPath;
                //    pictureBox.Name = "pix_" + item.id;
                //    pictureBox.Width = this.itemHeight - pixPad * 2;
                //    pictureBox.Height = this.itemHeight - pixPad * 2;
                //    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                //    pictureBox.Location = new Point(pixPad, pixPad);
                //    picOffset = this.itemHeight;
                //    panel.Controls.Add(pictureBox);
                //}

                Label name  = new Label();
                name.Text = item.titleName;
                name.AutoSize = false;
                name.Font = new Font("Serif", 12);
                name.Width = this.itemWidth - this.cardInfoSectionWidth - this.cardPadding * 2;
                name.Location = new Point(8, 8);
                name.Height = this.itemHeight - cardPadding * 4;
                name.Cursor = Cursors.Hand;
                name.Click += Name_Click;
                name.DoubleClick += Name_DoubleClick;
                name.Tag = item.id;
                panel.Controls.Add(name);

                Label dateupd = new Label();
                dateupd.Text = item.updated.ToString();
                dateupd.Name = "date_" + item.id;
                dateupd.AutoSize = true;
                //descr.Font = new Font("Serif", 12);
                dateupd.Location = new Point(this.itemWidth - this.cardInfoSectionWidth + this.cardPadding, 10);
                panel.Controls.Add(dateupd);

                Label category = new Label();
                category.Text = item.updated.ToString();
                category.AutoSize = true;
                //descr.Font = new Font("Serif", 12);
                category.Location = new Point(this.itemWidth - this.cardInfoSectionWidth + this.cardPadding, 35);
                panel.Controls.Add(dateupd);

                this.panel_bookList.Controls.Add(panel);
            }

        }

        private void Name_DoubleClick(object? sender, EventArgs e)
        {
            Label lab = sender as Label;
            if (lab != null)
            {
                string id = lab.Tag.ToString();

                BookFile bf = BooksFilesUtils.GetBookById(id);
                

            }
            
        }

        private void View_FormClosed(object? sender, FormClosedEventArgs e)
        {
            BookViewForm bf = (BookViewForm)sender;
            if (bf != null)
            {
                var id = bf.Tag.ToString();
                this.UpdateCardOnClosed(id);
            }
        }

        private void UpdateCardOnClosed(string id)
        {
            BookFile bf = BooksFilesUtils.GetBookById(id);
            bf.status = 0;
            foreach (BookViewForm bvf in this.viewCollection)
            {
                if (bvf.Tag == (object)id)
                {
                    this.viewCollection.Remove(bvf);
                    break;
                }
            }
            foreach (Panel pan in this.panel_bookList.Controls)
            {
                if (pan.Tag == id)
                {
                    pan.BackColor = this.col;
                    pan.ForeColor = Color.Black;

                    foreach (Control control in pan.Controls)
                    {
                        if (control.Name == "date_" + id)
                        {
                            control.Text = bf.updated.ToString();
                        }
                        break;
                    }
                    break;
                }
            }
        }

        private void Name_Click(object? sender, EventArgs e)
        {
            Label lab = sender as Label;
            if (lab != null)
            {
                string id = lab.Tag.ToString();

                BookFile bf = BooksFilesUtils.GetBookById(id);

                if (bf.status > 0)
                {
                    foreach (BookViewForm bvf in this.viewCollection)
                    {
                        if (bvf.Tag == id)
                        {
                            bvf.Visible = false;
                            bvf.Visible = true;
                            bvf.WindowState = FormWindowState.Normal;
                            return;
                        }
                    }
                }

                bf.status = 2;
                var view = new BookViewForm(bf);
                view.Text = bf.titleName;
                view.Tag = id;
                view.Visible = true;
                view.WindowState = FormWindowState.Normal;
                view.FormClosed += View_FormClosed;
                this.viewCollection.Add(view);

                foreach (Panel pan in this.panel_bookList.Controls)
                {
                    if (pan != null)
                    {
                        if (pan.Tag == id)
                        {
                            pan.BackColor = this.editedItemColor;
                            pan.ForeColor = this.editedItemForeColor;
                            break;
                        }
                    }
                }
            }
        }

        private void btn_newBook_Click(object sender, EventArgs e)
        {
            //ReloadBookListInRows();

        }

        private void createBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form setform = new BookSetForm();
            setform.ShowDialog();
            BooksFilesUtils.LoadBooks();
            this.ReloadBookListInRows();
        }

        private void importBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void panel_bookList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

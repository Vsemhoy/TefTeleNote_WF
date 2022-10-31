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

        public BookShelfForm()
        {
            InitializeComponent();
           //panel2.MouseHover += Panel2_MouseHover;
            //panel2.MouseLeave += Panel2_MouseLeave;
            panel2.MouseEnter += Panel2_MouseHover;
            panel_bookList.MouseEnter += Panel2_MouseLeave;
            panel_bookList.DragDrop += Panel_bookList_DragDrop;
            this.col = Color.LightGray;

            this.cardPadding = 3;
            this.scrollWidth = 34;
            this.itemPadding = 1;
            this.itemHeight = 100;
            this.itemWidth = this.Width - this.itemPadding * 2 - this.scrollWidth;

            ReloadBookListInRows();
        }

        private void Panel_bookList_DragDrop(object? sender, DragEventArgs e)
        {
            
        }

        private void Panel2_MouseLeave(object? sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.None;
            panel2.BackColor = col;
        }

        private void Panel2_MouseHover(object? sender, EventArgs e)
        {
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.BackColor = Color.White;
        }

        private void MouseHoverItemRow(object? sender, EventArgs e)
        {
            ResetMouseHoverInRow();
            Panel pan = sender as Panel;
            pan.BorderStyle = BorderStyle.FixedSingle;
            pan.BackColor = Color.White;
        }

        private void ResetMouseHoverInRow()
        {
            var panels = this.panel_bookList.Controls;
            foreach (Panel book in panels)
            {
                if (book.GetType() == typeof(Panel))
                {

                    book.BorderStyle = BorderStyle.FixedSingle;
                    book.BackColor = col;
                }
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Form settings = new SettingsForm();
            settings.ShowDialog();
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
                panel.Height = this.itemHeight;
                panel.Width = this.itemWidth;
                panel.Location = new Point(this.itemPadding, nextPositionY);
                panel.BackColor = this.col;
                nextPositionY += this.itemPadding + this.itemHeight;

                panel.MouseEnter += this.MouseHoverItemRow;
                

                if (!string.IsNullOrEmpty(item.coverPath))
                {
                    int pixPad = this.cardPadding;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = item.coverPath;
                    pictureBox.Name = "pix_" + item.id;
                    pictureBox.Width = this.itemHeight - pixPad * 2;
                    pictureBox.Height = this.itemHeight - pixPad * 2;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Location = new Point(pixPad, pixPad);
                    picOffset = this.itemHeight;
                    panel.Controls.Add(pictureBox);
                }

                Label name  = new Label();
                name.Text = item.titleName;
                name.AutoSize = false;
                name.Font = new Font("Serif", 12);
                name.Width = this.itemWidth - picOffset - this.cardPadding * 10;
                name.Location = new Point(picOffset + this.cardPadding * 5, this.cardPadding * 2);
                name.Height = this.itemHeight / 5;
                name.Cursor = Cursors.Hand;
                name.Click += Name_Click;
                name.Tag = item.id;
                panel.Controls.Add(name);

                Label descr = new Label();
                descr.Text = item.description;
                descr.AutoSize = false;
                //descr.Font = new Font("Serif", 12);
                descr.Width = this.itemWidth - picOffset - this.cardPadding * 10;
                descr.Location = new Point(picOffset + this.cardPadding * 5, this.cardPadding * 2 + this.itemHeight / 4);
                descr.Height = this.itemHeight - this.itemHeight / 4;
                panel.Controls.Add(descr);

                this.panel_bookList.Controls.Add(panel);
            }

        }

        private void Name_Click(object? sender, EventArgs e)
        {
            Label lab = sender as Label;
            if (lab != null)
            {
                string id = lab.Tag.ToString();

                BookFile bf = BooksFilesUtils.GetBookById(id);

                var view = new BookViewForm(bf);
                view.Text = bf.titleName;
                view.Visible = true;
                view.WindowState = FormWindowState.Normal;

            }
        }

        private void btn_newBook_Click(object sender, EventArgs e)
        {
            //ReloadBookListInRows();
            Form setform = new BookSetForm();
            setform.ShowDialog();
        }
    }
}

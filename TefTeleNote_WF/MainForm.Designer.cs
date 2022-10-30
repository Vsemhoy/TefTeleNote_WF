namespace TefTeleNote_WF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.treeview_docStr = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topOfDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomOfDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBookAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tab_navigation = new System.Windows.Forms.TabControl();
            this.tab_books = new System.Windows.Forms.TabPage();
            this.datagrid_books = new System.Windows.Forms.DataGridView();
            this.tab_structure = new System.Windows.Forms.TabPage();
            this.lbl_bookname_tabhead = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.render_panel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textbox_main = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_createNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tab_navigation.SuspendLayout();
            this.tab_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_books)).BeginInit();
            this.tab_structure.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(686, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // treeview_docStr
            // 
            this.treeview_docStr.AllowDrop = true;
            this.treeview_docStr.Location = new System.Drawing.Point(0, 24);
            this.treeview_docStr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeview_docStr.Name = "treeview_docStr";
            this.treeview_docStr.ShowNodeToolTips = true;
            this.treeview_docStr.Size = new System.Drawing.Size(223, 344);
            this.treeview_docStr.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.forkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgeToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // pgeToolStripMenuItem
            // 
            this.pgeToolStripMenuItem.Name = "pgeToolStripMenuItem";
            this.pgeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pgeToolStripMenuItem.Text = "Pge";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uPToolStripMenuItem,
            this.downToolStripMenuItem,
            this.topOfDocumentToolStripMenuItem,
            this.bottomOfDocumentToolStripMenuItem});
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // uPToolStripMenuItem
            // 
            this.uPToolStripMenuItem.Name = "uPToolStripMenuItem";
            this.uPToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.uPToolStripMenuItem.Text = "UP";
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.downToolStripMenuItem.Text = "Down";
            // 
            // topOfDocumentToolStripMenuItem
            // 
            this.topOfDocumentToolStripMenuItem.Name = "topOfDocumentToolStripMenuItem";
            this.topOfDocumentToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.topOfDocumentToolStripMenuItem.Text = "Top of Document";
            // 
            // bottomOfDocumentToolStripMenuItem
            // 
            this.bottomOfDocumentToolStripMenuItem.Name = "bottomOfDocumentToolStripMenuItem";
            this.bottomOfDocumentToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.bottomOfDocumentToolStripMenuItem.Text = "Bottom of Document";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // forkToolStripMenuItem
            // 
            this.forkToolStripMenuItem.Name = "forkToolStripMenuItem";
            this.forkToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.forkToolStripMenuItem.Text = "Fork";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.saveBookToolStripMenuItem,
            this.saveBookAsToolStripMenuItem,
            this.closeBookToolStripMenuItem,
            this.saveAndCloseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // saveBookToolStripMenuItem
            // 
            this.saveBookToolStripMenuItem.Name = "saveBookToolStripMenuItem";
            this.saveBookToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveBookToolStripMenuItem.Text = "Save Book";
            this.saveBookToolStripMenuItem.Click += new System.EventHandler(this.saveBookToolStripMenuItem_Click);
            // 
            // saveBookAsToolStripMenuItem
            // 
            this.saveBookAsToolStripMenuItem.Name = "saveBookAsToolStripMenuItem";
            this.saveBookAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveBookAsToolStripMenuItem.Text = "Save Book As";
            // 
            // closeBookToolStripMenuItem
            // 
            this.closeBookToolStripMenuItem.Name = "closeBookToolStripMenuItem";
            this.closeBookToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closeBookToolStripMenuItem.Text = "Close Book";
            // 
            // saveAndCloseToolStripMenuItem
            // 
            this.saveAndCloseToolStripMenuItem.Name = "saveAndCloseToolStripMenuItem";
            this.saveAndCloseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveAndCloseToolStripMenuItem.Text = "Save and Close";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tab_navigation
            // 
            this.tab_navigation.Controls.Add(this.tab_books);
            this.tab_navigation.Controls.Add(this.tab_structure);
            this.tab_navigation.Location = new System.Drawing.Point(0, 51);
            this.tab_navigation.Margin = new System.Windows.Forms.Padding(2);
            this.tab_navigation.Name = "tab_navigation";
            this.tab_navigation.SelectedIndex = 0;
            this.tab_navigation.Size = new System.Drawing.Size(233, 404);
            this.tab_navigation.TabIndex = 4;
            // 
            // tab_books
            // 
            this.tab_books.Controls.Add(this.datagrid_books);
            this.tab_books.Location = new System.Drawing.Point(4, 24);
            this.tab_books.Margin = new System.Windows.Forms.Padding(2);
            this.tab_books.Name = "tab_books";
            this.tab_books.Padding = new System.Windows.Forms.Padding(2);
            this.tab_books.Size = new System.Drawing.Size(225, 376);
            this.tab_books.TabIndex = 0;
            this.tab_books.Text = "Books";
            this.tab_books.UseVisualStyleBackColor = true;
            // 
            // datagrid_books
            // 
            this.datagrid_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_books.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_text});
            this.datagrid_books.Location = new System.Drawing.Point(0, 22);
            this.datagrid_books.Margin = new System.Windows.Forms.Padding(2);
            this.datagrid_books.Name = "datagrid_books";
            this.datagrid_books.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagrid_books.RowTemplate.Height = 37;
            this.datagrid_books.Size = new System.Drawing.Size(221, 390);
            this.datagrid_books.TabIndex = 0;
            // 
            // tab_structure
            // 
            this.tab_structure.Controls.Add(this.lbl_bookname_tabhead);
            this.tab_structure.Controls.Add(this.treeview_docStr);
            this.tab_structure.Location = new System.Drawing.Point(4, 24);
            this.tab_structure.Margin = new System.Windows.Forms.Padding(2);
            this.tab_structure.Name = "tab_structure";
            this.tab_structure.Padding = new System.Windows.Forms.Padding(2);
            this.tab_structure.Size = new System.Drawing.Size(225, 376);
            this.tab_structure.TabIndex = 1;
            this.tab_structure.Text = "Structure";
            this.tab_structure.UseVisualStyleBackColor = true;
            // 
            // lbl_bookname_tabhead
            // 
            this.lbl_bookname_tabhead.Location = new System.Drawing.Point(2, 6);
            this.lbl_bookname_tabhead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bookname_tabhead.Name = "lbl_bookname_tabhead";
            this.lbl_bookname_tabhead.Size = new System.Drawing.Size(223, 15);
            this.lbl_bookname_tabhead.TabIndex = 1;
            this.lbl_bookname_tabhead.Text = "Book Name";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(235, 51);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(451, 402);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.render_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(443, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // render_panel
            // 
            this.render_panel.Location = new System.Drawing.Point(4, 22);
            this.render_panel.Margin = new System.Windows.Forms.Padding(2);
            this.render_panel.Name = "render_panel";
            this.render_panel.Size = new System.Drawing.Size(423, 420);
            this.render_panel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textbox_main);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(443, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textbox_main
            // 
            this.textbox_main.Location = new System.Drawing.Point(0, 22);
            this.textbox_main.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_main.MaxLength = 932767;
            this.textbox_main.Multiline = true;
            this.textbox_main.Name = "textbox_main";
            this.textbox_main.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textbox_main.Size = new System.Drawing.Size(448, 390);
            this.textbox_main.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton_createNew,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(686, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Open Book";
            // 
            // toolStripButton_createNew
            // 
            this.toolStripButton_createNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_createNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_createNew.Image")));
            this.toolStripButton_createNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_createNew.Name = "toolStripButton_createNew";
            this.toolStripButton_createNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_createNew.Text = "Create Book";
            this.toolStripButton_createNew.Click += new System.EventHandler(this.toolStripButton2_CreateNew);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Close Book";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Save Book";
            // 
            // col_id
            // 
            this.col_id.HeaderText = "id";
            this.col_id.Name = "col_id";
            this.col_id.Visible = false;
            // 
            // col_text
            // 
            this.col_text.HeaderText = "Book Name";
            this.col_text.Name = "col_text";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 468);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tab_navigation);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_navigation.ResumeLayout(false);
            this.tab_books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_books)).EndInit();
            this.tab_structure.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        public TreeView treeview_docStr;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem pgeToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem moveToolStripMenuItem;
        private ToolStripMenuItem uPToolStripMenuItem;
        private ToolStripMenuItem downToolStripMenuItem;
        private ToolStripMenuItem topOfDocumentToolStripMenuItem;
        private ToolStripMenuItem bottomOfDocumentToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem forkToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem saveBookToolStripMenuItem;
        private ToolStripMenuItem saveBookAsToolStripMenuItem;
        private ToolStripMenuItem closeBookToolStripMenuItem;
        private ToolStripMenuItem saveAndCloseToolStripMenuItem;
        private MenuStrip menuStrip1;
        private TabControl tab_navigation;
        private TabPage tab_books;
        private TabPage tab_structure;
        private Label lbl_bookname_tabhead;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textbox_main;
        private DataGridView datagrid_books;
        private Panel render_panel;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton_createNew;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton4;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn col_text;
    }
}
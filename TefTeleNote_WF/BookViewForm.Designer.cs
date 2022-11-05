namespace TefTeleNote_WF
{
    partial class BookViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookViewForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_openNavigationPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBookAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_savePage = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_saveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_browser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel_bookNavigation = new System.Windows.Forms.Panel();
            this.textBox_itemFilter = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_applyItem = new System.Windows.Forms.PictureBox();
            this.btn_addFolder = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_addPage = new System.Windows.Forms.PictureBox();
            this.btn_removeItem = new System.Windows.Forms.PictureBox();
            this.treeview_docStr = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.tabControl_browser.SuspendLayout();
            this.panel_bookNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_applyItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_removeItem)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_openNavigationPanel,
            this.toolStripComboBox1,
            this.fileToolStripMenuItem,
            this.tool_savePage,
            this.tool_saveBook});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 36);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_openNavigationPanel
            // 
            this.btn_openNavigationPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_openNavigationPanel.Image = ((System.Drawing.Image)(resources.GetObject("btn_openNavigationPanel.Image")));
            this.btn_openNavigationPanel.Name = "btn_openNavigationPanel";
            this.btn_openNavigationPanel.Size = new System.Drawing.Size(32, 32);
            this.btn_openNavigationPanel.Text = "toolStripMenuItem1";
            this.btn_openNavigationPanel.Click += new System.EventHandler(this.btn_openNavigationPanel_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 32);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AutoSize = false;
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.saveBookToolStripMenuItem,
            this.saveBookAsToolStripMenuItem,
            this.closeBookToolStripMenuItem,
            this.saveAndCloseToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            // 
            // saveBookToolStripMenuItem
            // 
            this.saveBookToolStripMenuItem.Name = "saveBookToolStripMenuItem";
            this.saveBookToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveBookToolStripMenuItem.Text = "Save Book";
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
            // tool_savePage
            // 
            this.tool_savePage.Name = "tool_savePage";
            this.tool_savePage.Size = new System.Drawing.Size(72, 32);
            this.tool_savePage.Text = "Save Page";
            this.tool_savePage.Click += new System.EventHandler(this.tool_savePage_Click);
            // 
            // tool_saveBook
            // 
            this.tool_saveBook.Name = "tool_saveBook";
            this.tool_saveBook.Size = new System.Drawing.Size(73, 32);
            this.tool_saveBook.Text = "Save Book";
            // 
            // tabControl_browser
            // 
            this.tabControl_browser.Controls.Add(this.tabPage1);
            this.tabControl_browser.Controls.Add(this.tabPage2);
            this.tabControl_browser.Controls.Add(this.tabPage3);
            this.tabControl_browser.Controls.Add(this.tabPage4);
            this.tabControl_browser.Location = new System.Drawing.Point(0, 60);
            this.tabControl_browser.Name = "tabControl_browser";
            this.tabControl_browser.SelectedIndex = 0;
            this.tabControl_browser.Size = new System.Drawing.Size(798, 606);
            this.tabControl_browser.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "blank";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(790, 578);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel_bookNavigation
            // 
            this.panel_bookNavigation.Controls.Add(this.textBox_itemFilter);
            this.panel_bookNavigation.Controls.Add(this.pictureBox2);
            this.panel_bookNavigation.Controls.Add(this.panel1);
            this.panel_bookNavigation.Controls.Add(this.treeview_docStr);
            this.panel_bookNavigation.Location = new System.Drawing.Point(0, 39);
            this.panel_bookNavigation.Name = "panel_bookNavigation";
            this.panel_bookNavigation.Size = new System.Drawing.Size(395, 623);
            this.panel_bookNavigation.TabIndex = 0;
            // 
            // textBox_itemFilter
            // 
            this.textBox_itemFilter.Location = new System.Drawing.Point(21, 3);
            this.textBox_itemFilter.Name = "textBox_itemFilter";
            this.textBox_itemFilter.Size = new System.Drawing.Size(298, 23);
            this.textBox_itemFilter.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(342, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_applyItem);
            this.panel1.Controls.Add(this.btn_addFolder);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_addPage);
            this.panel1.Controls.Add(this.btn_removeItem);
            this.panel1.Location = new System.Drawing.Point(0, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 33);
            this.panel1.TabIndex = 2;
            // 
            // btn_applyItem
            // 
            this.btn_applyItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_applyItem.Image = ((System.Drawing.Image)(resources.GetObject("btn_applyItem.Image")));
            this.btn_applyItem.Location = new System.Drawing.Point(289, 0);
            this.btn_applyItem.Name = "btn_applyItem";
            this.btn_applyItem.Size = new System.Drawing.Size(36, 33);
            this.btn_applyItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_applyItem.TabIndex = 5;
            this.btn_applyItem.TabStop = false;
            // 
            // btn_addFolder
            // 
            this.btn_addFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_addFolder.Image = ((System.Drawing.Image)(resources.GetObject("btn_addFolder.Image")));
            this.btn_addFolder.Location = new System.Drawing.Point(324, 0);
            this.btn_addFolder.Name = "btn_addFolder";
            this.btn_addFolder.Size = new System.Drawing.Size(36, 33);
            this.btn_addFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_addFolder.TabIndex = 4;
            this.btn_addFolder.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(38, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 16);
            this.textBox1.TabIndex = 3;
            // 
            // btn_addPage
            // 
            this.btn_addPage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_addPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_addPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addPage.Image = ((System.Drawing.Image)(resources.GetObject("btn_addPage.Image")));
            this.btn_addPage.Location = new System.Drawing.Point(359, 0);
            this.btn_addPage.Name = "btn_addPage";
            this.btn_addPage.Size = new System.Drawing.Size(36, 33);
            this.btn_addPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_addPage.TabIndex = 2;
            this.btn_addPage.TabStop = false;
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_removeItem.Image = ((System.Drawing.Image)(resources.GetObject("btn_removeItem.Image")));
            this.btn_removeItem.Location = new System.Drawing.Point(0, 0);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(36, 33);
            this.btn_removeItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_removeItem.TabIndex = 0;
            this.btn_removeItem.TabStop = false;
            // 
            // treeview_docStr
            // 
            this.treeview_docStr.AllowDrop = true;
            this.treeview_docStr.Location = new System.Drawing.Point(21, 45);
            this.treeview_docStr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeview_docStr.Name = "treeview_docStr";
            this.treeview_docStr.ShowNodeToolTips = true;
            this.treeview_docStr.Size = new System.Drawing.Size(357, 527);
            this.treeview_docStr.TabIndex = 1;
            // 
            // BookViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 662);
            this.Controls.Add(this.panel_bookNavigation);
            this.Controls.Add(this.tabControl_browser);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BookViewForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl_browser.ResumeLayout(false);
            this.panel_bookNavigation.ResumeLayout(false);
            this.panel_bookNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_applyItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_removeItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem saveBookToolStripMenuItem;
        private ToolStripMenuItem saveBookAsToolStripMenuItem;
        private ToolStripMenuItem closeBookToolStripMenuItem;
        private ToolStripMenuItem saveAndCloseToolStripMenuItem;
        private TabPage tabPage1;
        private TabPage tabPage2;
        public TabControl tabControl_browser;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ToolStripMenuItem tool_savePage;
        private ToolStripMenuItem tool_saveBook;
        private ToolStripMenuItem btn_openNavigationPanel;
        private Panel panel_bookNavigation;
        public TreeView treeview_docStr;
        private TextBox textBox_itemFilter;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox btn_applyItem;
        private PictureBox btn_addFolder;
        private TextBox textBox1;
        private PictureBox btn_addPage;
        private PictureBox btn_removeItem;
    }
}
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookViewForm));
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.btn_tool_header = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tool_ul = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tool_ol = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tool_hr = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tool_code = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tool_clearFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tool_highlight = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tool_colorText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtn_insertHref = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtn_insertRofToPage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtn_insertImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_replaceText = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_browser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel_bookNavigation = new System.Windows.Forms.Panel();
            this.panel_bookNavigationTop = new System.Windows.Forms.Panel();
            this.panel_bookNavBottomManage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_applyItem = new System.Windows.Forms.PictureBox();
            this.btn_addFolder = new System.Windows.Forms.PictureBox();
            this.textBox_itemEditName = new System.Windows.Forms.TextBox();
            this.btn_addPage = new System.Windows.Forms.PictureBox();
            this.btn_removeItem = new System.Windows.Forms.PictureBox();
            this.treeview_docStruct = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_openNavigationPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_savePage = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_saveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_treeNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip_main.SuspendLayout();
            this.tabControl_browser.SuspendLayout();
            this.panel_bookNavigation.SuspendLayout();
            this.panel_bookNavBottomManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_applyItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_removeItem)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.AutoSize = false;
            this.menuStrip_main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_tool_header,
            this.btn_tool_ul,
            this.btn_tool_ol,
            this.btn_tool_hr,
            this.btn_tool_code,
            this.btn_tool_clearFormat,
            this.btn_tool_highlight,
            this.btn_tool_colorText,
            this.toolStripMenuItem_insert,
            this.toolStripMenuItem_tools});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 32);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(798, 30);
            this.menuStrip_main.TabIndex = 4;
            this.menuStrip_main.Text = "menuStrip_toolBox";
            // 
            // btn_tool_header
            // 
            this.btn_tool_header.Name = "btn_tool_header";
            this.btn_tool_header.Size = new System.Drawing.Size(57, 26);
            this.btn_tool_header.Text = "Header";
            this.btn_tool_header.Click += new System.EventHandler(this.btn_tool_header_Click);
            // 
            // btn_tool_ul
            // 
            this.btn_tool_ul.Name = "btn_tool_ul";
            this.btn_tool_ul.Size = new System.Drawing.Size(29, 26);
            this.btn_tool_ul.Text = "ul";
            this.btn_tool_ul.Click += new System.EventHandler(this.btn_tool_ul_Click);
            // 
            // btn_tool_ol
            // 
            this.btn_tool_ol.Name = "btn_tool_ol";
            this.btn_tool_ol.Size = new System.Drawing.Size(25, 26);
            this.btn_tool_ol.Text = "li";
            this.btn_tool_ol.Click += new System.EventHandler(this.btn_tool_ol_Click);
            // 
            // btn_tool_hr
            // 
            this.btn_tool_hr.Name = "btn_tool_hr";
            this.btn_tool_hr.Size = new System.Drawing.Size(35, 26);
            this.btn_tool_hr.Text = "HR";
            this.btn_tool_hr.Click += new System.EventHandler(this.btn_tool_hr_Click);
            // 
            // btn_tool_code
            // 
            this.btn_tool_code.Name = "btn_tool_code";
            this.btn_tool_code.Size = new System.Drawing.Size(47, 26);
            this.btn_tool_code.Text = "Code";
            this.btn_tool_code.Click += new System.EventHandler(this.btn_tool_code_Click);
            // 
            // btn_tool_clearFormat
            // 
            this.btn_tool_clearFormat.Name = "btn_tool_clearFormat";
            this.btn_tool_clearFormat.Size = new System.Drawing.Size(46, 26);
            this.btn_tool_clearFormat.Text = "Clear";
            this.btn_tool_clearFormat.Click += new System.EventHandler(this.btn_tool_clearFormat_Click);
            // 
            // btn_tool_highlight
            // 
            this.btn_tool_highlight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.btn_tool_highlight.Name = "btn_tool_highlight";
            this.btn_tool_highlight.Size = new System.Drawing.Size(34, 26);
            this.btn_tool_highlight.Text = "HL";
            this.btn_tool_highlight.Click += new System.EventHandler(this.btn_tool_highlight_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // btn_tool_colorText
            // 
            this.btn_tool_colorText.Name = "btn_tool_colorText";
            this.btn_tool_colorText.Size = new System.Drawing.Size(40, 26);
            this.btn_tool_colorText.Text = "CLR";
            // 
            // toolStripMenuItem_insert
            // 
            this.toolStripMenuItem_insert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtn_insertHref,
            this.toolBtn_insertRofToPage,
            this.toolBtn_insertImage});
            this.toolStripMenuItem_insert.Name = "toolStripMenuItem_insert";
            this.toolStripMenuItem_insert.Size = new System.Drawing.Size(55, 26);
            this.toolStripMenuItem_insert.Text = "INSERT";
            // 
            // toolBtn_insertHref
            // 
            this.toolBtn_insertHref.Name = "toolBtn_insertHref";
            this.toolBtn_insertHref.Size = new System.Drawing.Size(171, 22);
            this.toolBtn_insertHref.Text = "External Reference";
            // 
            // toolBtn_insertRofToPage
            // 
            this.toolBtn_insertRofToPage.Name = "toolBtn_insertRofToPage";
            this.toolBtn_insertRofToPage.Size = new System.Drawing.Size(171, 22);
            this.toolBtn_insertRofToPage.Text = "Page Reference";
            this.toolBtn_insertRofToPage.Click += new System.EventHandler(this.toolBtn_insertRofToPage_Click);
            // 
            // toolBtn_insertImage
            // 
            this.toolBtn_insertImage.Name = "toolBtn_insertImage";
            this.toolBtn_insertImage.Size = new System.Drawing.Size(171, 22);
            this.toolBtn_insertImage.Text = "Load insert image";
            // 
            // toolStripMenuItem_tools
            // 
            this.toolStripMenuItem_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_replaceText});
            this.toolStripMenuItem_tools.Name = "toolStripMenuItem_tools";
            this.toolStripMenuItem_tools.Size = new System.Drawing.Size(54, 26);
            this.toolStripMenuItem_tools.Text = "TOOLS";
            // 
            // toolStripMenuItem_replaceText
            // 
            this.toolStripMenuItem_replaceText.Name = "toolStripMenuItem_replaceText";
            this.toolStripMenuItem_replaceText.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem_replaceText.Text = "Replace text";
            this.toolStripMenuItem_replaceText.Click += new System.EventHandler(this.toolStripMenuItem_replaceText_Click);
            // 
            // tabControl_browser
            // 
            this.tabControl_browser.Controls.Add(this.tabPage1);
            this.tabControl_browser.Controls.Add(this.tabPage2);
            this.tabControl_browser.Controls.Add(this.tabPage3);
            this.tabControl_browser.Controls.Add(this.tabPage4);
            this.tabControl_browser.Location = new System.Drawing.Point(0, 67);
            this.tabControl_browser.Name = "tabControl_browser";
            this.tabControl_browser.SelectedIndex = 0;
            this.tabControl_browser.Size = new System.Drawing.Size(798, 599);
            this.tabControl_browser.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "blank";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(790, 571);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel_bookNavigation
            // 
            this.panel_bookNavigation.BackColor = System.Drawing.Color.White;
            this.panel_bookNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bookNavigation.Controls.Add(this.panel_bookNavigationTop);
            this.panel_bookNavigation.Controls.Add(this.panel_bookNavBottomManage);
            this.panel_bookNavigation.Controls.Add(this.treeview_docStruct);
            this.panel_bookNavigation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_bookNavigation.Location = new System.Drawing.Point(554, 34);
            this.panel_bookNavigation.Name = "panel_bookNavigation";
            this.panel_bookNavigation.Size = new System.Drawing.Size(395, 630);
            this.panel_bookNavigation.TabIndex = 0;
            // 
            // panel_bookNavigationTop
            // 
            this.panel_bookNavigationTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_bookNavigationTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bookNavigationTop.Location = new System.Drawing.Point(0, -1);
            this.panel_bookNavigationTop.Name = "panel_bookNavigationTop";
            this.panel_bookNavigationTop.Size = new System.Drawing.Size(395, 28);
            this.panel_bookNavigationTop.TabIndex = 7;
            // 
            // panel_bookNavBottomManage
            // 
            this.panel_bookNavBottomManage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_bookNavBottomManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bookNavBottomManage.Controls.Add(this.label1);
            this.panel_bookNavBottomManage.Controls.Add(this.btn_applyItem);
            this.panel_bookNavBottomManage.Controls.Add(this.btn_addFolder);
            this.panel_bookNavBottomManage.Controls.Add(this.textBox_itemEditName);
            this.panel_bookNavBottomManage.Controls.Add(this.btn_addPage);
            this.panel_bookNavBottomManage.Controls.Add(this.btn_removeItem);
            this.panel_bookNavBottomManage.Location = new System.Drawing.Point(0, 601);
            this.panel_bookNavBottomManage.Name = "panel_bookNavBottomManage";
            this.panel_bookNavBottomManage.Size = new System.Drawing.Size(395, 28);
            this.panel_bookNavBottomManage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_applyItem
            // 
            this.btn_applyItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_applyItem.Image = ((System.Drawing.Image)(resources.GetObject("btn_applyItem.Image")));
            this.btn_applyItem.Location = new System.Drawing.Point(26, -1);
            this.btn_applyItem.Name = "btn_applyItem";
            this.btn_applyItem.Size = new System.Drawing.Size(28, 28);
            this.btn_applyItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_applyItem.TabIndex = 5;
            this.btn_applyItem.TabStop = false;
            this.btn_applyItem.Click += new System.EventHandler(this.btn_applyItem_Click);
            // 
            // btn_addFolder
            // 
            this.btn_addFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_addFolder.Image = ((System.Drawing.Image)(resources.GetObject("btn_addFolder.Image")));
            this.btn_addFolder.Location = new System.Drawing.Point(339, -1);
            this.btn_addFolder.Name = "btn_addFolder";
            this.btn_addFolder.Size = new System.Drawing.Size(28, 28);
            this.btn_addFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_addFolder.TabIndex = 4;
            this.btn_addFolder.TabStop = false;
            this.btn_addFolder.Click += new System.EventHandler(this.btn_addFolder_Click);
            // 
            // textBox_itemEditName
            // 
            this.textBox_itemEditName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_itemEditName.Location = new System.Drawing.Point(157, 5);
            this.textBox_itemEditName.Name = "textBox_itemEditName";
            this.textBox_itemEditName.Size = new System.Drawing.Size(171, 16);
            this.textBox_itemEditName.TabIndex = 3;
            // 
            // btn_addPage
            // 
            this.btn_addPage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_addPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_addPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addPage.Image = ((System.Drawing.Image)(resources.GetObject("btn_addPage.Image")));
            this.btn_addPage.Location = new System.Drawing.Point(366, -2);
            this.btn_addPage.Name = "btn_addPage";
            this.btn_addPage.Size = new System.Drawing.Size(28, 28);
            this.btn_addPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_addPage.TabIndex = 2;
            this.btn_addPage.TabStop = false;
            this.btn_addPage.Click += new System.EventHandler(this.btn_addPage_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_removeItem.Image = ((System.Drawing.Image)(resources.GetObject("btn_removeItem.Image")));
            this.btn_removeItem.Location = new System.Drawing.Point(-1, -1);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(28, 28);
            this.btn_removeItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_removeItem.TabIndex = 0;
            this.btn_removeItem.TabStop = false;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // treeview_docStruct
            // 
            this.treeview_docStruct.AllowDrop = true;
            this.treeview_docStruct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeview_docStruct.ItemHeight = 20;
            this.treeview_docStruct.Location = new System.Drawing.Point(1, 40);
            this.treeview_docStruct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeview_docStruct.Name = "treeview_docStruct";
            this.treeview_docStruct.ShowNodeToolTips = true;
            this.treeview_docStruct.Size = new System.Drawing.Size(390, 544);
            this.treeview_docStruct.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_openNavigationPanel,
            this.tool_savePage,
            this.tool_saveBook});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 32);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_openNavigationPanel
            // 
            this.btn_openNavigationPanel.AutoSize = false;
            this.btn_openNavigationPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_openNavigationPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_openNavigationPanel.Image = ((System.Drawing.Image)(resources.GetObject("btn_openNavigationPanel.Image")));
            this.btn_openNavigationPanel.MergeIndex = 1;
            this.btn_openNavigationPanel.Name = "btn_openNavigationPanel";
            this.btn_openNavigationPanel.Padding = new System.Windows.Forms.Padding(4);
            this.btn_openNavigationPanel.Size = new System.Drawing.Size(28, 28);
            this.btn_openNavigationPanel.Text = "toolStripMenuItem1";
            // 
            // tool_savePage
            // 
            this.tool_savePage.Name = "tool_savePage";
            this.tool_savePage.Size = new System.Drawing.Size(72, 28);
            this.tool_savePage.Text = "Save Page";
            // 
            // tool_saveBook
            // 
            this.tool_saveBook.Name = "tool_saveBook";
            this.tool_saveBook.Size = new System.Drawing.Size(73, 28);
            this.tool_saveBook.Text = "Save Book";
            // 
            // contextMenuStrip_treeNode
            // 
            this.contextMenuStrip_treeNode.Name = "contextMenuStrip_treeNode";
            this.contextMenuStrip_treeNode.Size = new System.Drawing.Size(61, 4);
            // 
            // BookViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(798, 662);
            this.Controls.Add(this.panel_bookNavigation);
            this.Controls.Add(this.tabControl_browser);
            this.Controls.Add(this.menuStrip_main);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(600, 0);
            this.Name = "BookViewForm";
            this.Text = "Form1";
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.tabControl_browser.ResumeLayout(false);
            this.panel_bookNavigation.ResumeLayout(false);
            this.panel_bookNavBottomManage.ResumeLayout(false);
            this.panel_bookNavBottomManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_applyItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_removeItem)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuStrip_main;
        private TabPage tabPage1;
        private TabPage tabPage2;
        public TabControl tabControl_browser;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel_bookNavigation;
        public TreeView treeview_docStruct;
        private Panel panel_bookNavBottomManage;
        private PictureBox btn_applyItem;
        private PictureBox btn_addFolder;
        private TextBox textBox_itemEditName;
        private PictureBox btn_addPage;
        private PictureBox btn_removeItem;
        private Label label1;
        private Panel panel_bookNavigationTop;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btn_openNavigationPanel;
        private ToolStripMenuItem tool_savePage;
        private ToolStripMenuItem tool_saveBook;
        private ToolStripMenuItem btn_tool_header;
        private ToolStripMenuItem btn_tool_ul;
        private ToolStripMenuItem btn_tool_ol;
        private ToolStripMenuItem btn_tool_hr;
        private ToolStripMenuItem btn_tool_code;
        private ToolStripMenuItem btn_tool_clearFormat;
        private ToolStripMenuItem btn_tool_highlight;
        private ContextMenuStrip contextMenuStrip_treeNode;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_insert;
        private ToolStripMenuItem toolBtn_insertHref;
        private ToolStripMenuItem toolBtn_insertRofToPage;
        private ToolStripMenuItem toolBtn_insertImage;
        private ToolStripMenuItem toolStripMenuItem_tools;
        private ToolStripMenuItem toolStripMenuItem_replaceText;
        private ToolStripMenuItem btn_tool_colorText;
    }
}
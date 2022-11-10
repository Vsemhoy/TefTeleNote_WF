﻿namespace TefTeleNote_WF
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
            this.btn_tool_insertAnchor = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_browser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel_bookNavigation = new System.Windows.Forms.Panel();
            this.panel_bookNavigationTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
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
            this.panel_bookNavigationTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.btn_tool_insertAnchor});
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
            this.btn_tool_highlight.Name = "btn_tool_highlight";
            this.btn_tool_highlight.Size = new System.Drawing.Size(69, 26);
            this.btn_tool_highlight.Text = "Highlight";
            this.btn_tool_highlight.Click += new System.EventHandler(this.btn_tool_highlight_Click);
            // 
            // btn_tool_insertAnchor
            // 
            this.btn_tool_insertAnchor.Name = "btn_tool_insertAnchor";
            this.btn_tool_insertAnchor.Size = new System.Drawing.Size(25, 26);
            this.btn_tool_insertAnchor.Text = "a";
            this.btn_tool_insertAnchor.Click += new System.EventHandler(this.btn_tool_insertAnchor_Click);
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
            this.panel_bookNavigationTop.Controls.Add(this.label2);
            this.panel_bookNavigationTop.Controls.Add(this.pictureBox1);
            this.panel_bookNavigationTop.Controls.Add(this.pictureBox3);
            this.panel_bookNavigationTop.Controls.Add(this.textBox2);
            this.panel_bookNavigationTop.Controls.Add(this.pictureBox4);
            this.panel_bookNavigationTop.Controls.Add(this.pictureBox5);
            this.panel_bookNavigationTop.Location = new System.Drawing.Point(0, -1);
            this.panel_bookNavigationTop.Name = "panel_bookNavigationTop";
            this.panel_bookNavigationTop.Size = new System.Drawing.Size(395, 28);
            this.panel_bookNavigationTop.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(339, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(135, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 16);
            this.textBox2.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(366, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
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
            this.label1.Location = new System.Drawing.Point(88, 5);
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
            this.treeview_docStruct.CheckBoxes = true;
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
            this.contextMenuStrip_treeNode.Size = new System.Drawing.Size(181, 26);
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
            this.Name = "BookViewForm";
            this.Text = "Form1";
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.tabControl_browser.ResumeLayout(false);
            this.panel_bookNavigation.ResumeLayout(false);
            this.panel_bookNavigationTop.ResumeLayout(false);
            this.panel_bookNavigationTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
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
        private ToolStripMenuItem btn_tool_insertAnchor;
        private ContextMenuStrip contextMenuStrip_treeNode;
    }
}
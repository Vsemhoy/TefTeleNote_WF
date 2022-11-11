namespace TefTeleNote_WF
{
    partial class BookShelfForm
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
            this.panel_bookList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Filter_Menu_strip = new System.Windows.Forms.MenuStrip();
            this.btn_FilterBy = new System.Windows.Forms.ToolStripMenuItem();
            this.aBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_strip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_bookDescription = new System.Windows.Forms.Panel();
            this.panel_bookList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Filter_Menu_strip.SuspendLayout();
            this.mainMenu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bookList
            // 
            this.panel_bookList.AutoScroll = true;
            this.panel_bookList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_bookList.Controls.Add(this.panel2);
            this.panel_bookList.Location = new System.Drawing.Point(0, 69);
            this.panel_bookList.Name = "panel_bookList";
            this.panel_bookList.Size = new System.Drawing.Size(494, 604);
            this.panel_bookList.TabIndex = 1;
            this.panel_bookList.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_bookList_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 62);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Updated: 22.10.2022";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Updated: 22.10.2022";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "The story of my mind\'s blow in the jungle and I want to generate 60 letters in th" +
    "is row...\r\n";
            // 
            // Filter_Menu_strip
            // 
            this.Filter_Menu_strip.AutoSize = false;
            this.Filter_Menu_strip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Filter_Menu_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Filter_Menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_FilterBy,
            this.filterByCategoryToolStripMenuItem,
            this.filterByAuthorToolStripMenuItem});
            this.Filter_Menu_strip.Location = new System.Drawing.Point(0, 34);
            this.Filter_Menu_strip.Name = "Filter_Menu_strip";
            this.Filter_Menu_strip.Size = new System.Drawing.Size(827, 32);
            this.Filter_Menu_strip.TabIndex = 4;
            this.Filter_Menu_strip.Text = "FilterMenuStrip";
            // 
            // btn_FilterBy
            // 
            this.btn_FilterBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBToolStripMenuItem,
            this.lastOpenToolStripMenuItem,
            this.aBToolStripMenuItem1});
            this.btn_FilterBy.Name = "btn_FilterBy";
            this.btn_FilterBy.Size = new System.Drawing.Size(56, 28);
            this.btn_FilterBy.Text = "Sort By";
            // 
            // aBToolStripMenuItem
            // 
            this.aBToolStripMenuItem.Name = "aBToolStripMenuItem";
            this.aBToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aBToolStripMenuItem.Text = "Last Update";
            // 
            // lastOpenToolStripMenuItem
            // 
            this.lastOpenToolStripMenuItem.Name = "lastOpenToolStripMenuItem";
            this.lastOpenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.lastOpenToolStripMenuItem.Text = "Last Open";
            // 
            // aBToolStripMenuItem1
            // 
            this.aBToolStripMenuItem1.Name = "aBToolStripMenuItem1";
            this.aBToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.aBToolStripMenuItem1.Text = "A-B";
            // 
            // filterByCategoryToolStripMenuItem
            // 
            this.filterByCategoryToolStripMenuItem.Name = "filterByCategoryToolStripMenuItem";
            this.filterByCategoryToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.filterByCategoryToolStripMenuItem.Text = "Filter by category";
            // 
            // filterByAuthorToolStripMenuItem
            // 
            this.filterByAuthorToolStripMenuItem.Name = "filterByAuthorToolStripMenuItem";
            this.filterByAuthorToolStripMenuItem.Size = new System.Drawing.Size(101, 28);
            this.filterByAuthorToolStripMenuItem.Text = "Filter by Author";
            // 
            // mainMenu_strip
            // 
            this.mainMenu_strip.AutoSize = false;
            this.mainMenu_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.mainMenu_strip.Location = new System.Drawing.Point(0, 0);
            this.mainMenu_strip.Name = "mainMenu_strip";
            this.mainMenu_strip.Size = new System.Drawing.Size(827, 34);
            this.mainMenu_strip.TabIndex = 5;
            this.mainMenu_strip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBookToolStripMenuItem,
            this.importBookToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 30);
            this.toolStripMenuItem1.Text = "File";
            // 
            // createBookToolStripMenuItem
            // 
            this.createBookToolStripMenuItem.Name = "createBookToolStripMenuItem";
            this.createBookToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.createBookToolStripMenuItem.Text = "Create book";
            // 
            // importBookToolStripMenuItem
            // 
            this.importBookToolStripMenuItem.Name = "importBookToolStripMenuItem";
            this.importBookToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.importBookToolStripMenuItem.Text = "Import Book";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 30);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // panel_bookDescription
            // 
            this.panel_bookDescription.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_bookDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bookDescription.Location = new System.Drawing.Point(492, 74);
            this.panel_bookDescription.Name = "panel_bookDescription";
            this.panel_bookDescription.Size = new System.Drawing.Size(328, 588);
            this.panel_bookDescription.TabIndex = 6;
            // 
            // BookShelfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(827, 669);
            this.Controls.Add(this.panel_bookDescription);
            this.Controls.Add(this.Filter_Menu_strip);
            this.Controls.Add(this.panel_bookList);
            this.Controls.Add(this.mainMenu_strip);
            this.MainMenuStrip = this.Filter_Menu_strip;
            this.MinimumSize = new System.Drawing.Size(600, 0);
            this.Name = "BookShelfForm";
            this.Text = "BookForm";
            this.panel_bookList.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Filter_Menu_strip.ResumeLayout(false);
            this.Filter_Menu_strip.PerformLayout();
            this.mainMenu_strip.ResumeLayout(false);
            this.mainMenu_strip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel_bookList;
        private Panel panel2;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private Label label1;
        private Panel panel6;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private PictureBox pictureBox5;
        private Panel panel5;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private MenuStrip Filter_Menu_strip;
        private MenuStrip mainMenu_strip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem createBookToolStripMenuItem;
        private ToolStripMenuItem importBookToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label3;
        private ToolStripMenuItem btn_FilterBy;
        private ToolStripMenuItem aBToolStripMenuItem;
        private ToolStripMenuItem lastOpenToolStripMenuItem;
        private ToolStripMenuItem aBToolStripMenuItem1;
        private ToolStripMenuItem filterByCategoryToolStripMenuItem;
        private ToolStripMenuItem filterByAuthorToolStripMenuItem;
        private Panel panel_bookDescription;
    }
}
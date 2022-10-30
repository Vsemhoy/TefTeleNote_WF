namespace TefTeleNote_WF
{
    partial class BookSetForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_selectIcon = new System.Windows.Forms.Button();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_selectCover = new System.Windows.Forms.Button();
            this.pictureBox_cover = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_selecSuperCover = new System.Windows.Forms.Button();
            this.pictureBox_super = new System.Windows.Forms.PictureBox();
            this.btn_createBook = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            this.texbox_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_categories = new System.Windows.Forms.ComboBox();
            this.combox_language = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_css = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_metaTitle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_metaDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_metaKeywords = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_super)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_selectIcon);
            this.groupBox1.Controls.Add(this.pictureBox_icon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icon 250x250";
            // 
            // btn_selectIcon
            // 
            this.btn_selectIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectIcon.Location = new System.Drawing.Point(6, 134);
            this.btn_selectIcon.Name = "btn_selectIcon";
            this.btn_selectIcon.Size = new System.Drawing.Size(100, 23);
            this.btn_selectIcon.TabIndex = 1;
            this.btn_selectIcon.Text = "select";
            this.btn_selectIcon.UseVisualStyleBackColor = true;
            this.btn_selectIcon.Click += new System.EventHandler(this.btn_selectIcon_Click);
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_icon.Location = new System.Drawing.Point(6, 22);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Title (name)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_selectCover);
            this.groupBox2.Controls.Add(this.pictureBox_cover);
            this.groupBox2.Location = new System.Drawing.Point(135, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cover 500*500";
            // 
            // btn_selectCover
            // 
            this.btn_selectCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectCover.Location = new System.Drawing.Point(7, 134);
            this.btn_selectCover.Name = "btn_selectCover";
            this.btn_selectCover.Size = new System.Drawing.Size(99, 23);
            this.btn_selectCover.TabIndex = 1;
            this.btn_selectCover.Text = "select";
            this.btn_selectCover.UseVisualStyleBackColor = true;
            this.btn_selectCover.Click += new System.EventHandler(this.btn_selectCover_Click);
            // 
            // pictureBox_cover
            // 
            this.pictureBox_cover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_cover.Location = new System.Drawing.Point(6, 22);
            this.pictureBox_cover.Name = "pictureBox_cover";
            this.pictureBox_cover.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cover.TabIndex = 0;
            this.pictureBox_cover.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_selecSuperCover);
            this.groupBox3.Controls.Add(this.pictureBox_super);
            this.groupBox3.Location = new System.Drawing.Point(258, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 362);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Super cover any size (large)";
            // 
            // btn_selecSuperCover
            // 
            this.btn_selecSuperCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selecSuperCover.Location = new System.Drawing.Point(6, 331);
            this.btn_selecSuperCover.Name = "btn_selecSuperCover";
            this.btn_selecSuperCover.Size = new System.Drawing.Size(99, 23);
            this.btn_selecSuperCover.TabIndex = 1;
            this.btn_selecSuperCover.Text = "select";
            this.btn_selecSuperCover.UseVisualStyleBackColor = true;
            this.btn_selecSuperCover.Click += new System.EventHandler(this.btn_selecSuperCover_Click);
            // 
            // pictureBox_super
            // 
            this.pictureBox_super.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_super.Location = new System.Drawing.Point(6, 22);
            this.pictureBox_super.Name = "pictureBox_super";
            this.pictureBox_super.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_super.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_super.TabIndex = 0;
            this.pictureBox_super.TabStop = false;
            // 
            // btn_createBook
            // 
            this.btn_createBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createBook.Location = new System.Drawing.Point(425, 624);
            this.btn_createBook.Name = "btn_createBook";
            this.btn_createBook.Size = new System.Drawing.Size(147, 30);
            this.btn_createBook.TabIndex = 2;
            this.btn_createBook.Text = "Create";
            this.btn_createBook.UseVisualStyleBackColor = true;
            this.btn_createBook.Click += new System.EventHandler(this.btn_createBook_Click);
            // 
            // btn_abort
            // 
            this.btn_abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abort.Location = new System.Drawing.Point(258, 624);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(152, 30);
            this.btn_abort.TabIndex = 4;
            this.btn_abort.Text = "Abort";
            this.btn_abort.UseVisualStyleBackColor = true;
            // 
            // texbox_title
            // 
            this.texbox_title.Location = new System.Drawing.Point(12, 207);
            this.texbox_title.Name = "texbox_title";
            this.texbox_title.Size = new System.Drawing.Size(235, 23);
            this.texbox_title.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category";
            // 
            // combox_categories
            // 
            this.combox_categories.FormattingEnabled = true;
            this.combox_categories.Location = new System.Drawing.Point(12, 286);
            this.combox_categories.Name = "combox_categories";
            this.combox_categories.Size = new System.Drawing.Size(235, 23);
            this.combox_categories.TabIndex = 9;
            // 
            // combox_language
            // 
            this.combox_language.FormattingEnabled = true;
            this.combox_language.Location = new System.Drawing.Point(12, 351);
            this.combox_language.Name = "combox_language";
            this.combox_language.Size = new System.Drawing.Size(235, 23);
            this.combox_language.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "This parameter uses for filtering books";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Book folder also use it\'s name, but it can be renamed as you wish";
            // 
            // textbox_description
            // 
            this.textbox_description.Location = new System.Drawing.Point(6, 26);
            this.textbox_description.MaxLength = 500;
            this.textbox_description.Multiline = true;
            this.textbox_description.Name = "textbox_description";
            this.textbox_description.Size = new System.Drawing.Size(540, 108);
            this.textbox_description.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Book description";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 380);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 238);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textbox_description);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TITLE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(6, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(294, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "The description of the book. Maximum 500 characters.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textbox_css);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "STYLE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(6, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Each page of the book will inherit this styles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "CSS styles";
            // 
            // textbox_css
            // 
            this.textbox_css.Location = new System.Drawing.Point(6, 30);
            this.textbox_css.MaxLength = 300;
            this.textbox_css.Multiline = true;
            this.textbox_css.Name = "textbox_css";
            this.textbox_css.Size = new System.Drawing.Size(540, 146);
            this.textbox_css.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.textBox_metaTitle);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.textBox_metaDescription);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox_metaKeywords);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SEO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(6, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Maximum 70 characters";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(6, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Meta Title";
            // 
            // textBox_metaTitle
            // 
            this.textBox_metaTitle.Location = new System.Drawing.Point(6, 169);
            this.textBox_metaTitle.MaxLength = 70;
            this.textBox_metaTitle.Name = "textBox_metaTitle";
            this.textBox_metaTitle.Size = new System.Drawing.Size(540, 23);
            this.textBox_metaTitle.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(6, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Maximum 200 characters";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Meta Description";
            // 
            // textBox_metaDescription
            // 
            this.textBox_metaDescription.Location = new System.Drawing.Point(6, 100);
            this.textBox_metaDescription.MaxLength = 200;
            this.textBox_metaDescription.Name = "textBox_metaDescription";
            this.textBox_metaDescription.Size = new System.Drawing.Size(540, 23);
            this.textBox_metaDescription.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Maximum 60 characters";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Meta Keywords";
            // 
            // textBox_metaKeywords
            // 
            this.textBox_metaKeywords.Location = new System.Drawing.Point(6, 30);
            this.textBox_metaKeywords.MaxLength = 60;
            this.textBox_metaKeywords.Name = "textBox_metaKeywords";
            this.textBox_metaKeywords.Size = new System.Drawing.Size(540, 23);
            this.textBox_metaKeywords.TabIndex = 25;
            // 
            // BookSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combox_language);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combox_categories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texbox_title);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.btn_createBook);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookSetForm";
            this.Text = "Book Editor";
            this.Load += new System.EventHandler(this.BookSetForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cover)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_super)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private PictureBox pictureBox_icon;
        private Button btn_selectIcon;
        private GroupBox groupBox2;
        private Button btn_selectCover;
        private PictureBox pictureBox_cover;
        private GroupBox groupBox3;
        private Button btn_selecSuperCover;
        private PictureBox pictureBox_super;
        private Button btn_createBook;
        private Button btn_abort;
        private TextBox texbox_title;
        private Label label2;
        private ComboBox combox_categories;
        private ComboBox combox_language;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textbox_description;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label13;
        private TabPage tabPage2;
        private Label label8;
        private Label label7;
        private TextBox textbox_css;
        private TabPage tabPage3;
        private Label label14;
        private Label label15;
        private TextBox textBox_metaTitle;
        private Label label11;
        private Label label12;
        private TextBox textBox_metaDescription;
        private Label label9;
        private Label label10;
        private TextBox textBox_metaKeywords;
    }
}
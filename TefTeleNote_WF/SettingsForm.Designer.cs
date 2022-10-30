namespace TefTeleNote_WF
{
    partial class SettingsForm
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
            this.textBox_authorName = new System.Windows.Forms.TextBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.btn_chooseFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_language = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_authorName
            // 
            this.textBox_authorName.Location = new System.Drawing.Point(117, 27);
            this.textBox_authorName.Name = "textBox_authorName";
            this.textBox_authorName.Size = new System.Drawing.Size(431, 23);
            this.textBox_authorName.TabIndex = 0;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_userName.Location = new System.Drawing.Point(6, 30);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(66, 15);
            this.lbl_userName.TabIndex = 1;
            this.lbl_userName.Text = "Your Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "This name will be used as the name of the author of the book";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_location.Location = new System.Drawing.Point(6, 28);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(105, 15);
            this.lbl_location.TabIndex = 4;
            this.lbl_location.Text = "Bookshelf location";
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(117, 25);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(340, 23);
            this.textBox_location.TabIndex = 3;
            // 
            // btn_chooseFolder
            // 
            this.btn_chooseFolder.Location = new System.Drawing.Point(463, 25);
            this.btn_chooseFolder.Name = "btn_chooseFolder";
            this.btn_chooseFolder.Size = new System.Drawing.Size(91, 23);
            this.btn_chooseFolder.TabIndex = 5;
            this.btn_chooseFolder.Text = "choose";
            this.btn_chooseFolder.UseVisualStyleBackColor = true;
            this.btn_chooseFolder.Click += new System.EventHandler(this.btn_chooseFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "All books are located in this folder";
            // 
            // combox_language
            // 
            this.combox_language.FormattingEnabled = true;
            this.combox_language.Location = new System.Drawing.Point(117, 91);
            this.combox_language.Name = "combox_language";
            this.combox_language.Size = new System.Drawing.Size(165, 23);
            this.combox_language.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Language";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_location);
            this.groupBox1.Controls.Add(this.textBox_location);
            this.groupBox1.Controls.Add(this.btn_chooseFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_userName);
            this.groupBox2.Controls.Add(this.textBox_authorName);
            this.groupBox2.Controls.Add(this.combox_language);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 223);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox_authorName;
        private Label lbl_userName;
        private Label label1;
        private Label lbl_location;
        private TextBox textBox_location;
        private Button btn_chooseFolder;
        private Label label2;
        private ComboBox combox_language;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
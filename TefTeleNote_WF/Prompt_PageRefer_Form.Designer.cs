namespace TefTeleNote_WF
{
    partial class Prompt_PageRefer_Form
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
            this.textBox_refText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_pageList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_anchor = new System.Windows.Forms.TextBox();
            this.btn_insertLink = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_refText
            // 
            this.textBox_refText.Location = new System.Drawing.Point(108, 11);
            this.textBox_refText.Name = "textBox_refText";
            this.textBox_refText.Size = new System.Drawing.Size(305, 23);
            this.textBox_refText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reference Text";
            // 
            // combox_pageList
            // 
            this.combox_pageList.FormattingEnabled = true;
            this.combox_pageList.Location = new System.Drawing.Point(108, 45);
            this.combox_pageList.Name = "combox_pageList";
            this.combox_pageList.Size = new System.Drawing.Size(305, 23);
            this.combox_pageList.TabIndex = 2;
            this.combox_pageList.SelectedIndexChanged += new System.EventHandler(this.combox_pageList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Page:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Anchor ID";
            // 
            // textBox_anchor
            // 
            this.textBox_anchor.Location = new System.Drawing.Point(108, 82);
            this.textBox_anchor.Name = "textBox_anchor";
            this.textBox_anchor.Size = new System.Drawing.Size(304, 23);
            this.textBox_anchor.TabIndex = 8;
            // 
            // btn_insertLink
            // 
            this.btn_insertLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insertLink.Location = new System.Drawing.Point(274, 125);
            this.btn_insertLink.Name = "btn_insertLink";
            this.btn_insertLink.Size = new System.Drawing.Size(138, 31);
            this.btn_insertLink.TabIndex = 9;
            this.btn_insertLink.Text = "Insert ";
            this.btn_insertLink.UseVisualStyleBackColor = true;
            this.btn_insertLink.Click += new System.EventHandler(this.btn_insertLink_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(180, 125);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 31);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Prompt_PageRefer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 167);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_insertLink);
            this.Controls.Add(this.textBox_anchor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combox_pageList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_refText);
            this.Name = "Prompt_PageRefer_Form";
            this.Text = "Prompt_PageRefer_Form";
            this.Load += new System.EventHandler(this.Prompt_PageRefer_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_refText;
        private Label label1;
        private ComboBox combox_pageList;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_anchor;
        private Button btn_insertLink;
        private Button btn_close;
    }
}
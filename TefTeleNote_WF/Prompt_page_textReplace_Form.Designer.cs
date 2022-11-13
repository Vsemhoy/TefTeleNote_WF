namespace Booker_WF
{
    partial class Prompt_page_textReplace_Form
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
            this.textBox_whatFind = new System.Windows.Forms.TextBox();
            this.textBox_replaceTo = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_replace = new System.Windows.Forms.Button();
            this.label_text = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.chb_caseIgnore = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_whatFind
            // 
            this.textBox_whatFind.Location = new System.Drawing.Point(12, 12);
            this.textBox_whatFind.Name = "textBox_whatFind";
            this.textBox_whatFind.Size = new System.Drawing.Size(262, 23);
            this.textBox_whatFind.TabIndex = 0;
            // 
            // textBox_replaceTo
            // 
            this.textBox_replaceTo.Location = new System.Drawing.Point(12, 41);
            this.textBox_replaceTo.Name = "textBox_replaceTo";
            this.textBox_replaceTo.Size = new System.Drawing.Size(262, 23);
            this.textBox_replaceTo.TabIndex = 1;
            // 
            // btn_find
            // 
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Location = new System.Drawing.Point(280, 12);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 2;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_replace
            // 
            this.btn_replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_replace.Location = new System.Drawing.Point(280, 41);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(75, 23);
            this.btn_replace.TabIndex = 3;
            this.btn_replace.Text = "Replace";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(12, 107);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(99, 15);
            this.label_text.TabIndex = 4;
            this.label_text.Text = "0 matches found:";
            // 
            // btn_apply
            // 
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.Location = new System.Drawing.Point(280, 96);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 26);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // chb_caseIgnore
            // 
            this.chb_caseIgnore.AutoSize = true;
            this.chb_caseIgnore.Location = new System.Drawing.Point(12, 69);
            this.chb_caseIgnore.Name = "chb_caseIgnore";
            this.chb_caseIgnore.Size = new System.Drawing.Size(86, 19);
            this.chb_caseIgnore.TabIndex = 6;
            this.chb_caseIgnore.Text = "ignore case";
            this.chb_caseIgnore.UseVisualStyleBackColor = true;
            // 
            // Prompt_page_textReplace_Form
            // 
            this.AcceptButton = this.btn_apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 129);
            this.Controls.Add(this.chb_caseIgnore);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.textBox_replaceTo);
            this.Controls.Add(this.textBox_whatFind);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prompt_page_textReplace_Form";
            this.Text = "Find and Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_whatFind;
        private TextBox textBox_replaceTo;
        private Button btn_find;
        private Button btn_replace;
        private Label label_text;
        private Button btn_apply;
        private CheckBox chb_caseIgnore;
    }
}
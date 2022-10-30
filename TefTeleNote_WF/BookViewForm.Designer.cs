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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBookAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webVisor2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webVisor2)).BeginInit();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
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
            // webVisor2
            // 
            this.webVisor2.AllowExternalDrop = true;
            this.webVisor2.CreationProperties = null;
            this.webVisor2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webVisor2.Location = new System.Drawing.Point(12, 63);
            this.webVisor2.Name = "webVisor2";
            this.webVisor2.Size = new System.Drawing.Size(763, 550);
            this.webVisor2.TabIndex = 5;
            this.webVisor2.ZoomFactor = 1D;
            // 
            // BookViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 662);
            this.Controls.Add(this.webVisor2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BookViewForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webVisor2)).EndInit();
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
        private Microsoft.Web.WebView2.WinForms.WebView2 webVisor2;
    }
}
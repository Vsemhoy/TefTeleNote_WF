using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TefTeleNote_WF
{
    public partial class BookViewForm : Form
    {
        public BookViewForm()
        {
            InitializeComponent();
            Uri uri = new Uri("http://www.google.com");
            webVisor2.Source = uri;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //string Text = await webVisor.ExecuteScriptAsync("document.getElementsByTagName('body')[0].innerHTML;");
            //MessageBox.Show(Text);
            await webVisor2.ExecuteScriptAsync("document.getElementsByTagName('body')[0].setAttribute('contenteditable', true);");
        }
    }
}

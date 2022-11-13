using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TefTeleNote_WF.Data;

namespace Booker_WF
{
    public partial class Prompt_page_textReplace_Form : Form
    {
        Page text;
        public bool ToDestroy;
        public bool NotClosed;
        public Prompt_page_textReplace_Form(Page page)
        {
            InitializeComponent();
            text = page;
            this.ToDestroy = false;
            this.NotClosed = true;
            this.FormClosing += Prompt_page_textReplace_Form_FormClosing;
            
        }

        private void Prompt_page_textReplace_Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.ToDestroy = true;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            String pattern = textBox_whatFind.Text;

            //Regex.IsMatch(this.text, pattern, RegexOptions.IgnoreCase);
            MatchCollection mtc;
            if (chb_caseIgnore.Checked)
            {
                mtc = Regex.Matches(this.text.name, pattern, RegexOptions.IgnoreCase);

            } else
            {
                mtc = Regex.Matches(this.text.name, pattern);

            }
            if (mtc.Count == 0)
            {
                label_text.Text = "No matches found";
            } else if (mtc.Count == 1)
            {
                label_text.Text = mtc.Count.ToString() + " match found";
            } else
            {
                label_text.Text = mtc.Count.ToString() + " matches found";

            }

        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            string pattern = textBox_whatFind.Text;
            string repTo = textBox_replaceTo.Text;

            if (chb_caseIgnore.Checked)
            {
                text.name = text.name.Replace(pattern, repTo, StringComparison.OrdinalIgnoreCase) ;
            }
            else
            {
                text.name = text.name.Replace(pattern, repTo, StringComparison.Ordinal) ;
            }
            label_text.Text = "Replaced!";
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            this.NotClosed = false;
            this.ToDestroy = true;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TefTeleNote_WF.Data;
using TefTeleNote_WF.Transfer;

namespace TefTeleNote_WF
{
    public partial class Prompt_PageRefer_Form : Form
    {
        List<ItemStructure> list;
        public TransReferenceGoToPage trdp;
        public Prompt_PageRefer_Form(List<ItemStructure> structure, TransReferenceGoToPage transRef)
        {
            InitializeComponent();
            this.trdp = transRef;
            this.combox_pageList.SelectedIndexChanged += Combox_pageList_SelectedIndexChanged;

            list = new List<ItemStructure>();

                foreach (ItemStructure item in structure)
                {
            try
            {
                    if (item.type == 1)
                    {
                        string pathString = string.Empty;
                        if (!string.IsNullOrEmpty(item.path))
                        {
                            var pats = item.path.Split('\\');
                            foreach (var pat in pats)
                            {
                                string nam = pat.Substring(0, 6).Trim() + ".. / ";
                                pathString += nam;
                            }
                        }
                        combox_pageList.Items.Add(pathString + item.name);
                        list.Add(item);
                    }
            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
                }

        }

        private void Combox_pageList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                if (this.textBox_refText.Text.Length == 0)
                {
                    int selindex = combox_pageList.SelectedIndex;
                    if (selindex == -1) { return; }
                    this.textBox_refText.Text = list[selindex].name;
                }
            } 
            catch (System.Exception ex)
            {

            }
        }

        private void Prompt_PageRefer_Form_Load(object sender, EventArgs e)
        {

        }

        private void combox_pageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_insertLink_Click(object sender, EventArgs e)
        {
            int selindex = combox_pageList.SelectedIndex;
            if (selindex == -1) { return; }
            this.trdp.referencePage = list[selindex].id;
            this.trdp.referenceText = textBox_refText.Text;
            if (this.trdp.referenceText.Length < 1) { textBox_refText.Focus();  return; }
            this.trdp.referenceAnch = textBox_anchor.Text;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

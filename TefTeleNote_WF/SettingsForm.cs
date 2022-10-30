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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.textBox_authorName.TextChanged += TextBox_authorName_TextChanged;
            this.FormClosed += SettingsForm_FormClosed;
            this.VisibleChanged += SettingsForm_VisibleChanged;

        }

        private void SettingsForm_VisibleChanged(object? sender, EventArgs e)
        {
            try
            {
                if (((Control)sender).Visible)
                {
                    UserConfig.ReadConfig();
                    this.textBox_authorName.Text = UserConfig.userName;
                    this.textBox_authorName.Focus();
                    this.textBox_location.Text = UserConfig.folderShelf;

                    this.combox_language.Items.Clear();
                    int lanIndex = 0;
                    int counter = 0;
                    foreach (var lan in Language.languageList)
                    {
                        combox_language.Items.Add(lan.nativeName);
                        if (UserConfig.languageCode == lan.code)
                        {
                            lanIndex = counter;
                        }
                        counter++;
                    }
                    if (combox_language.Items.Count > 0)
                    {
                        combox_language.SelectedIndex = lanIndex;
                    }
                }
            } catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message, "ERROR STF_001");
            }
        }

        private void SettingsForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.SaveSettings();
        }

        private void TextBox_authorName_TextChanged(object? sender, EventArgs e)
        {
            
        }

        private void SaveSettings()
        {
            UserConfig.folderShelf = this.textBox_location.Text;
            UserConfig.userName = this.textBox_authorName.Text;
            if (this.combox_language.Items.Count > 0)
            {
                string flang = this.combox_language.Text;
                foreach (var lan in Language.languageList)
                {
                    if (flang.ToLower() == lan.nativeName.ToLower())
                    {
                        UserConfig.languageCode = lan.code;
                        break;
                    }
                }
            }

            UserConfig.WriteConfig();
        }

        private void btn_chooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            fbd.ShowDialog();
            string pathFolder = fbd.SelectedPath;
            this.textBox_location.Text = pathFolder;
        }
    }
}

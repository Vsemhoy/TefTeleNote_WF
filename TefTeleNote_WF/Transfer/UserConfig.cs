using Diga.Core.Api.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TefTeleNote_WF.Transfer
{
    internal static class UserConfig
    {
        public static string userName = string.Empty;
        public static string folderShelf = string.Empty;
        private static string configName = "config.xml";
        public static string folderRoot = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string foldeConfig = Path.Combine(folderRoot, "config");
        public static string configPath = Path.Combine(foldeConfig, configName);
        public static int languageCode = 45;

        /// <summary>
        /// first - order, second - id
        /// </summary>
        public static List<(int, string)> bookOrderList = new List<(int, string)>();

        public static bool WriteConfig()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            StringBuilder output = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(output, settings);
            xmlWriter.WriteStartElement("config");

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteStartElement("userName");
            xmlWriter.WriteString(userName);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("langCode");
            xmlWriter.WriteString(languageCode.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("data");
            xmlWriter.WriteStartElement("bookFolder");
            xmlWriter.WriteString(folderShelf);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();
            xmlWriter.Close();

            string result = output.ToString();

            try
            {
                bool exists = Directory.Exists(foldeConfig);

                if (!exists)
                {
                    Directory.CreateDirectory(foldeConfig);
                    OpenFileSequrity(configPath);
                }
                File.WriteAllText(configPath, string.Empty);
                File.WriteAllText(configPath, result);
                return true;
            }
            catch (Exception eex)
            {
                if (true)
                {
                    //DialogResult answer = MessageBox.Show("Невозможно создать (сохранить) файл конфигурации. \nДиректория, (" +
                    //    path 
                    //    + ") может быть защищена от записи. \n\nЕсли проблема повторяется, создайте пустой файл конфигурации (" + filename + ") вручную в директории " + dir , "Ошибка: " + eex.Message, MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    //if (answer == DialogResult.Yes)
                    //{
                    //    hideSaveAlerts = true;
                    //    return false;
                    //}
                    //else
                    //{
                    //    hideSaveAlerts = false;
                    //    return false;
                    //}
                    MessageBox.Show("Невозможно создать (сохранить) файл конфигурации. \nДиректория, (" +
                    configPath
                        + ") может быть защищена от записи. \n\nЕсли проблема повторяется, создайте пустой файл конфигурации (" + configName + ") вручную в директории " + foldeConfig, "Ошибка: " + eex.Message, MessageBoxButtons.YesNo, MessageBoxIcon.None);

                }
            }
            return false;

        }

        public static bool ReadConfig()
        {
            var workingPath = configPath;
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string text = File.ReadAllText(workingPath);
                xmlDocument.LoadXml(text);
                XmlNode xmlNode;
                List<string> missingSections = new List<string>();
                try
                {
                    xmlNode = xmlDocument.GetElementsByTagName("user").Item(0);
                    if (xmlNode.SelectSingleNode("userName") != null)
                    {
                        userName = xmlNode.SelectSingleNode("userName").InnerText;
                    }
                    if (xmlNode.SelectSingleNode("langCode") != null)
                    {
                        languageCode = Convert.ToInt32(xmlNode.SelectSingleNode("langCode").InnerText);
                    }
                }
                catch (Exception excep1)
                {
                    missingSections.Add(excep1.Message);
                }
                try
                {
                    xmlNode = xmlDocument.GetElementsByTagName("data").Item(0);
                    if (xmlNode.SelectSingleNode("bookFolder") != null)
                    {
                        folderShelf = xmlNode.SelectSingleNode("bookFolder").InnerText;
                    }
                }
                catch (Exception excep2)
                {
                    missingSections.Add(excep2.Message);
                }

                if (missingSections.Count > 0)
                {
                    string final = "В файле конфигурации отсутствуют следующие узлы:";
                    foreach (string str in missingSections)
                    {
                        final += "\n" + str;
                    }
                    MessageBox.Show(final + "\nДля устранения проблемы повторно сохраните конфигурацию.", "Обновление файла конфигурации");
                }

                return true;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return false;
        }


        /// <summary>
        /// Open directory for write
        /// </summary>
        /// <param name="path"></param>
        public static void OpenFileSequrity(string path)
        {
            try
            {
                string fileName = path;

                //get bucket name and user name
                System.Security.Principal.WindowsIdentity wi = System.Security.Principal.WindowsIdentity.GetCurrent();
                string user = wi.Name;

                AddFileSecurity(fileName, @user,
                    FileSystemRights.FullControl, AccessControlType.Allow);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void AddFileSecurity(string fileName, string account,
          FileSystemRights rights, AccessControlType controlType)
        {
            string dir = Path.GetDirectoryName(fileName);
            DirectoryInfo directoryInfo = new DirectoryInfo(dir);
            DirectorySecurity fSecurity = directoryInfo.GetAccessControl();

            fSecurity.AddAccessRule(new FileSystemAccessRule(account,
                rights, controlType));
            directoryInfo.SetAccessControl(fSecurity);
        }


    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TefTeleNote_WF.Data;

namespace TefTeleNote_WF.Transfer
{
    public static class UserConfigOld
    {
        private static string dir = Directory.GetCurrentDirectory();
        private static string dirAlter = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static string fileName = "TefteleNote_WF.cfg";
        
        public static string configFullPath { get; set; }
        public static  string author { get; set; }
        public static string directoryFiles { get; set; }
       
        public static int  currentBookId { get; set; }
        public static string  currentBookName { get; set; }
        public static string  currentPage { get; set; }

        public static int formWidth  { get; set; }
        public static int formHeight { get; set; }
        public static int tabIndexSection { get; set; }



        public static bool WriteConfig()
        {

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            StringBuilder output = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(output, settings);
            xmlWriter.WriteStartElement("TefteleNote_WF");

            xmlWriter.WriteStartElement("UserConfig");
            xmlWriter.WriteStartElement("Author");
            xmlWriter.WriteString(author);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("DirectoryAutoLoad");
            xmlWriter.WriteString(directoryFiles);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("CurrentBook");
            xmlWriter.WriteString(currentBookId.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("CurrentBookName");
            xmlWriter.WriteString(currentBookName);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("FormWidth");
            xmlWriter.WriteString(formWidth.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("FormHeight");
            xmlWriter.WriteString(formHeight.ToString());
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("TabIndex");
            xmlWriter.WriteString(tabIndexSection.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("BookList");
            foreach (Book book in Library.BookList)
            {
                xmlWriter.WriteStartElement("Book");
                xmlWriter.WriteStartElement("BookId");
                xmlWriter.WriteString(book.id.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("BookName");
                xmlWriter.WriteString(book.bookName);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Title");
                xmlWriter.WriteString(book.title);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("FullPath");
                xmlWriter.WriteString(book.folderPath);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Author");
                xmlWriter.WriteString(book.author);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Page");
                xmlWriter.WriteString(book.currentPage);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Order");
                xmlWriter.WriteString(book.orderInList.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("SheetCount");
                xmlWriter.WriteString(book.sheetCount.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Opened");
                xmlWriter.WriteString(book.openTime.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Updated");
                xmlWriter.WriteString(book.updateTime.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("IsReadonly");
                xmlWriter.WriteString(book.isReadonly.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("IsCurrent");
                xmlWriter.WriteString(book.isCurrent.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("History");
                xmlWriter.WriteString(book.editHistory);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.Close();

            string result = output.ToString();
            try
            {
                configFullPath = dir + Path.DirectorySeparatorChar + fileName;
                File.WriteAllText(configFullPath, result);
            }
            catch (Exception ex)
            {
                try
                {
                    configFullPath = dirAlter + Path.DirectorySeparatorChar + fileName;
                    File.WriteAllText(configFullPath, result);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            return true;
        }



        public static bool ReadConfig()
        {
            configFullPath = dir + Path.DirectorySeparatorChar + fileName;
            if (!File.Exists(configFullPath))
            {
                configFullPath = dirAlter + Path.DirectorySeparatorChar + fileName;
                if (!File.Exists(configFullPath))
                {
                    configFullPath = dir + Path.DirectorySeparatorChar + fileName;
                    return false;
                }
            }
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                string text = File.ReadAllText(configFullPath);
                xmlDocument.LoadXml(text);
                //XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("UserConfig");


                XmlNode xmlNode = xmlDocument.GetElementsByTagName("UserConfig").Item(0);
                author = xmlNode.SelectSingleNode("Author").InnerText;
                directoryFiles = xmlNode.SelectSingleNode("DirectoryAutoLoad").InnerText;
                currentBookId = Convert.ToInt32(xmlNode.SelectSingleNode("CurrentBook").InnerText);
                currentBookName = xmlNode.SelectSingleNode("CurrentBookName").InnerText;
                formWidth = Convert.ToInt32(xmlNode.SelectSingleNode("FormWidth").InnerText);
                formHeight = Convert.ToInt32(xmlNode.SelectSingleNode("FormHeight").InnerText);
                tabIndexSection = Convert.ToInt32(xmlNode.SelectSingleNode("TabIndex").InnerText);

                XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("Book");
                int num = elementsByTagName.Count - 1;
                for (int i = 0; i <= num; i++)
                {
                    Library.BookList.Add(new Book(
                        Convert.ToInt32(elementsByTagName[i].SelectSingleNode("BookId").InnerText),
                        elementsByTagName[i].SelectSingleNode("BookName").InnerText,
                        elementsByTagName[i].SelectSingleNode("Title").InnerText,
                        elementsByTagName[i].SelectSingleNode("FullPath").InnerText,
                        elementsByTagName[i].SelectSingleNode("Author").InnerText,
                        elementsByTagName[i].SelectSingleNode("Page").InnerText,
                        Convert.ToInt32(elementsByTagName[i].SelectSingleNode("Order").InnerText),
                        Convert.ToInt32(elementsByTagName[i].SelectSingleNode("SheetCount").InnerText),
                        Convert.ToInt32(elementsByTagName[i].SelectSingleNode("Opened").InnerText),
                        Convert.ToDouble(elementsByTagName[i].SelectSingleNode("Updated").InnerText),
                        bool.Parse(elementsByTagName[i].SelectSingleNode("IsReadonly").InnerText),
                        bool.Parse(elementsByTagName[i].SelectSingleNode("IsCurrent").InnerText),
                        elementsByTagName[i].SelectSingleNode("History").InnerText
                        ));

                    if (bool.Parse(elementsByTagName[i].SelectSingleNode("IsCurrent").InnerText))
                    {
                        UserConfigOld.currentBookId = Convert.ToInt32(elementsByTagName[i].SelectSingleNode("BookId").InnerText);
                        UserConfigOld.currentBookName = elementsByTagName[i].SelectSingleNode("BookName").InnerText;
                        UserConfigOld.currentPage = elementsByTagName[i].SelectSingleNode("Page").InnerText;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }



        }

    }
}

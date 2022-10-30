using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TefTeleNote_WF.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TefTeleNote_WF.Transfer
{
    public static class BooksFilesUtils
    {
        private static string assetFolder = ".assets";

        // Load book list (iterrate throught directory)
        public static void LoadBooks()
        {
            Library.fileCollection.Clear();
            if (string.IsNullOrEmpty(UserConfig.folderShelf)) { return; }
            DirectoryInfo root = new DirectoryInfo(UserConfig.folderShelf);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    Console.WriteLine(fi.FullName);
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    for (int i = 0; i < 2; i++)
                    {

                    Library.fileCollection.Add(LoadBookFromDirectory(dirInfo));
                    }
                }
            }
        }

        private static BookFile LoadBookFromDirectory(DirectoryInfo dirInfo)
        {
            BookFile bf = new BookFile();
            try
            {
                System.IO.FileInfo[] files = null;
                DirectoryInfo assetFolder = new DirectoryInfo(Path.Combine(dirInfo.FullName, BooksFilesUtils.assetFolder));
                System.IO.DirectoryInfo[] subDirs = null;
                bf.directory = dirInfo.FullName;
                // First, process all the files directly under this folder
                try
                {
                    files = assetFolder.GetFiles("*.*");
                }
                // This is thrown if even one of the files requires permissions greater
                // than the application provides.
                catch (UnauthorizedAccessException e)
                {
                    MessageBox.Show(e.Message);
                }
                foreach (FileInfo fi in files)
                {
                    switch (fi.Name.ToString().ToLower())
                    {
                        case (BookFile.covername + ".jpg"):
                            bf.coverPath = fi.FullName;
                            break;
                        case (BookFile.covername + ".png"):
                            bf.coverPath = fi.FullName;
                            break;

                        case (BookFile.iconname + ".jpg"):
                            bf.iconPath = fi.FullName;
                            break;
                        case (BookFile.iconname + ".png"):
                            bf.iconPath = fi.FullName;
                            break;

                        case BookFile.manifestname:
                            bf.manifestPath = fi.FullName;
                            break;

                        case (BookFile.supercovername + ".jpg"):
                            bf.superCoverPath = fi.FullName;
                            break;
                        case (BookFile.supercovername + ".png"):
                            bf.superCoverPath = fi.FullName;
                            break;

                        case BookFile.templatename:
                            bf.templatPath = fi.FullName;
                            break;

                        case BookFile.stylename:
                            bf.stylePath = fi.FullName;
                            break;
                    }
                }
                if (!string.IsNullOrEmpty(bf.manifestPath))
                {
                    try
                    {
                        XmlDocument xmlDocument = new XmlDocument();
                        string text = File.ReadAllText(bf.manifestPath);
                        xmlDocument.LoadXml(text);
                        XmlNode xmlNode;
                        try
                        {
                            xmlNode = xmlDocument.GetElementsByTagName("author").Item(0);
                            if (xmlNode.SelectSingleNode("name") != null)
                            {
                                bf.author = xmlNode.SelectSingleNode("name").InnerText;
                            }
                            if (xmlNode.SelectSingleNode("langCode") != null)
                            {
                                bf.language = Convert.ToInt32( xmlNode.SelectSingleNode("langCode").InnerText);
                            }
                        }
                        catch (Exception excep1)
                        {
                            MessageBox.Show(excep1.Message);
                        }
                        try
                        {
                            xmlNode = xmlDocument.GetElementsByTagName("info").Item(0);
                            if (xmlNode.SelectSingleNode("id") != null)
                            {
                                bf.id = xmlNode.SelectSingleNode("id").InnerText;
                            }
                            if (xmlNode.SelectSingleNode("title") != null)
                            {
                                bf.titleName = xmlNode.SelectSingleNode("title").InnerText;
                            }
                            if (xmlNode.SelectSingleNode("description") != null)
                            {
                                bf.description = xmlNode.SelectSingleNode("description").InnerText;
                            }
                            if (xmlNode.SelectSingleNode("created") != null)
                            {
                                bf.created = Convert.ToDateTime(xmlNode.SelectSingleNode("created").InnerText);
                            }
                            if (xmlNode.SelectSingleNode("updated") != null)
                            {
                                bf.updated = Convert.ToDateTime(xmlNode.SelectSingleNode("updated").InnerText);
                            }
                            if (xmlNode.SelectSingleNode("lastopen") != null)
                            {
                                bf.lastopen = Convert.ToDateTime(xmlNode.SelectSingleNode("lastopen").InnerText);
                            }
                            if (xmlNode.SelectSingleNode("metaTitle") != null)
                            {
                                bf.meta_title = xmlNode.SelectSingleNode("metaTitle").InnerText;
                            }
                            if (xmlNode.SelectSingleNode("metaDescription") != null)
                            {
                                bf.meta_keys = xmlNode.SelectSingleNode("metaDescription").InnerText;
                            }
                        }
                        catch (Exception excep1)
                        {
                            MessageBox.Show(excep1.Message);
                        }
                        try
                        {
                            xmlNode = xmlDocument.GetElementsByTagName("statistics").Item(0);
                            if (xmlNode.SelectSingleNode("pages") != null)
                            {
                                bf.pageCount = Convert.ToInt32(xmlNode.SelectSingleNode("pages").InnerText);
                            }
                            if (xmlNode.SelectSingleNode("folders") != null)
                            {
                                bf.folderCount = Convert.ToInt32(xmlNode.SelectSingleNode("folders").InnerText);
                            }
                        }
                        catch (Exception excep2)
                        {
                            MessageBox.Show(excep2.Message);
                        }


                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    return bf;
                }


            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
            
        }

        static void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            // This is thrown if even one of the files requires permissions greater
            // than the application provides.
            catch (UnauthorizedAccessException e)
            {
                // This code just writes out the message and continues to recurse.
                // You may decide to do something different here. For example, you
                // can try to elevate your privileges and access the file again.
                //log.Add(e.Message);
                MessageBox.Show(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    // In this example, we only access the existing FileInfo object. If we
                    // want to open, delete or modify the file, then
                    // a try-catch block is required here to handle the case
                    // where the file has been deleted since the call to TraverseTree().
                    Console.WriteLine(fi.FullName);
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    WalkDirectoryTree(dirInfo);
                }
            }
        }


        public static string BuildBookManifest(BookFile bf)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            StringBuilder output = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(output, settings);
            xmlWriter.WriteStartElement("book");

            xmlWriter.WriteStartElement("author");
            xmlWriter.WriteStartElement("name");
            xmlWriter.WriteString(bf.author);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("langCode");
            xmlWriter.WriteString(Convert.ToString(bf.language));
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("info");
            xmlWriter.WriteStartElement("id");
            xmlWriter.WriteString(bf.id);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("title");
            xmlWriter.WriteString(bf.titleName);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("description");
            xmlWriter.WriteString(bf.description);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("created");
            xmlWriter.WriteString(bf.created.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("updated");
            xmlWriter.WriteString(bf.updated.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("lastopen");
            xmlWriter.WriteString(bf.lastopen.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("metaTitle");
            xmlWriter.WriteString(bf.meta_title.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("metaKeywords");
            xmlWriter.WriteString(bf.meta_keys.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("metaDescription");
            xmlWriter.WriteString(bf.meta_descr.ToString());
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("structure");
            xmlWriter.WriteStartElement("item");
            xmlWriter.WriteStartElement("id");
            xmlWriter.WriteString(Generators.ID.Generate(32));
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("type");
            xmlWriter.WriteString("1");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("name");
            xmlWriter.WriteString("blank");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("order");
            xmlWriter.WriteString("1");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("level");
            xmlWriter.WriteString("1");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("tabIndex");
            xmlWriter.WriteString("1");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("statistics");
            xmlWriter.WriteStartElement("pages");
            xmlWriter.WriteString(Convert.ToString(bf.pageCount));
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("folders");
            xmlWriter.WriteString(Convert.ToString(bf.folderCount));
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();
            xmlWriter.Close();

            return output.ToString();
        }

        public static BookFile GetBookById(string id)
        {
            foreach (var book in Library.fileCollection)
            {
                if (book.id == id)
                {
                    return book;
                }
            }
            return null;
        }
    }
}


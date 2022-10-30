using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TefTeleNote_WF.Data;
using TefTeleNote_WF.Operators;

namespace TefTeleNote_WF.Controllers
{
    public class WriteBook
    {
        public string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public string bookName = "Book.teff";
        //private ListType<Contents> coollect;
        private List<string> ROWS = new List<string>();
        private string headerLine = "";
        
        public WriteBook(List<Contents> collection, string header, string path = "", string bookName = "")
        {
            //this.coollect = collection;
            if (!string.IsNullOrEmpty(path))
            {
                this.path = path;
            }
            if (!string.IsNullOrEmpty(bookName))
            {
                this.bookName = bookName;
            }
            this.headerLine = header;

            ROWS.Add(header);
            foreach(Contents ln in collection)
            {
                ROWS.Add(ln.GetFormattedContentString());
            }
        }

        public bool WriteFile()
        {
            try
            {
                File.WriteAllText(path + Path.DirectorySeparatorChar + bookName, "");
                using (StreamWriter writer = new StreamWriter(path + Path.DirectorySeparatorChar + bookName, true)) //// true to append data to the file
                {
                    
                    foreach (string Line in ROWS)
                    {
                        writer.WriteLine(Line);
                    }
                }
            }
            catch (System.Exception exp)
            {
                return false;
            }

            return true;
        }
    }
}

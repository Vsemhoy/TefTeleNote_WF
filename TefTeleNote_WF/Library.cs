using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TefTeleNote_WF.Data;

namespace TefTeleNote_WF
{
    internal class Library
    {
        public static List<Book> BookList = new List<Book>();
        public static  List<Contents> collection = new List<Contents>();
        public static List<string> idCollection = new List<string>();

        public static List<BookFile> fileCollection = new List<BookFile>();
    }
}

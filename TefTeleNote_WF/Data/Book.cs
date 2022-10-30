using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Data
{
    public class Book
    {
        public int id { get; set; }
        public string bookName { get; set; }
        public string title { get; set; }
        public string folderPath { get; set; }
        public string author { get; set; }
        public string currentPage { get; set; }
        public int orderInList { get; set; }
        public int sheetCount { get; set; }
        public double openTime { get; set; }
        public double updateTime { get; set; }
        public bool isReadonly { get; set; }
        public bool isCurrent { get; set; }
        public string editHistory { get; set; }

        public Book(
            int id,
            string name,
            string title,
            string path,
            string author,
            string currentPage,
            int order,
            int sheets,
            double openTime,
            double updateTime, 
            bool onlyread,
            bool isCurrent,
            string editHistory)
        {
            this.id = id;
            this.bookName = name;
            this.title = title;
            this.folderPath = path;
            this.author = author;
            this.currentPage = currentPage;
            this.orderInList = order;
            this.sheetCount = sheets;
            this.openTime = openTime;
            this.updateTime = updateTime;
            this.isReadonly = onlyread;
            this.isCurrent = isCurrent;
            this.editHistory = editHistory;
        }
    }
}

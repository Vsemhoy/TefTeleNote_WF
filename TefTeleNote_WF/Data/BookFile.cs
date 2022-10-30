﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Data
{
    public class BookFile
    {
        public const string covername = "cover";
        public const string stylename = "style.css";
        public const string supercovername = "supercover";
        public const string iconname = "icon";
        public const string templatename = "template.html";
        public const string manifestname =  "info.xml";
        public const string fileFolderName = ".files";
        public const string defaultFileName = "blank.html";

        public string id { get; set; }
        public string titleName { get; set; }
        public string description { get; set; }
        public string directory { get; set; }
        public string author { get; set; }
        public string manifestPath { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public DateTime lastopen { get; set; }
        public int pageCount { get; set; }
        public int folderCount { get; set; }
        public string iconPath { get; set; }
        public string coverPath { get; set; }
        public string superCoverPath { get; set; }
        public string templatPath { get; set; }
        public string stylePath { get; set; }
        public string template { get; set; }

        public string categoryName { get; set; }
        public string meta_keys { get; set; }
        public string meta_descr { get; set; }
        public string meta_title { get; set; }
        public int language { get; set; }



        public BookFile()
        {
            this.id = Generators.ID.Generate();
            this.pageCount = 0;
            this.folderCount = 0;
            this.created = DateTime.Now;
            this.updated = DateTime.Now;
            this.author = string.Empty;
            this.coverPath = string.Empty;
            this.description = Generators.RandomText.generateRandomString(100);
            this.template = string.Empty;
            this.directory = string.Empty;
            this.iconPath = string.Empty;
            this.manifestPath = string.Empty;
            this.titleName = Generators.RandomText.generateRandomString(5);
            this.stylePath = string.Empty;
            this.superCoverPath = string.Empty;
            this.templatPath = string.Empty;
            this.template = string.Empty;

            this.categoryName = string.Empty;
            this.meta_descr = string.Empty;
            this.meta_keys = string.Empty;
            this.meta_title = string.Empty;
            this.language = 45;
        }
    }
}

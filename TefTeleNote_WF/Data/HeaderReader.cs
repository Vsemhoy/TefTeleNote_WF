using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Data
{
    public class HeaderReader
    {
        public static string StripSeparator = @"%\%";
        public string headerString { get; set; }
        public int ID { get; set; }
        public int NAME { get; set; }
        public int TYPE { get; set; }
        public int FORMAT { get; set; }
        public int ORDER { get; set; }
        public int LEVEL { get; set; }
        public int PARENT { get; set; }
        public int DESCRIPTION { get; set; }
        public int DATA { get; set; }
        public int TAGS { get; set; }
        public int VERSION { get; set; }
        public int DATEC { get; set; }
        public int DATEM { get; set; }
        public int AUTHOR { get; set; }
        public int VIEWS { get; set; }
        public int EDITS { get; set; }

        public HeaderReader(string inputHeader)
        {
            this.headerString = inputHeader;
            ExplodeString(this.headerString);
        }

        public void ExplodeString(string header)
        {
            string[] columns = header.Split(StripSeparator);
            int index  = 0;
            foreach (string col in columns)
            {
                if (!string.IsNullOrWhiteSpace(col))
                {
                    if (col.ToUpper() == "ID") { ID = index; }
                    if (col.ToUpper() == "NAME") { NAME = index; }
                    if (col.ToUpper() == "TYPE") { TYPE = index; }
                    if (col.ToUpper() == "FORMAT") { FORMAT = index; }
                    if (col.ToUpper() == "ORDER") { ORDER = index; }
                    if (col.ToUpper() == "LEVEL") { LEVEL = index; }
                    if (col.ToUpper() == "PARENT") { PARENT = index; }
                    if (col.ToUpper() == "DESCRIPTION") { DESCRIPTION = index; }
                    if (col.ToUpper() == "DATA") { DATA = index; }
                    if (col.ToUpper() == "TAGS") { TAGS = index; }
                    if (col.ToUpper() == "VERSION") { VERSION = index; }
                    if (col.ToUpper() == "DATEC") { DATEC = index; }
                    if (col.ToUpper() == "DATEM") { DATEM = index; }
                    if (col.ToUpper() == "VIEWS") { VIEWS = index; }
                    if (col.ToUpper() == "EDITS") { EDITS = index; }
                }
            index++;
            }
        }

        public static string GetFHeaderString()
        {
            string sep = HeaderReader.StripSeparator;

            string result = string.Empty;
            result += "ID" + sep;
            result += "NAME" + sep;
            result += "TYPE" + sep;
            result += "FORMAT" + sep;
            result += "ORDER" + sep;
            result += "LEVEL" + sep;
            result += "PARENT" + sep;
            result += "DESCRIPTION" + sep;
            result += "DATA" + sep;
            result += "TAGS" + sep;
            result += "VERSION" + sep;
            result += "DATEC" + sep;
            result += "DATEM" + sep;
            result += "AUTHOR" + sep;
            result += "EDITS" + sep;
            result += "VIEWS" + sep;

            return result.Trim();
        }
    }
}

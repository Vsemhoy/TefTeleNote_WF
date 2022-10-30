using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Data
{
    public class Contents
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Format { get; set; }
        public int Order { get; set; }
        public int Level { get; set; }
        public string Parent { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public string Tags { get; set; }
        public int Version { get; set; }
        public double DateC { get; set; }
        public double DateM { get; set; }
        public string Author { get; set; }
        public int Views { get; set; }
        public int Edits { get; set; }

        public Contents(string ID, int type, int format, int order)
        {
            this.Id = ID;
            this.Name = "NewItem";
            this.Type = type;
            this.Format = format;
            this.Order = order;
            this.Level = 1;
            this.Parent = "ROOT";
            this.Description = "";
            this.Data = "";
            this.Tags = "";
            this.Version = 0;
            this.Edits = 0;
            this.Views = 0;
            this.Author = "";
            this.DateC = 0.0;
            this.DateM = 0.0;
        }

        public Contents(string DataString, HeaderReader hread)
        {
            string sep = HeaderReader.StripSeparator;
            string[] stringArray = DataString.Split(sep);

            this.Id = stringArray[hread.ID];
            this.Name = ToSingleBackSlaches(stringArray[hread.NAME]);
            this.Type = Convert.ToInt32( stringArray[hread.TYPE]);
            this.Format = Convert.ToInt32(stringArray[hread.FORMAT]);
            this.Order = Convert.ToInt32(stringArray[hread.ORDER]);
            this.Level = Convert.ToInt32(stringArray[hread.LEVEL]);
            this.Parent = stringArray[hread.PARENT];
            this.Description = ToSingleBackSlaches(stringArray[hread.DESCRIPTION]);
            this.Data = ToSingleBackSlaches(stringArray[hread.DATA]);
            this.Tags = ToSingleBackSlaches(stringArray[hread.TAGS]);
            this.Version = Convert.ToInt32(stringArray[hread.VERSION]);
            this.DateC = Convert.ToDouble(stringArray[hread.DATEC]);
            this.DateM = Convert.ToDouble(stringArray[hread.DATEM]);
            this.Author = ToSingleBackSlaches(stringArray[hread.AUTHOR]);
            this.Edits = Convert.ToInt32(stringArray[hread.EDITS]);
            this.Views = Convert.ToInt32(stringArray[hread.VIEWS]);
        }

        public string GetFormattedContentString()
        {
            string sep = HeaderReader.StripSeparator;

            string result = string.Empty;
            result += this.Id.Trim() + sep;
            result += ToDoubleBackSlaches(this.Name) + sep;
            result += this.Type.ToString() + sep;
            result += this.Format.ToString() + sep;
            result += this.Order.ToString() + sep;
            result += this.Level.ToString() + sep;
            result += this.Parent.ToString() + sep;
            result += ToDoubleBackSlaches(this.Description) + sep;
            result += ToDoubleBackSlaches(this.Data) + sep;
            result += ToDoubleBackSlaches(this.Tags) + sep;
            result += this.Version.ToString() + sep;
            result += this.DateC.ToString() + sep;
            result += this.DateM.ToString() + sep;
            result += ToDoubleBackSlaches(this.Author) + sep;
            result += this.Edits.ToString() + sep;
            result += this.Views.ToString() + sep;

            return result.Trim();
        }

        public string ToDoubleBackSlaches(string value)
        {
            value = value.Trim();
            //value = value.Replace(@"\r\n", @"\\r\\n");
            string ReplacementString = @"<\/br\>";

            value = value.Replace(@"\", @"\\");
            value = Regex.Replace(value.Replace(System.Environment.NewLine, ReplacementString), @"(\r\n?|\n)", "");
           // value = value.Replace(System.Environment.NewLine, ReplacementString);

            return value;
        }        
        public string ToSingleBackSlaches(string value)
        {
            value = value.Trim();
            value = value.Replace( @"<\/br\>", System.Environment.NewLine);
            value = value.Replace(@"\\", @"\");
            return value;
        }

        public string SanitizeString(string value)
        {
            return new String(value.Where(Char.IsLetter).ToArray()).ToUpper();
        }
    }
}

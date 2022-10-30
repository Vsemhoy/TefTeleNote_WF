using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Templates
{
    public class HtmlTemplates
    {

        public string language;

        public HtmlTemplates(string language)
        {
            this.language = language;
        }

        public string GetBlankContent()
        {
            string result = string.Empty;
            result += "<h2>Hello World!</h2>";
            result += "<div>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</div>";
            return result;
        }

        public string GetHtmlTemplate()
        {
            string result = string.Empty;
            result += "<!DOCTYPE html>\r\n<html>\r\n  <head>\r\n    <meta charset='utf-8'>\r\n    <meta http-equiv='X-UA-Compatible' content='IE=edge'>\r\n    <title>%METATITLE%</title>\r\n    <meta name='viewport' content='width=device-width, initial-scale=1'>\r\n    <meta name='description' content='%METADESCRIPTION%'>\r\n    <meta name='keywords' content='%METAKEYWORDS%'>\r\n    <meta name='author' content='%METAAUTHOR%'>\r\n\r\n    <style>\r\n      %STYLECSS%\r\n    </style>\r\n  </head>\r\n  <body>\r\n    <div id='bookerContent' %CONTENTEDITABLE%>\r\n      %CONTENT%\r\n    </div>\r\n  </body>\r\n</html>";

            return result;
        }
    }
}

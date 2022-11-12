using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TefTeleNote_WF.Data;

namespace TefTeleNote_WF.Templates
{
    public class HtmlTemplates
    {
        private const string REPLACE_metadesc = "%METADESCRIPTION%";
        private const string REPLACE_metatitle = "%METATITLE%";
        private const string REPLACE_metakeys = "%METAKEYWORDS%";
        private const string REPLACE_metaauthor = "%METAAUTHOR%";
        private const string REPLACE_stylecss = "%STYLECSS%";
        private const string REPLACE_contenteditable = "%CONTENTEDITABLE%";
        private const string REPLACE_content = "%CONTENT%";
        private const string REPLACE_script = "%SCRIPT%";

        public int language;

        public HtmlTemplates(int language)
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

        public string GetScriptSection()
        {
            string result = "document.addEventListener('click',function(e){ console.log(0); " +
                "if (e.target && e.target.classList.contains('goto')){ " +
                " console.log(1); let string = e.target.getAttribute('goto');   " +
                " if (string != ''){ console.log(string); " +
                " window.chrome.webview.postMessage(string); };}; " +
                " });";
            return result;
        }

        public string GetHtmlTemplate()
        {
            string result = string.Empty;
            result += "<!DOCTYPE html>\r\n<html>\r\n  <head>\r\n    <meta charset='utf-8'>\r\n    <meta http-equiv='X-UA-Compatible' content='IE=edge'>\r\n    " +
                "<title>" + REPLACE_metatitle + "</title>\r\n    <meta name='viewport' content='width=device-width, initial-scale=1'>\r\n    " +
                "<meta name='description' content='" + REPLACE_metadesc + "'>\r\n    <meta name='keywords' content='" + REPLACE_metakeys + "'>\r\n    " +
                "<meta name='author' content='" + REPLACE_metaauthor + "'>\r\n\r\n    <style>\r\n      " + REPLACE_stylecss + "\r\n    </style>\r\n  </head>\r\n  " +
                "<body><section id='bookerContent' " + REPLACE_contenteditable + ">" + REPLACE_content + "</section>" + REPLACE_script + "</body></html>";

            return result;
        }


        public static string HtmlBuildHtmlPage(BookFile bf, ItemStructure item, string context, string scripts = "", bool contenteditable = false)
        {
            HtmlTemplates httl = new HtmlTemplates(bf.language);
            string tpl = httl.GetHtmlTemplate();

            string style = string.Empty;
            string stl = File.ReadAllText(bf.stylePath);
            if (!string.IsNullOrEmpty(stl))
            {
                style = stl;
            }
            if (!string.IsNullOrEmpty(scripts))
            {
                scripts = "<script>" + scripts + "</script>";
            }
            /// correct base style
            style = "\r\n   body { font-family: system-ui, -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;}" +
                "\r\n   #bookerContent:focus { outline: none; padding-bottom: 50vh;}" + style;
        string contentedit = string.Empty;
            if (contenteditable)
            {
                contentedit = "contenteditable=\"true\"";
            }

            tpl = tpl.Replace(REPLACE_metadesc, bf.meta_descr);
            tpl = tpl.Replace(REPLACE_script, scripts);
            tpl = tpl.Replace(REPLACE_content, context.Trim());
            tpl = tpl.Replace(REPLACE_metaauthor, bf.author);
            tpl = tpl.Replace(REPLACE_metakeys, bf.meta_keys);
            tpl = tpl.Replace(REPLACE_metatitle, bf.meta_title);
            tpl = tpl.Replace(REPLACE_stylecss, style);
            tpl = tpl.Replace(REPLACE_contenteditable, contentedit);

            return tpl;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Data
{
    public class Language
    {
        public static List<Language> languageList = new List<Language>();
        public string name { get; set; }
        public string literals { get; set; }
        public string nativeName { get; set; }
        public int code { get; set; }

        public string iso639_1 { get; set; }
        public string iso639_2 { get; set; }
        public string iso639_3 { get; set; }


        public static List<Language> GetLanguageList()
        {
            if (languageList.Count == 0)
            {
                FillLanguageList();
                return languageList;
            }
            return languageList;
        }

        private static void FillLanguageList()
        {
            Language lan = new Language();
            lan.name = "Englis";
            lan.literals = "EN";
            lan.nativeName = "English";
            lan.code = 45;
            lan.iso639_1 = "eng";
            lan.iso639_2 = "eng";
            lan.iso639_3 = "eng";
            languageList.Add(lan);

            lan = new Language();
            lan.name = "Spanish";
            lan.literals = "ES";
            lan.nativeName = "Español";
            lan.code = 230;
            lan.iso639_1 = "esl/spa";
            lan.iso639_2 = "spa";
            lan.iso639_3 = "esl/spa";
            languageList.Add(lan);

            lan = new Language();
            lan.name = "Chinese";
            lan.literals = "ZH";
            lan.nativeName = "普通话";
            lan.code = 315;
            lan.iso639_1 = "chi/zho";
            lan.iso639_2 = "zho";
            lan.iso639_3 = "chi/zho";
            languageList.Add(lan);

            lan = new Language();
            lan.name = "Russian";
            lan.literals = "RU";
            lan.nativeName = "Русский";
            lan.code = 570;
            lan.iso639_1 = "rus";
            lan.iso639_2 = "rus";
            lan.iso639_3 = "rus";
            languageList.Add(lan);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Generators
{
    public static class ID
    {
        public const string CharsNdigits = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYuZz0123456789";
        public const string CharsNdigits_Caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public const string CharsNdigits_Small = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public const string Chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYuZz";
        public const string Chars_Caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string Chars_Small = "abcdefghijklmnopqrstuvwxuz";
        public const string Digits = "0123456789";
        public const string SpecialChars = "!@#$%^&*/?";
        public const string Root = "ROOT";

        private const int defaultLength = 12;

        public static string Generate()
        {
            int length = defaultLength;
            string symbols = CharsNdigits;
            string result = GenerateIdenter(length, symbols);
            return result;
        }

        public static string Generate(int length)
        {
            string symbols = CharsNdigits;
            string result = GenerateIdenter(length, symbols);
            return result;
        }

        public static string Generate(string symbols)
        {
            int length = defaultLength;
            string result = GenerateIdenter(length, symbols);
            return result;
        }

        public static string Generate(int length, string symbols)
        {
            string result = GenerateIdenter(length, symbols);
            return result;
        }

        private static string GenerateIdenter(int length, string symbols)
        {
            if (length == 0)
            {
                return "EMPTY_LENGTH!";
            }
            if (length > 127)
            {
                return "TOO_LONG_LEN(" + length.ToString() + ")!";
            }
            if (string.IsNullOrEmpty(symbols))
            {
                symbols = CharsNdigits;
            }

            char[] chars = symbols.ToCharArray();
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                Random random = new Random();
                int index = random.Next(chars.Length);
                result[i] = chars[index];
            }
            string resultstring = new string(result);
            return resultstring;
        }
    }
}

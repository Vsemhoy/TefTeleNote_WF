using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Generators
{
    public class ThemeInfo
    {
        private readonly string _themeName;
        private readonly string _themeColor;
        private readonly string _themeSize;
        private readonly string _themeFileName;

        public ThemeInfo(string name, string fileName, string color, string size)
        {
            _themeName = name;
            _themeFileName = fileName;
            _themeColor = color;
            _themeSize = size;
        }

        public string ThemeFileName
        {
            get { return _themeFileName; }
        }

        public string ThemeName
        {
            get { return _themeName; }
        }

        public string ThemeColor
        {
            get { return _themeColor; }
        }

        public string ThemeSize
        {
            get { return _themeSize; }
        }

        public static ThemeInfo Current
        {
            get
            {
                var fileName = new StringBuilder(260);
                var color = new StringBuilder(260);
                var size = new StringBuilder(260);
                int hresult = GetCurrentThemeName(fileName, fileName.Capacity, color, color.Capacity, size, size.Capacity);
                if (hresult < 0)
                    throw Marshal.GetExceptionForHR(hresult);
                string themeName = Path.GetFileNameWithoutExtension(fileName.ToString());
                return new ThemeInfo(themeName, fileName.ToString(), color.ToString(), size.ToString());
            }
        }

        [DllImport("uxtheme", CharSet = CharSet.Auto)]
        private static extern int GetCurrentThemeName(
        StringBuilder pszThemeFileName,
        int dwMaxNameChars,
        StringBuilder pszColorBuff,
        int cchMaxColorChars,
        StringBuilder pszSizeBuff,
        int cchMaxSizeChars
        );
    }
}

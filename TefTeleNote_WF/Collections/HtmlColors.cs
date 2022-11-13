using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TefTeleNote_WF.Collections
{
    public class HtmlColors
    {
        public static List<HtmlColors> colors = new List<HtmlColors>();

        int id { get; set; }
        public string htmlName { get; set; }
        public string htmlColor { get; set; }
        public string textColor { get; set; }
        public Color color { get; set; }
        public Color foreColor { get; set; }


        public HtmlColors(string name, string colorname, string textColor, Color colr, Color forec)
        {
           this.id = colors.Count;
           this.htmlName = name;
           this.color = colr;
           this.htmlColor = colorname;
            this.textColor = textColor;
            this.foreColor = forec;
        }
        

       

        public static List<HtmlColors> FillColors()
        {
            HtmlColors.colors.Clear();
                HtmlColors.colors.Add(new HtmlColors("LemonChiffon", "LemonChiffon", "Black", Color.LemonChiffon, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Mocassin", "mocassin", "Black", Color.Moccasin, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Khaki", "khaki", "Black", Color.Khaki, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Yellow", "Yellow", "Black", Color.Yellow, Color.Black));
                HtmlColors.colors.Add(new HtmlColors("Gold", "gold", "Black", Color.Gold, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Orange", "orange", "Black", Color.Orange, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("SandyBrown", "sandybrown", "Black", Color.SandyBrown, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("LightSalmon", "LightSalmon", "Black", Color.LightSalmon, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Tomato", "tomato", "Black", Color.Tomato, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("OrangeRed", "orangered", "white", Color.OrangeRed, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("Salmon", "salmon", "Black", Color.Salmon, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Red", "red", "white", Color.Red, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("Crimson", "crimson", "white", Color.Crimson, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("Brown", "brown", "white", Color.Brown, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("Maroon", "maroon", "white", Color.Maroon, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("RosyBrown", "rosybrown", "Black", Color.RosyBrown, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("MistyRose", "mistyrose", "Black", Color.MistyRose, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Pink", "pink", "Black", Color.Pink, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("PaleVioletRed", "PaleVioletRed", "white", Color.PaleVioletRed, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("MediumVioletRed", "MediumVioletRed", "white", Color.MediumVioletRed, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("DeepPink", "DeepPink", "white", Color.DeepPink, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("HotPink", "HotPink", "Black", Color.HotPink, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Violet", "Violet", "Black", Color.Violet, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("MediumOrchid", "MediumOrchid", "Black", Color.MediumOrchid, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Purple", "Purple", "white", Color.Purple, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("Indigo", "Indigo", "white", Color.Indigo, Color.White));
                HtmlColors.colors.Add(new HtmlColors("DarkSlateBlue", "DarkSlateBlue", "white", Color.DarkSlateBlue, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("MediumPurple", "MediumPurple", "white", Color.MediumPurple, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("MediumSlateBlue", "MediumSlateBlue", "white", Color.MediumSlateBlue, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("SteelBlue", "SteelBlue", "white", Color.SteelBlue, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("LightSkyBlue", "LightSkyBlue", "Black", Color.LightSkyBlue, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("DodgerBlue", "DodgerBlue", "white", Color.DodgerBlue, Color.White));
                HtmlColors.colors.Add(new HtmlColors("Blue", "Blue", "white", Color.Blue, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("MidnightBlue", "MidnightBlue", "white", Color.MidnightBlue, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("CadetBlue", "CadetBlue", "white", Color.CadetBlue, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("MediumTurquoise", "MediumTurquoise", "Black", Color.MediumTurquoise, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Aqua", "Aqua", "Black", Color.Aqua, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Aquamarine", "Aquamarine", "Black", Color.Aquamarine, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("MediumSpringGreen", "MediumSpringGreen", "Black", Color.MediumSpringGreen, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Green", "Green", "white", Color.Green, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("GreenYellow", "GreenYellow", "Black", Color.GreenYellow, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("YellowGreen", "YellowGreen", "Black", Color.YellowGreen, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("MediumAquamarine", "MediumAquamarine", "Black", Color.MediumAquamarine, Color.Black ));

                HtmlColors.colors.Add(new HtmlColors("LightGreen", "LightGreen", "Black", Color.LightGreen, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("PaleTurquoise", "PaleTurquoise", "Black", Color.PaleTurquoise, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("PowderBlue", "PowderBlue", "Black", Color.PowderBlue, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Gainsboro", "Gainsboro", "Black", Color.Gainsboro, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Silver", "Silver", "Black", Color.Silver, Color.Black ));
                HtmlColors.colors.Add(new HtmlColors("Gray", "Gray", "white", Color.Gray, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("DimGray", "DimGray", "White", Color.DimGray, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("DarkSlateGray", "DarkSlateGray", "white", Color.DarkSlateGray, Color.White ));
                HtmlColors.colors.Add(new HtmlColors("Black", "Black", "white", Color.Black, Color.White ));
            
            return HtmlColors.colors;
        }
    }




}

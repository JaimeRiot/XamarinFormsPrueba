using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace APIPrueba.UIForms.CustomRender
{
    public class FontAwesomeLabel : Label
    {
        public static readonly string FontAwesomeName = "FontAwesome5Solid";

        public FontAwesomeLabel()
        {
            FontFamily = FontAwesomeName;
        }

        public FontAwesomeLabel(string fontAwesomeLabel = null)
        {
            FontFamily = FontAwesomeName;
            Text = fontAwesomeLabel;
        }
    }

    public static class Icon
    {
        public static readonly string FAGlass = "\uf000";
    }
}

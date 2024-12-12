using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace kursa4
{
    internal class TextElement:IFormulaElement
    {
        string text;
        public TextElement(string value)
        {
            text = value;
        }
        public void Paint(Graphics g, ref float x, float y)
        {
            g.DrawString(text.ToString(), SystemFonts.DefaultFont, Brushes.Black, x, y);
                x += 6;
        }
        public override string ToString()
        {
                return text.ToString();
        }

    }
}
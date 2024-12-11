using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class TextElement:IFormulaElement
    {
        string text;
        public TextElement(string value)
        {
            text = value;
        }
        public void Paint(Graphics g, ref int x, int y)
        {
            g.DrawString(text.ToString(), SystemFonts.DefaultFont, Brushes.Black, x, y);
                x += 5;
        }
        public override string ToString()
        {
                return text.ToString();
        }

    }
}
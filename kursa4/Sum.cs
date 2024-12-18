using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class Sum : FormulaElement,IFormulaElement
    {
        string text, up, i;
        NewFormula forma;
        public Sum(NewFormula form, string Text,string Up,string I) : base(form)
        {
            text = Text;
            up = Up;
            i = I;
            forma = form;
        }
        public override void Draw(object sender, buttonEventArgs e)
        {
            e.el.Add(new Sum(forma, text, up, i));
        }
        public void Paint(Graphics g, ref float x, float y)
        {
            var lowerLimitSize = g.MeasureString(i, SystemFonts.DefaultFont);
            var upperLimitSize = g.MeasureString(up, SystemFonts.DefaultFont);
            var sumContentSize = g.MeasureString(text, SystemFonts.DefaultFont);

            float sumWidth = 20;

            g.DrawString(up, SystemFonts.DefaultFont, Brushes.Black, x + sumWidth / 2 - upperLimitSize.Width / 2, y-15);

            using (Font symbolFont = new Font("Arial", 16, FontStyle.Bold))
            {
                g.DrawString("Σ", symbolFont, Brushes.Black, x, y-5);
            }

            g.DrawString($"i = {i}", SystemFonts.DefaultFont, Brushes.Black, x + sumWidth / 2 - lowerLimitSize.Width / 2, y + upperLimitSize.Height );

            g.DrawString(text, SystemFonts.DefaultFont, Brushes.Black, x + sumWidth, y);

            x += sumWidth + sumContentSize.Width;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class Sqrt : FormulaElement, IFormulaElement
    {
        string text, step;
        NewFormula forma;
        public SizeF u, d;
        public Sqrt(NewFormula form, string Text, string Step) : base(form)
        {
            text = Text;
            step = Step;
        }
        public override void Draw(object sender, buttonEventArgs e)
        {
            e.el.Add(new Sqrt(forma, text, step));
        }
        public void Paint(Graphics g, ref float x, float y)
        {
            u = g.MeasureString(step, SystemFonts.DefaultFont);
            d = g.MeasureString(text, SystemFonts.DefaultFont);
            float rootWidth = d.Width + (string.IsNullOrEmpty(step) ? 10 : u.Width + 5) + 10;
            float rootHeight = d.Height + 2;
            x += u.Width /2 -15;
            if (!string.IsNullOrEmpty(step))
            {
                g.DrawString(step, SystemFonts.DefaultFont, Brushes.Black, x, y - u.Height / 2 -2);
                x += u.Width - 15;
            }

            g.DrawLine(Pens.Black, x+4, y + rootHeight / 2 -5, x + 8, y + 12);
            g.DrawLine(Pens.Black, x + 9, y + 12, x + 16, y-2);

            g.DrawLine(Pens.Black, x + 17, y-2, x + 10 + d.Width + 5, y-2);

            g.DrawString(text, SystemFonts.DefaultFont, Brushes.Black, x + 15, y);

            x += 42;
        }
    }
}

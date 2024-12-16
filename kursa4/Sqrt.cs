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
        float length;
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
            length = Math.Max(u.Width, d.Width);
            float numx = x + (length - u.Width) / 2;
            float denomx = x + (length - d.Width) / 2;
            g.DrawString(Numerator.ToString(), SystemFonts.DefaultFont, Brushes.Black, numx + 2, y - 10);
            g.DrawLine(Pens.Black, x + 5, y + 6, x + length, y + 6);
            g.DrawString(Denominator.ToString(), SystemFonts.DefaultFont, Brushes.Black, denomx + 3, y + 10);
            x += length + 2;
        }
    }
}

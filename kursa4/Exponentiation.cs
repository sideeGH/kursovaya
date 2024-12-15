using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class Exponentiation : FormulaElement, IFormulaElement
    {
        string text,exp;
        NewFormula forma;
        public Exponentiation(NewFormula form, string Text,string Exp) : base(form)
        {
            forma = form;
            text = Text;
            exp = Exp;
        }
        public override void Draw(object sender, buttonEventArgs e)
        {
            e.el.Add(new Exponentiation(forma, text, exp));
        }
        public void Paint(Graphics g, ref float x, float y)
        {
            g.DrawString("(", SystemFonts.DefaultFont, Brushes.Black, x, y);
            x += 6;
            foreach (char c in text)
            {
                g.DrawString(c.ToString(), SystemFonts.DefaultFont, Brushes.Black, x, y);
                x += 6;
            }
            g.DrawString(")", SystemFonts.DefaultFont, Brushes.Black, x, y);
            x += 3;
            foreach (char c in exp)
            {
                g.DrawString(c.ToString(), SystemFonts.DefaultFont, Brushes.Black, x, y-5);
                x += 6;
            }
            x += 3;
        }
    }
}

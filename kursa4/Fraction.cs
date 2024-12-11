using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class Fraction : FormulaElement,IFormulaElement
    {
        public string Numerator { get; set; }
        public SizeF u, d;
        float length;

        public string Denominator { get; set; }
        public Fraction(NewFormula form, string up,string down) : base(form) 
        {
            Numerator = up;
            Denominator = down;
        }
        public override void Draw(object sender, buttonEventArgs e)
        {
            //if (e.gr != null)
            //{
                //u = e.gr.MeasureString(Numerator, SystemFonts.DefaultFont);
                //d = e.gr.MeasureString(Denominator, SystemFonts.DefaultFont);
                //length = Math.Max(u.Width, d.Width);
            //}
        }
        public void Paint(Graphics g, ref int x, int y)
        {
            float numx = x + (length - u.Width) / 2;
            float denomx = x + (length - d.Width) / 2;
            g.DrawString(Numerator.ToString(), SystemFonts.DefaultFont, Brushes.Black, numx+2, y-10);
            g.DrawLine(Pens.Black, x+5, y+6, x+length, y+6);
            g.DrawString(Denominator.ToString(), SystemFonts.DefaultFont, Brushes.Black, denomx+3, y+10);
        }
    }
}
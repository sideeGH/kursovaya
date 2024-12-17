using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class Brackets :FormulaElement
    {
        string bracket;
        public Brackets(NewFormula form,string Bracket) : base(form)
        {
            bracket = Bracket;
        }
        public override void Draw(object sender, buttonEventArgs e)
        {
            try
            {
                e.el.Add(new TextElement("("));
                foreach (char c in bracket)
                {
                    e.el.Add(new TextElement(c.ToString()));
                }
                e.el.Add(new TextElement(")"));
            }
            catch (NullReferenceException)
            {
            }
        }
    }
}
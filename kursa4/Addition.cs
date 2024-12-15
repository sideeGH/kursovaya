using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class Addition : FormulaElement
    {
        string first,second;
        public Addition(NewFormula form, string First,string Second) : base(form)
        {
            first = First;
            second = Second;
        }
        public override void Draw(object sender, buttonEventArgs e)
        {
            e.el.Add(new TextElement("("));
            foreach (char c in first)
            {
                e.el.Add(new TextElement(c.ToString()));
            }
            e.el.Add(new TextElement("+"));
            foreach (char c in second)
            {
                e.el.Add(new TextElement(c.ToString()));
            }
            e.el.Add(new TextElement(")"));
        }
    }
}

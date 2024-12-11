using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class Brackets :FormulaElement
    {
        public Brackets(NewFormula form):base(form) { }
        public override void Draw(object sender, buttonEventArgs e)
        {
            var right = e.el[^1].ToString();
            e.el.RemoveAt(e.el.Count - 1);
            var op = e.el[^1].ToString();
            e.el.RemoveAt(e.el.Count - 1);
            var left = e.el[^1].ToString();
            e.el.RemoveAt(e.el.Count - 1);
            e.el.Add(new TextElement("("));
            e.el.Add(new TextElement(left));
            e.el.Add(new TextElement(op));
            e.el.Add(new TextElement(right));
            e.el.Add(new TextElement(")"));
        }
    }
}
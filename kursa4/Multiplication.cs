using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class Multiplication: FormulaElement
    {
        string first, second;
        public Multiplication(NewFormula form, string First, string Second) : base(form)
        {
            first = First;
            second = Second;
        }
        public override void Draw(object sender, buttonEventArgs e)
        {
            bool f1 = false;
            bool f2 = false;
            e.el.Add(new TextElement("("));
            foreach (char c in first)
            {
                if (c == '+' || c == '-' || c == '/' || c == '*')
                    f1 = true;
            }
            if (f1)
            {
                e.el.Add(new TextElement("("));
                foreach (char c in first)
                {
                    e.el.Add(new TextElement(c.ToString()));
                }
                e.el.Add(new TextElement(")"));
            }
            else
                foreach (char c in first)
                    e.el.Add(new TextElement(c.ToString()));
            e.el.Add(new TextElement("*"));
            foreach (char c in second)
            {
                if (c == '+' || c == '-' || c == '/' || c == '*')
                    f2 = true;
            }
            if (f2)
            {
                e.el.Add(new TextElement("("));
                foreach (char c in second)
                {
                    e.el.Add(new TextElement(c.ToString()));
                }
                e.el.Add(new TextElement(")"));
            }
            else
                foreach (char c in second)
                    e.el.Add(new TextElement(c.ToString()));
            e.el.Add(new TextElement(")"));
        }
    }
}

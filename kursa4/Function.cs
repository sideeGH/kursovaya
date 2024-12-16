using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class Function : FormulaElement
    {
        string text;
        public Function(NewFormula form, string Text) : base(form)
        {
            text = Text;
        }
        public override void Draw(object sender, buttonEventArgs e)
        {
            foreach (char c in text)
                e.el.Add(new TextElement(c.ToString()));
        }
    }
}

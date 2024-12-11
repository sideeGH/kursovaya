using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal abstract class FormulaElement
    {
        private NewFormula formula;
        public FormulaElement(NewFormula formula)
        {
            this.formula = formula;
        }
        public void On()
        {
            formula.buttonEvent += new buttonEventHandler(Draw);
        }
        public void Off()
        {
            formula.buttonEvent -= new buttonEventHandler(Draw);
            formula = null;
        }
        public abstract void Draw(object sender,buttonEventArgs e);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class buttonEventArgs:EventArgs
    {
        public int buttonInd
        {
            get;
        }
        public List<IFormulaElement> el
        {
            get;set;
        }
        public buttonEventArgs(int buttonind, List<IFormulaElement> element)
        {
            buttonInd = buttonind;
            el = element;
        }
    }
}

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
        public Graphics g
        {
            get;
        }
        public List<IFormulaElement> el
        {
            get;set;
        }
        public buttonEventArgs(int buttonind, Graphics g, List<IFormulaElement> element)
        {
            buttonInd = buttonind;
            g = g;
            el = element;
        }
    }
}

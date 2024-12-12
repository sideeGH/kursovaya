using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class buttonEventArgs:EventArgs
    {
        public List<IFormulaElement> el
        {
            get;set;
        }
        public buttonEventArgs(List<IFormulaElement> element)
        {
            el = element;
        }
    }
}

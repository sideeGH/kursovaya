using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace kursa4
{
    internal delegate void buttonEventHandler(object sender, buttonEventArgs e);
    internal class NewFormula
    {
        public int buttonInd;
        private Brackets brack;
        private Fraction fr;
        public string up, down;
        public event buttonEventHandler buttonEvent;
        List<IFormulaElement> el;
        public NewFormula(string buttonInd, List<IFormulaElement> element,string up,string down)
        {
            el= element;
            fr = new Fraction(this, up,down);
            fr.On();
        }
        public NewFormula(string buttonInd, List<IFormulaElement> element, string bracket)
        {
            el = element;
            brack = new Brackets(this, bracket);
            brack.On();
        }
        protected virtual void Onformula(buttonEventArgs e)
        {
            if (buttonEvent != null)
            {
                buttonEvent(this, e);
            }
        }
        public void Chance()
        {
            buttonEventArgs e = new buttonEventArgs(buttonInd,el);
            Onformula(e);
        }
    }
}

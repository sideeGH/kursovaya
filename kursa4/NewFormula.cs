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
        private Brackets brack;
        private Fraction fr;
        private Addition ad;
        private Division di;
        private Subtraction sub;
        private Multiplication mul;
        private Exponentiation exp;
        private Function func;
        private Sqrt sqrt;
        private Sum sum;
        public event buttonEventHandler buttonEvent;
        List<IFormulaElement> el;
        public NewFormula(string buttonInd, List<IFormulaElement> element,string up,string down)
        {
            el= element;
            switch(buttonInd)
            {
                case "2":
                    fr = new Fraction(this, up, down);
                    fr.On();
                    break;
                case "3":
                    ad = new Addition(this, up, down);
                    ad.On();
                    break;
                case "4":
                    di = new Division(this, up, down);
                    di.On();
                    break;
                case "5":
                    sub = new Subtraction(this, up, down);
                    sub.On();
                    break;
                case "6":
                    mul = new Multiplication(this, up, down);
                    mul.On();
                    break;
                case "7":
                    exp = new Exponentiation(this, up, down);
                    exp.On();
                    break;
                case "10":
                    sqrt = new Sqrt(this, up, down);
                    sqrt.On();
                    break;
                default:
                    break;
            }
        }
        public NewFormula(string buttonInd, List<IFormulaElement> element,string text)
        {
            el = element;
            switch(buttonInd)
            {
                case "1":
                    brack = new Brackets(this, text);
                    brack.On();
                    break;
                case "8":
                    func = new Function(this, text);
                    func.On();
                    break;
                default:
                    break;
            }
        }
        public NewFormula(List<IFormulaElement> element, string up, string i,string text)
        {
            el = element;
            sum = new Sum(this, text, up, i);
            sum.On();
            
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
            buttonEventArgs e = new buttonEventArgs(el);
            Onformula(e);
        }
    }
}

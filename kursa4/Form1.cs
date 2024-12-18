﻿using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kursa4
{
    public partial class Form1 : Form
    {
        private List<IFormulaElement> elements = new List<IFormulaElement>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BracketsForm form = new BracketsForm();
            form.ShowDialog();
            if (form.brackets() != null)
            {
                NewFormula formula = new NewFormula("1", elements, form.brackets());
                formula.Chance();
                panel1.Invalidate();
            }
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                float x = 10, y = 50;
                foreach (var element in elements)
                {
                    if (x > 750)
                        throw new WarningException();
                    element.Paint(e.Graphics, ref x, y);
                }
            }
            catch (WarningException)
            {
                MessageBox.Show("Формула слишком большая");
                elements.Clear();
                panel1.Invalidate();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            FractionForm form = new FractionForm();
            form.ShowDialog();
            if (form.num() != null)
            {
                NewFormula formula = new NewFormula("2", elements, form.num(), form.denum());
                formula.Chance();
                panel1.Invalidate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (char c in textBox1.Text)
            {
                elements.Add(new TextElement(c.ToString()));
            }
            panel1.Invalidate();
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                elements.RemoveAt(elements.Count - 1);
                panel1.Invalidate();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string ind = clickedButton.Name[^1].ToString();
            if (ind == "5")
                elements.Add(new TextElement("("));
            else if (ind == "6")
                elements.Add(new TextElement(")"));
            else if (ind == "3")
                elements.Add(new TextElement("+"));
            else if (ind == "4")
                elements.Add(new TextElement("/"));
            else if (ind == "1")
                elements.Add(new TextElement("-"));
            else if (ind == "2")
                elements.Add(new TextElement("*"));
            else if (ind == "9")
                elements.Add(new TextElement("α"));
            else if (ind == "0")
                elements.Add(new TextElement("β"));
            panel1.Invalidate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdditionForm form = new AdditionForm();
            form.ShowDialog();
            if (form.num() != null)
            {
                NewFormula formula = new NewFormula("3", elements, form.num(), form.denum());
                formula.Chance();
                panel1.Invalidate();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SubtractionForm form = new SubtractionForm();
            form.ShowDialog();
            if (form.num() != null)
            {
                NewFormula formula = new NewFormula("5", elements, form.num(), form.denum());
                formula.Chance();
                panel1.Invalidate();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DivisionForm form = new DivisionForm();
            form.ShowDialog();
            if (form.num() != null)
            {
                NewFormula formula = new NewFormula("4", elements, form.num(), form.denum());
                formula.Chance();
                panel1.Invalidate();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MultiplicationForm form = new MultiplicationForm();
            form.ShowDialog();
            if (form.num() != null)
            {
                NewFormula formula = new NewFormula("6", elements, form.num(), form.denum());
                formula.Chance();
                panel1.Invalidate();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ExponentiationForm form = new ExponentiationForm();
            form.ShowDialog();
            if (form.num() != null)
            {
                NewFormula formula = new NewFormula("7", elements, form.num(), form.denum());
                formula.Chance();
                panel1.Invalidate();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FunctionForm form = new FunctionForm();
            form.ShowDialog();
            if (form.num() != null)
            {
                NewFormula formula = new NewFormula("8", elements, form.num());
                formula.Chance();
                panel1.Invalidate();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            elements.Clear();
            panel1.Invalidate();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SqrtForm form = new SqrtForm();
            form.ShowDialog();
            if (form.num() != null)
            {
                NewFormula formula = new NewFormula("10", elements, form.num(), form.denum());
                formula.Chance();
                panel1.Invalidate();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            SumForm form = new SumForm();
            form.ShowDialog();
            if (form.num() != null)
            {
                NewFormula formula = new NewFormula(elements, form.num(), form.denum(), form.ednum());
                formula.Chance();
                panel1.Invalidate();
            }
        }
    }
}
using System.Windows.Forms;
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
        bool flag = false;
        private void AddOperationButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string ind = clickedButton.Name[^1].ToString();
            //NewFormula form = new NewFormula(ind, elements);
            //form.Chance();
            textBox1.Clear();
            flag = true;
            //textBox1.Text = string.Join("", elements.Select(e => e.ToString()));
            flag = false;
            panel1.Invalidate();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            int x = 10, y = 50;
            foreach (var element in elements)
            {
                element.Paint(e.Graphics, ref x, y);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    elements.Clear();
                    foreach (char c in textBox1.Text)
                    {
                        elements.Add(new TextElement(c.ToString()));
                    }
                    panel1.Invalidate();
                }
            }
            else
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FractionForm form = new FractionForm();
            form.ShowDialog();
            string up = form.num();
            string down = form.denum();
            NewFormula formula = new NewFormula("2", elements, form.num(),form.denum());
            formula.Chance();
            flag = true;
            textBox1.Text += $"({up})/({down})";
            flag = false;
            panel1.Invalidate();
        }
    }
}
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
        private void AddOperationButton_Click(object sender, EventArgs e)
        {
            BracketsForm form = new BracketsForm();
            form.ShowDialog();
            Button clickedButton = sender as Button;
            string ind = clickedButton.Name[^1].ToString();
            NewFormula formula = new NewFormula("1", elements, "1", "1", form.brackets());
            formula.Chance();
            panel1.Invalidate();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            float x = 10, y = 50;
            foreach (var element in elements)
            {
                element.Paint(e.Graphics, ref x, y);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            FractionForm form = new FractionForm();
            form.ShowDialog();
            NewFormula formula = new NewFormula("2", elements, form.num(), form.denum(), "1");
            formula.Chance();
            panel1.Invalidate();
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
            elements.RemoveAt(elements.Count - 1);
            panel1.Invalidate();
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
            panel1.Invalidate();
        }
    }
}
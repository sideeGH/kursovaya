using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursa4
{
    public partial class BracketsForm : Form
    {
        public BracketsForm()
        {
            InitializeComponent();
        }
        private void FractionForm_Load(object sender, EventArgs e)
        {
        }
        string bracket;
        private void button1_Click(object sender, EventArgs e)
        {
            bracket = textBox1.Text;
            this.Close();
        }
        public string brackets()
        {
            return bracket;
        }
    }
}

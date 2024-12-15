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
    public partial class SubtractionForm : Form
    {
        public SubtractionForm()
        {
            InitializeComponent();
        }
        string first,second;
        private void button1_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            second = textBox2.Text;
            this.Close();
        }
        public string num()
        {
            return first;
        }
        public string denum()
        {
            return second;
        }
    }
}

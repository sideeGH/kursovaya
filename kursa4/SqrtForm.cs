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
    public partial class SqrtForm : Form
    {
        public SqrtForm()
        {
            InitializeComponent();
        }
        string text,step;
        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            step = textBox2.Text;
            this.Close();
        }
        public string num()
        {
            return text;
        }
        public string denum()
        {
            return step;
        }
    }
}

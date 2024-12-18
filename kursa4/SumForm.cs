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
    public partial class SumForm : Form
    {
        public SumForm()
        {
            InitializeComponent();
        }
        string i, text, up;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                up = textBox1.Text;
                if (up.Length > 5)
                    throw new OverflowException();
                i = textBox2.Text;
                text = textBox3.Text;
                if (up == "" || i == "" || text == "")
                    throw new WarningException();
                this.Close();
            }
            catch(WarningException)
            {
                up = null;
                i = null;
                text = null;
                MessageBox.Show("Не введены все значения");
            }
            catch(OverflowException)
            {
                up = null;
                i = null;
                text = null;
                MessageBox.Show("Верхняя граница слишком большая");
            }
        }
        public string num()
        {
            return up;
        }
        public string denum()
        {
            return i;
        }
        public string ednum()
        {
            return text;
        }
    }
}

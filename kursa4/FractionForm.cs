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
    public partial class FractionForm : Form
    {
        public FractionForm()
        {
            InitializeComponent();
        }
        private void FractionForm_Load(object sender, EventArgs e)
        {
        }
        string up, down;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                up = textBox1.Text;
                down = textBox2.Text;
                if(up == "" || down == "")
                {
                    throw new WarningException();
                }
                this.Close();
            }
            catch(WarningException)
            {
                MessageBox.Show("Ошибка. Не введено два значения");
                up = null;
                down = null;
            }
        }
        public string num()
        {
            return up;
        }
        public string denum()
        {
            return down;
        }
    }
}

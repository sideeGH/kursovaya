using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursa4
{
    public partial class ExponentiationForm : Form
    {
        public ExponentiationForm()
        {
            InitializeComponent();
        }
        string text, exp;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                text = textBox1.Text;
                exp = textBox2.Text;
                if (text == "" || exp == "")
                {
                    throw new WarningException();
                }
                this.Close();
            }
            catch (WarningException)
            {
                text = null;
                exp = null;
                MessageBox.Show("Ошибка. Не введено два значения");
            }
        }
        public string num()
        {
            return text;
        }
        public string denum()
        {
            return exp;
        }
    }
}

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

namespace kursa4
{
    public partial class FunctionForm : Form
    {
        public FunctionForm()
        {
            InitializeComponent();
        }
        string text;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                text = textBox1.Text;
                if (text == "")
                {
                    throw new WarningException();
                }
                this.Close();
            }
            catch (WarningException)
            {
                text = null;
                MessageBox.Show("Ошибка. Не введено значение");
            }
        }
        public string num()
        {
            if (text != null)
            {
                if (radioButton2.Checked)
                {
                    return $"log({text})";
                }
                else if (radioButton3.Checked)
                {
                    return $"ln({text})";
                }
                else if (radioButton4.Checked)
                {
                    return $"sin({text})";
                }
                else if (radioButton5.Checked)
                {
                    return $"cos({text})";
                }
                else if (radioButton6.Checked)
                {
                    return $"tg({text})";
                }
                else if (radioButton7.Checked)
                {
                    return $"ctg({text})";
                }
                else if (radioButton8.Checked)
                {
                    return $"arcsin({text})";
                }
                else if (radioButton9.Checked)
                {
                    return $"arccos({text})";
                }
                else if (radioButton10.Checked)
                {
                    return $"arctg({text})";
                }
                else if (radioButton11.Checked)
                {
                    return $"arcctg({text})";
                }
            }
            return null;
        }
    }
}

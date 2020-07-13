 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    //Максимов Дмитрий

    //Создайте простую форму на которой свяжите свойство Text элемента TextBox 
    //со свойством Value элемента NumericUpDown
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(textBox1.Text, "[^0-9]"))
                {
                    MessageBox.Show("Только цифры", Text, MessageBoxButtons.OK);
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    textBox1.SelectionStart = textBox1.TextLength;
                }
                else if (textBox1.Text == "") textBox1.Text = "";

                else numericUpDown1.Value = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Превышено максимальное число",Text, MessageBoxButtons.OK);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.SelectionStart = textBox1.TextLength;
            }
        }
    }
}

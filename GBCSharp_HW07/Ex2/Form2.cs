using System;
using System.Windows.Forms;

namespace Ex2
{
    //Максимов Дмитрий

    //Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
    //a) Для ввода данных от человека используется элемент TextBox;
    //б) ** Реализовать отдельную форму c TextBox для ввода числа.
    public partial class Form2 : Form
    {
        int count = 0;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            f.Opacity = 0.4;
            answerLbl.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            countLbl.Text = count.ToString();
            Form1.userCH = Convert.ToInt32(textBox1.Text);
            answerLbl.Text = Form1.userCH < Form1.ch ? "Бери выше" : "Переборщил";
            if (Form1.userCH == Form1.ch)
            {
                answerLbl.Text = "ПОБЕДА";
            }
        }
    }
}


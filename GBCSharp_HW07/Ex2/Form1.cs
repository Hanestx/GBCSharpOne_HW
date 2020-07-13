using System;
using System.Windows.Forms;

namespace Ex2
{
    //Максимов Дмитрий

    //Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.
    //a) Для ввода данных от человека используется элемент TextBox;
    //б) ** Реализовать отдельную форму c TextBox для ввода числа.

    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        public static int userCH = 0;
        public static int ch = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ch = rnd.Next(1, 100);
            Form2 newForm = new Form2(this);
            newForm.Show();
        }
    }
}

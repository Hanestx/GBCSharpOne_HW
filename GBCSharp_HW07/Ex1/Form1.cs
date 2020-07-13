using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    //Максимов Дмитрий

    //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
    //в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
    public partial class Form1 : Form
    {
        int count = 0;
        int ch = 1;
        static Random rnd = new Random();
        Stack<int> undo = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
            btnPlus.Text = "+1";
            btnX2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
            menuBG.BringToFront();
            Play.BringToFront();
            exit.BringToFront();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            count++;
            labelCount.Text = count.ToString();
            undo.Push(int.Parse(lblNumber.Text));
            if (int.Parse(lblNumber.Text) == ch) MessageBox.Show("Ты выйграл", "", MessageBoxButtons.OK);
        }
        private void btnX2_Click_1(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            count++;
            labelCount.Text = count.ToString();
            undo.Push(int.Parse(lblNumber.Text));
            if (int.Parse(lblNumber.Text) == ch) MessageBox.Show("Ты выйграл", "", MessageBoxButtons.OK);
        }
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            count = 0;
            labelCount.Text = count.ToString();
        }
        private void Play_Click(object sender, EventArgs e)
        {
            ch = rnd.Next(1, 200);
            DialogResult result = MessageBox.Show("Вы должны получить число: " + ch + "\nза минимальное число ходов", "Условия", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Play.Visible = false;
                menuBG.Visible = false;
                exit.Visible = false;
                randomLabel.Text = ch.ToString();
            }
            else this.TopMost = true;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void menuBG_Click(object sender, EventArgs e)
        {

        }
        async private void btnUndo_Click_1(object sender, EventArgs e)
        {
            try
            {
                int undoes = undo.Pop();
                lblNumber.Text = undoes.ToString();
                btnUndo.Enabled = false;
                await Task.Delay(300);
                btnUndo.Enabled = true;
            }
            catch (Exception){ MessageBox.Show("Отменять нечего", "Ошибка", MessageBoxButtons.OK); }          
        }

    }
}

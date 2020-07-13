using Ex3;
using System;
using System.IO;
using System.Windows.Forms;

namespace Ex3
{
    // Максимов Дмитрий

    //а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
    //б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
    //в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
    //г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).

    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null) database.SaveAs();
            else MessageBox.Show("База данных не создана");
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            try
            {
                database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
            }
            catch { MessageBox.Show("База данных не загружена", Text, MessageBoxButtons.OK); }
        }
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            }
            catch { MessageBox.Show("База данных не загружена",Text, MessageBoxButtons.OK); }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = "Автор: Максимов Дмитрий\n" + "email: hanestx@yandex.ru\n" + "v.1.01";
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
            label2.Text = "";
        }
    }

}

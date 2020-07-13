using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    //Максимов Дмитрий

    //Используя полученные знания и класс TrueFalse в качестве шаблона, 
    //разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
    public partial class StartForm : Form
    {
        MyBase database;

        public StartForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            nudNumber.Visible = false;
            textBoxEng.Visible = false;
            textBoxRus.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            btnSave.Visible = false;
            btnClose.Visible = false;
            btnSaveMenu.Visible = false;
            btnMenu.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new MyBase(sfd.FileName);
                database.Add("Cat", "Кот");
                database.Save();
                btnCreate.Hide();
                btnOpen.Hide();
                btnExit.Hide();
                label1.Hide();

                panel1.Visible = true;
                nudNumber.Visible = true;
                textBoxEng.Visible = true;
                textBoxRus.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                btnSave.Visible = true;
                btnClose.Visible = true;
                btnSaveMenu.Visible = true;
                btnMenu.Visible = true;
                btnAdd.Visible = true;
                btnDelete.Visible = true;

                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new MyBase(ofd.FileName);
                database.Load();

                btnCreate.Hide();
                btnOpen.Hide();
                btnExit.Hide();
                label1.Hide();

                panel1.Visible = true;
                nudNumber.Visible = true;
                textBoxEng.Visible = true;
                textBoxRus.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                btnSave.Visible = true;
                btnClose.Visible = true;
                btnSaveMenu.Visible = true;
                btnMenu.Visible = true;
                btnAdd.Visible = true;
                btnDelete.Visible = true;

                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnCreate.Show();
            btnOpen.Show();
            btnExit.Show();
            label1.Show();

            panel1.Visible = false;
            nudNumber.Visible = false;
            textBoxEng.Visible = false;
            textBoxRus.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            btnSave.Visible = false;
            btnClose.Visible = false;
            btnSaveMenu.Visible = false;
            btnMenu.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                database[(int)nudNumber.Value - 1].word = textBoxEng.Text;
                database[(int)nudNumber.Value - 1].translate = textBoxRus.Text;
            }
            catch { MessageBox.Show("База данных не загружена", Text, MessageBoxButtons.OK); }
        }
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxEng.Text = database[(int)nudNumber.Value - 1].word;
                textBoxRus.Text = database[(int)nudNumber.Value - 1].translate;
            }
            catch { MessageBox.Show("База данных не загружена", Text, MessageBoxButtons.OK); }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value-1);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value-1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add("", "");
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}


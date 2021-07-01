using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    public partial class Form1 : Form
    {
        TrueFalse database;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".dbq";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName+".dbq");
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                nudNumber.Value = 0;
                return;
            }
            try
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Подробности: {ex.Message}", "Данный вопрос отсутствует");
            }
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
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }
        
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "dbq files (*.dbq)|*.dbq";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            try
            {
                database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show($"Подробности: {ex.Message}", "Откройте или создайте файл с вопросами");
            }
        }

        private void imAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Кирилл\nВсе права защищены\nВерсия 1.0", "О программе");
        }

        private void imSaveAs_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            if(database == null)
            {
                database = new TrueFalse(saveFileDialog1.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                database.FileName = saveFileDialog1.FileName;
                database.Save();
                MessageBox.Show("Файл сохранен");
            }
        }
    }
}

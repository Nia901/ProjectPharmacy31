using Controller;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Form12 : Form
    {
        SpecialistsController specialistsController = new SpecialistsController();
        QuestionsController questionController = new QuestionsController();
        public Form12(string username)
        {
            InitializeComponent();
            comboBox1.DataSource = null;
            comboBox1.DataSource = specialistsController.GetAll();
            comboBox1.DisplayMember = "FirstName";
            Username = username;
        }
        public string Username { get; set; }
        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Specialists s = comboBox1.SelectedItem as Specialists;
                string description = textBox1.Text;
                DateTime date = dateTimePicker1.Value;
                await questionController.CreateQuestions(Username, s.FirstName, s.LastName, description, date);
                MessageBox.Show("Успешно направихте запитване!");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.Hide();
                MessageBox.Show(ex.Message);
                this.Show();
            }

        }

        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}

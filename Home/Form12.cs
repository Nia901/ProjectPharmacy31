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
        QuestionsController questionsController = new QuestionsController();
        public Form12(string username)
        {
            InitializeComponent();
            Username = username;
        }
        public string Username { get; set; }

        private async void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            string[] input = textBox2.Text.Split(' ');
            string description = textBox1.Text;
            DateTime date = dateTimePicker1.Value;
            await questionsController.CreateQuestions(this.Username, input[0], input[1], description, date);
            MessageBox.Show("Успешно създадохте запитване!");
            DialogResult = DialogResult.OK;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}

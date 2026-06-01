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
    public partial class Form7 : Form
    {
        SpecialistsController specialistController = new SpecialistsController();
        QuestionsController questionsController = new QuestionsController();
        public Form7(string username, string password)
        {
            InitializeComponent();
            Username = username;
            Password = password;
        }
        public string Username { get; set; }
        public string Password { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            this.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = await specialistController.GetAll();
            dataGridView1.Visible = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = await questionsController.GetAllBySpec(Username, Password);
            dataGridView1.Visible = true;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting2;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Customer" && e.Value != null)
            {
                if (e.Value is Customer categoryObject)
                {
                    e.Value = categoryObject.Username;
                    e.FormattingApplied = true;
                }
            }
        }
        private void dataGridView1_CellFormatting2(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Specialist" && e.Value != null)
            {
                if (e.Value is Specialists categoryObject)
                {
                    e.Value = categoryObject.Username;
                    e.FormattingApplied = true;
                }
            }
        }
        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using Controller;
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
    public partial class Form6 : Form
    {
        private ProductController productController = new ProductController();
        private QuestionsController questionsController = new QuestionsController();
        private OrderController ordersController = new OrderController();
        public Form6(string username, string password)
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

        private void Form6_Load(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderSize = 0;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = await productController.GetAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = await ordersController.GetByCustomers(Username, Password);
            dataGridView1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 form11 = new Form11(Username);
            this.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (checkBox1.Checked)
            {
                dataGridView1.Rows.Add(await productController.GetProductsForBaby());
            }
            if (checkBox2.Checked)
            {
                dataGridView1.Rows.Add(await productController.GetProductsForWomen());
            }
            if (checkBox3.Checked)
            {
                dataGridView1.Rows.Add(await productController.GetProductsForMen());
            }
            if (checkBox4.Checked)
            {
                dataGridView1.Rows.Add(await productController.GetProductsForChildren());
            }
            if (checkBox5.Checked)
            {
                dataGridView1.Rows.Add(await productController.GetProductsForElders());
            }
            dataGridView1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form12 = new Form12(Username);
            this.Show();
        }

        private async void button6_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = await questionsController.GetAllByCustomer(Username, Password);
            dataGridView1.Visible = true;
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}

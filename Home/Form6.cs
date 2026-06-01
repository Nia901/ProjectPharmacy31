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
    public partial class Form6 : Form
    {
        private ProductController productController = new ProductController();
        private QuestionsController questionsController = new QuestionsController();
        private OrderController ordersController = new OrderController();
        private CustomerController customerController = new CustomerController();
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
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
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
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = await ordersController.GetByCustomers(Username, Password);
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Product" && e.Value != null)
            {
                if (e.Value is Product categoryObject)
                {
                    e.Value = categoryObject.Name;
                    e.FormattingApplied = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 form11 = new Form11(Username);
            form11.ShowDialog();
            this.Show();
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            var masterProductList = new List<Product>();

            if (checkBox1.Checked)
            {
                var products = await productController.GetProductsForBaby();
                if (products != null && products.Count > 0) masterProductList.AddRange(products);
            }

            if (checkBox2.Checked)
            {
                var products = await productController.GetProductsForWomen();
                if (products != null && products.Count > 0) masterProductList.AddRange(products);
            }

            if (checkBox3.Checked)
            {
                var products = await productController.GetProductsForMen();
                if (products != null && products.Count > 0) masterProductList.AddRange(products);
            }

            if (checkBox4.Checked)
            {
                var products = await productController.GetProductsForChildren();
                if (products != null && products.Count > 0) masterProductList.AddRange(products);
            }

            if (checkBox5.Checked)
            {
                var products = await productController.GetProductsForElders();
                if (products != null && products.Count > 0) masterProductList.AddRange(products);
            }

            var bindingList = new System.ComponentModel.BindingList<Product>(masterProductList);
            dataGridView1.DataSource = bindingList;

            dataGridView1.Visible = true;
        }
        private async void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form12 = new Form12(this.Username);
            form12.ShowDialog();
            this.Show();
        }

        private async void button6_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = await questionsController.GetAllByCustomer(Username, Password);
            dataGridView1.Visible = true;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting3;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting4;
        }
        private void dataGridView1_CellFormatting3(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.RowIndex < 0) return;
            string propertyName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            if (propertyName == "Customer" && e.Value != null)
            {
                if (e.Value is Customer categoryObject)
                {
                    e.Value = categoryObject.Username;
                    e.FormattingApplied = true;
                }
            }
        }
        private void dataGridView1_CellFormatting4(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.RowIndex < 0) return;
            string propertyName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            if (propertyName == "Specialist" && e.Value != null)
            {
                if (e.Value is Specialists categoryObject)
                {
                    e.Value = categoryObject.FirstName;
                    e.FormattingApplied = true;
                }
            }
        }
        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}

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
    public partial class Form11 : Form
    {
        ProductController productController = new ProductController();
        OrderController orderController = new OrderController();
        public Form11(string username)
        {
            InitializeComponent();
            comboBox1.DataSource = null;
            comboBox1.DataSource = productController.GetAll();
            comboBox1.DisplayMember = "Name";
            Username = username;
        }
        public string Username { get; set; }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = comboBox1.SelectedItem as Product;
                int quantity = (int)numericUpDown1.Value;
                await orderController.CreateOrder(Username, p.Name, DateTime.Now, quantity);
                this.Hide();
                MessageBox.Show("Успешно направихте поръчка");
                this.Show();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.Hide();
                MessageBox.Show(ex.Message);
                this.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}

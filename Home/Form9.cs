using Controller;
using Data.Entities;
using Data.Enums;
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
    public partial class Form9 : Form
    {
        ProductController productController = new ProductController();
        public Form9()
        {
            InitializeComponent();
            comboBox1.Items.Add("Мъже");
            comboBox1.Items.Add("Жени");
            comboBox1.Items.Add("Деца");
            comboBox1.Items.Add("Бебета");
            comboBox1.Items.Add("Възрастни");
        }
        public Form9(int quantity)
        {
            InitializeComponent();
            Quantity = quantity;
        }
        public int Quantity { get; set; }

        private async void button1_Click(object sender, EventArgs e)
        {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                numericUpDown1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                comboBox1.Visible = true;
                try
                {
                    string name = textBox1.Text;
                    string brand = textBox2.Text;
                    Categories categories = new Categories();
                    if (comboBox1.SelectedItem.ToString() == "Жени")
                    {
                        categories = Categories.Women;
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Мъже")
                    {
                        categories = Categories.Men;
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Деца")
                    {
                        categories = Categories.Children;
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Бебета")
                    {
                        categories = Categories.Babies;
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Възрастни")
                    {
                        categories = Categories.Elders;
                    }
                    string type = textBox3.Text;
                    decimal price = decimal.Parse(textBox4.Text);
                    int quantity = (int)numericUpDown1.Value;
                    await productController.CreateProduct(name, brand, categories, type, price, quantity);
                    MessageBox.Show("Успешно добавихте нов продукт!");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    this.Hide();
                    MessageBox.Show(ex.Message);
                    this.Show();
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}

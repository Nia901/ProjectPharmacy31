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
    public partial class Form3 : Form
    {
        private CustomerController customerController = new CustomerController();
        public Form3()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            string username = textBox4.Text;
            string password = textBox3.Text;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                this.Hide();
                MessageBox.Show("Моля, въведете години!");
                this.Show();
            }
            else
            {
                int age = int.Parse(textBox1.Text);
                try
                {
                    await customerController.CreateCustomer(username,password, email, age);
                MessageBox.Show("Успешна регистрация!");
                        DialogResult = DialogResult.OK;
            }
                catch (Exception ex)
                {
                this.Hide();
                MessageBox.Show(ex.Message);
                this.Show();
            }
        }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}

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
    public partial class Form2 : Form
    {
        AdminController adminController = new AdminController();
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastName = textBox2.Text;
            string email = textBox3.Text;
            string username = textBox5.Text;
            string password = textBox4.Text;
            try
            {
                await adminController.CreateAdmin(name, lastName, email, username, password);
                
                MessageBox.Show("Успешна регистрация!");
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
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

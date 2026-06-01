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
    public partial class Form8 : Form
    {
        CustomerController customerController = new CustomerController();
        public Form8(bool isForSearch)
        {
            InitializeComponent();
            if (isForSearch)
            {
                button2.Visible = true;
            }
            else
            {
                button1.Visible = true;
                textBox2.Visible = true;
                label2.Visible = true;
            }

        }
        private async void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            try
            {

                dataGridView1.Visible = true;
                dataGridView1.DataSource = await customerController.GetByEmail(email);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            try
            {
                await customerController.RemoveCustomer(email, password);
                MessageBox.Show("Успешно изтрихте клиент!");
                DialogResult=DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }
    }
}

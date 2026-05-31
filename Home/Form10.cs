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
    public partial class Form10 : Form
    {
        AdminController adminController = new AdminController();
        CustomerController customerController = new CustomerController();
        public Form10()
        {
            InitializeComponent();
            comboBox1.Items.Add("Администратор");
            comboBox1.Items.Add("Клиент");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            try
            {
                if (comboBox1.SelectedItem.ToString() == "Администратор")
                    await adminController.DeleteAdmin(username, password);
                else if (comboBox1.SelectedItem.ToString() == "Клиент")
                    await customerController.RemoveCustomer(username, password);
                else
                    throw new ArgumentException("Моля, изберете роля!");
                this.Hide();
                MessageBox.Show("Успешно изтрихте акаунта си!");
                this.Show();
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
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}

using Controller;
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
    public partial class Form4 : Form
    {
        SpecialistsController specialistsController = new SpecialistsController();
        public Form4()
        {
            InitializeComponent();
            comboBox1.Items.Add("Дерматолог");
            comboBox1.Items.Add("Педиатър");
            comboBox1.Items.Add("Кардиолог");
            comboBox1.Items.Add("Ендокринолог");
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    this.Hide();
                    MessageBox.Show("Моля, изберете роля!");
                    this.Show();
                }
                else
                {
                    string firstName = textBox1.Text;
                    string lastName = textBox2.Text;
                    string username = textBox3.Text;
                    string password = textBox4.Text;
                    ProfessionalFields proField = new ProfessionalFields();
                    if (comboBox1.SelectedItem.ToString() == "Кардиолог")
                    {
                        proField = ProfessionalFields.Cardiologist;
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Дерматолог")
                    {
                        proField = ProfessionalFields.Dermatologist;
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Ендокринолог")
                    {
                        proField = ProfessionalFields.Endocrinologist;
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Педиатър")
                    {
                        proField = ProfessionalFields.Pediatrician;
                    }
                    await specialistsController.CreateSpecialist(firstName, lastName, proField, username,password);
                    MessageBox.Show("Успешна регистрация!");
                    DialogResult = DialogResult.OK;
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}

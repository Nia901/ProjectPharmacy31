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
    public partial class Form13 : Form
    {
        ProductController productController = new ProductController();
        public Form13()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string brand = textBox2.Text;
                int quantity = (int)numericUpDown1.Value;
                await productController.ChanngeQuantity(name, brand, quantity);
                MessageBox.Show("Успешно променихте количеството на продукта!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

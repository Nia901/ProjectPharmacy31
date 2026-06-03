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
    public partial class Form5 : Form
    {
        private AdminController adminController = new AdminController();
        private CustomerController customerController = new CustomerController();
        private ProductController productController = new ProductController();
        private OrderController orderController = new OrderController();
        private SpecialistsController specialistController = new SpecialistsController();
        public Form5()
        {
            InitializeComponent();
            foreach (var item in tabControl1.TabPages)
            {
                TabPagess.Add((TabPage)item);
            }
            tabControl1.TabPages.Clear();
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
        public List<TabPage> TabPagess { get; set; } = new List<TabPage>();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(TabPagess[0]);
            dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(TabPagess[1]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(TabPagess[2]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(TabPagess[3]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(TabPagess[4]);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private async void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = await adminController.GetAll();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = await customerController.GetAll();
            dataGridView1.CellFormatting += dataGridView2_CellFormatting;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(true);
            this.Hide();
            form8.ShowDialog();
            this.Show();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Password")
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
                e.FormattingApplied = true;
            }
        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Password")
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
                e.FormattingApplied = true;
            }
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            dataGridView3.Visible = true;
            dataGridView3.DataSource = await productController.GetAll();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            this.Hide();
            form13.ShowDialog();
            this.Show();
        }

        private async void button15_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = await orderController.GetAll();
            dataGridView4.CellFormatting += dataGridView4_CellFormatting;
            dataGridView4.CellFormatting += dataGridView4_CellFormatting2;
        }
        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex].Name == "Customer" && e.Value != null)
            {
                if (e.Value is Customer categoryObject)
                {
                    e.Value = categoryObject.Username;
                    e.FormattingApplied = true;
                }
            }
        }
        private void dataGridView4_CellFormatting2(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView4.Columns[e.ColumnIndex].Name == "Product" && e.Value != null)
            {
                if (e.Value is Product categoryObject)
                {
                    e.Value = categoryObject.Name;
                    e.FormattingApplied = true;
                }
            }
        }
        private async void button16_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = await specialistController.GetAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.ShowDialog();
            this.Show();
            DialogResult = DialogResult.OK;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form9 = new Form9();
            form9.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(false);
            this.Hide();
            form8.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

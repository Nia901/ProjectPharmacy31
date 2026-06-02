using Controller;
using Data;
using Data.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace Home
{
    public partial class Form1 : Form
    {
        private AdminController adminController = new AdminController();
        private CustomerController customerController = new CustomerController();
        private SpecialistsController specialistController = new SpecialistsController();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Администратор");
            comboBox1.Items.Add("Клиент");
            comboBox1.Items.Add("Специалист");
        }
        public User1 CurrentUser { get; set; }
        public static bool WasPessed { get; set; } = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                    if (comboBox1.SelectedItem.ToString() == "Администратор")
                    {

                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.ShowDialog();
                        this.Show();
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Клиент")
                    {
                        this.Hide();
                        Form3 form3 = new Form3();

                        form3.ShowDialog();
                        this.Show();
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Специалист")
                    {
                        Form4 form4 = new Form4();
                        this.Hide();
                        form4.ShowDialog();
                        this.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
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
                else if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    this.Hide();
                    MessageBox.Show("Моля, въведете коректно потрбителско име!");
                    this.Show();
                }
                else if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    this.Hide();
                    MessageBox.Show("Моля, въведете коретна парола!");
                    this.Show();
                }
                else
                {
                    if (comboBox1.SelectedItem.ToString() == "Администратор")
                    {
                        if (await adminController.Login(textBox1.Text, textBox2.Text))
                        {
                            this.Hide();
                            Form5 form5 = new Form5();
                            form5.ShowDialog();
                            if (form5.DialogResult == DialogResult.OK)
                            {
                                this.Show();
                                form5.Close();
                            }
                        }
                        else
                        {
                            this.Hide();
                            MessageBox.Show("Неправилно потребителско име/парола!");
                            this.Show();
                        }
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Клиент")
                    {
                        if (await customerController.Login(textBox1.Text, textBox2.Text))
                        {
                            this.Hide();
                            Form6 form6 = new Form6(textBox1.Text, textBox2.Text);
                            form6.ShowDialog();
                            if (form6.DialogResult == DialogResult.OK)
                            {
                                this.Show();
                                form6.Close();
                            }
                        }
                        else
                        {
                            this.Hide();
                            MessageBox.Show("Неправилно потребителско име/парола!");
                            this.Show();
                        }
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Специалист")
                    {
                        if (await specialistController.Login(textBox1.Text, textBox2.Text))
                        {
                            if (await specialistController.Login(textBox1.Text, textBox2.Text))
                            {
                                this.Hide();
                                Form7 form7 = new Form7(textBox1.Text, textBox2.Text);
                                form7.ShowDialog();
                                if (form7.DialogResult == DialogResult.OK)
                                {
                                    this.Show();
                                    form7.Close();
                                }
                            }
                            else
                            {
                                this.Hide();
                                MessageBox.Show("Неправилно потребителско име/парола!");
                                this.Show();
                            }
                        }
                        else
                        {
                            this.Hide();
                            MessageBox.Show("Моля изберете роля!");
                            this.Show();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WasPessed)
                MessageBox.Show("Записите са вече въведени!");
            else
            {
                string json = File.ReadAllText("DataSource/AdminsSource.json");
                string json1 = File.ReadAllText("DataSource/CustomersSource.json");
                string json2 = File.ReadAllText("DataSource/ProductsSource.json");
                string json3 = File.ReadAllText("DataSource/SpecialistsSource.json");
                var users = JsonConvert.DeserializeObject<List<Admin>>(json);
                var users1 = JsonConvert.DeserializeObject<List<Customer>>(json1);
                var users2 = JsonConvert.DeserializeObject<List<Product>>(json2);
                var users3 = JsonConvert.DeserializeObject<List<Specialists>>(json3);
                PharmecyContext db = new PharmecyContext();
                db.Admins.AddRange(users);
                db.Customers.AddRange(users1);
                db.Products.AddRange(users2);
                db.Spetialists.AddRange(users3);
                db.SaveChanges();
                MessageBox.Show("Бяха въведени записи в таблиците!");
            }
           
        }
    }
}

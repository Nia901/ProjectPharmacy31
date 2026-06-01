namespace Home
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            button8 = new Button();
            tabPage2 = new TabPage();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            tabPage4 = new TabPage();
            button15 = new Button();
            dataGridView4 = new DataGridView();
            tabPage5 = new TabPage();
            button16 = new Button();
            dataGridView5 = new DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-16, 520);
            button1.Name = "button1";
            button1.Size = new Size(278, 46);
            button1.TabIndex = 0;
            button1.Text = "Отказ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Font = new Font("Sitka Banner Semibold", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 579);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(-16, 165);
            button7.Name = "button7";
            button7.Size = new Size(278, 47);
            button7.TabIndex = 0;
            button7.Text = "Изтрий своя акаунт";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(-16, 218);
            button6.Name = "button6";
            button6.Size = new Size(278, 57);
            button6.TabIndex = 5;
            button6.Text = "Специалисти";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(-16, 281);
            button5.Name = "button5";
            button5.Size = new Size(278, 58);
            button5.TabIndex = 4;
            button5.Text = "Поръчки";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(-16, 345);
            button4.Name = "button4";
            button4.Size = new Size(278, 52);
            button4.TabIndex = 3;
            button4.Text = "Продукти";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(-16, 403);
            button3.Name = "button3";
            button3.Size = new Size(278, 53);
            button3.TabIndex = 2;
            button3.Text = "Клиенти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(-16, 462);
            button2.Name = "button2";
            button2.Size = new Size(278, 52);
            button2.TabIndex = 1;
            button2.Text = "Администратори";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Font = new Font("Sitka Banner Semibold", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(247, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(741, 579);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.images1;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button8);
            tabPage1.Location = new Point(4, 42);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(738, 533);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Admins";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(577, 257);
            dataGridView1.TabIndex = 1;
            // 
            // button8
            // 
            button8.Location = new Point(263, 389);
            button8.Name = "button8";
            button8.Size = new Size(255, 45);
            button8.TabIndex = 0;
            button8.Text = "Покажи всички администратори";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.images1;
            tabPage2.Controls.Add(button11);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 42);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(738, 533);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(515, 397);
            button11.Name = "button11";
            button11.Size = new Size(185, 43);
            button11.TabIndex = 3;
            button11.Text = "Изтрий клиент";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(293, 397);
            button10.Name = "button10";
            button10.Size = new Size(185, 43);
            button10.TabIndex = 2;
            button10.Text = "Търси клиент по имейл";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(61, 397);
            button9.Name = "button9";
            button9.Size = new Size(185, 43);
            button9.TabIndex = 1;
            button9.Text = "Покажи всички клиенти";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(150, 75);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(487, 262);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.images1;
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(button14);
            tabPage3.Controls.Add(button13);
            tabPage3.Controls.Add(button12);
            tabPage3.Location = new Point(4, 42);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(738, 533);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Products";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(157, 80);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(493, 245);
            dataGridView3.TabIndex = 3;
            // 
            // button14
            // 
            button14.Location = new Point(514, 390);
            button14.Name = "button14";
            button14.Size = new Size(154, 52);
            button14.TabIndex = 2;
            button14.Text = "Добави количество на продукт";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.Location = new Point(315, 390);
            button13.Name = "button13";
            button13.Size = new Size(154, 52);
            button13.TabIndex = 1;
            button13.Text = "Изведи всички продукти";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(123, 390);
            button12.Name = "button12";
            button12.Size = new Size(154, 52);
            button12.TabIndex = 0;
            button12.Text = "Създай продукт";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = Properties.Resources.images1;
            tabPage4.Controls.Add(button15);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 42);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(738, 533);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Orders";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(333, 420);
            button15.Name = "button15";
            button15.Size = new Size(148, 54);
            button15.TabIndex = 1;
            button15.Text = "Покажи всички поръчки";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(150, 86);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(490, 269);
            dataGridView4.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = Properties.Resources.images1;
            tabPage5.Controls.Add(button16);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Location = new Point(4, 42);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(733, 533);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Specialists";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(324, 436);
            button16.Name = "button16";
            button16.Size = new Size(168, 54);
            button16.TabIndex = 1;
            button16.Text = "Покажи всички специалист";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(114, 97);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(520, 273);
            dataGridView5.TabIndex = 0;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 578);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Administrator Page";
            FormClosed += Form5_FormClosed;
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button7;
        private DataGridView dataGridView1;
        private Button button8;
        private DataGridView dataGridView2;
        private Button button11;
        private Button button10;
        private Button button9;
        private DataGridView dataGridView3;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button15;
        private DataGridView dataGridView4;
        private Button button16;
        private DataGridView dataGridView5;
    }
}
namespace Home
{
    partial class Form9
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Име";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Марка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 127);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Категория";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 177);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Тип на продукт";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 225);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 4;
            label5.Text = "Цена";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 278);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 5;
            label6.Text = "Количество";
            label6.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(373, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 27);
            textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(373, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 28);
            comboBox1.TabIndex = 8;
            comboBox1.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(373, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 27);
            textBox3.TabIndex = 9;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(373, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(297, 27);
            textBox4.TabIndex = 10;
            textBox4.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(373, 271);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(297, 27);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(265, 349);
            button1.Name = "button1";
            button1.Size = new Size(157, 55);
            button1.TabIndex = 12;
            button1.Text = "Добави";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(461, 349);
            button2.Name = "button2";
            button2.Size = new Size(157, 55);
            button2.TabIndex = 13;
            button2.Text = "Затвори";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form9";
            Text = "ProductsForm";
            FormClosed += Form9_FormClosed;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
    }
}
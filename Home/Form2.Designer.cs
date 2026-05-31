namespace Home
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 201);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Име";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 246);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 299);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Имейл";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(481, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(481, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(481, 292);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 27);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(499, 369);
            button1.Name = "button1";
            button1.Size = new Size(142, 44);
            button1.TabIndex = 6;
            button1.Text = "Регистрирай се";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(188, 369);
            button2.Name = "button2";
            button2.Size = new Size(142, 44);
            button2.TabIndex = 7;
            button2.Text = "Отказ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 114);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 8;
            label4.Text = "Потребителско име";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 158);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 9;
            label5.Text = "Парола";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(481, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(481, 151);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(247, 27);
            textBox5.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Admin Register";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
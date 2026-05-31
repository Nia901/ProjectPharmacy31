namespace Home
{
    partial class Form3
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 215);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Имейл";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 272);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Години";
            // 
            // button1
            // 
            button1.Location = new Point(463, 337);
            button1.Name = "button1";
            button1.Size = new Size(137, 51);
            button1.TabIndex = 2;
            button1.Text = "Регистрирай се";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(463, 265);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(463, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(174, 337);
            button2.Name = "button2";
            button2.Size = new Size(137, 51);
            button2.TabIndex = 5;
            button2.Text = "Отказ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 85);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 6;
            label3.Text = "Потребителско име";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 151);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Парола";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(463, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(463, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 27);
            textBox4.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Customer Registration";
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
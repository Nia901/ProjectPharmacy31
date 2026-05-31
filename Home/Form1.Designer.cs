namespace Home
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 75);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Потребителско име";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 156);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Парола";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(506, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(506, 149);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(506, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 234);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Роля";
            // 
            // button1
            // 
            button1.Location = new Point(212, 320);
            button1.Name = "button1";
            button1.Size = new Size(179, 48);
            button1.TabIndex = 6;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(575, 320);
            button2.Name = "button2";
            button2.Size = new Size(179, 48);
            button2.TabIndex = 7;
            button2.Text = "Регистрация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 495);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Pharmacy Home";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}

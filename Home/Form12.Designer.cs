namespace Home
{
    partial class Form12
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
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 40);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Специалист";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 115);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 206);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Дата";
            // 
            // button1
            // 
            button1.Location = new Point(212, 353);
            button1.Name = "button1";
            button1.Size = new Size(157, 50);
            button1.TabIndex = 4;
            button1.Text = "Направи запитване";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(448, 353);
            button2.Name = "button2";
            button2.Size = new Size(157, 50);
            button2.TabIndex = 5;
            button2.Text = "Отказ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(394, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 28);
            comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(394, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(280, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12";
            Text = "AskAQuestion";
            FormClosed += Form12_FormClosed;
            Load += Form12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
    }
}
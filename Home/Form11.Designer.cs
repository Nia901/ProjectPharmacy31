namespace Home
{
    partial class Form11
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(387, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 150);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Продукт";
            // 
            // button1
            // 
            button1.Location = new Point(190, 312);
            button1.Name = "button1";
            button1.Size = new Size(153, 41);
            button1.TabIndex = 2;
            button1.Text = "Направи поръчка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(387, 219);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(280, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 226);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "Количество";
            // 
            // button2
            // 
            button2.Location = new Point(422, 312);
            button2.Name = "button2";
            button2.Size = new Size(153, 41);
            button2.TabIndex = 5;
            button2.Text = "Затвори";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form11";
            Text = "MakeAnOrder";
            FormClosed += Form11_FormClosed;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Button button2;
    }
}
namespace Home
{
    partial class Form8
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 115);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Имейл";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(412, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(412, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 27);
            textBox2.TabIndex = 2;
            textBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 180);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Парола";
            label2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(107, 330);
            button1.Name = "button1";
            button1.Size = new Size(175, 54);
            button1.TabIndex = 4;
            button1.Text = "Изтрий";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(502, 330);
            button2.Name = "button2";
            button2.Size = new Size(175, 54);
            button2.TabIndex = 5;
            button2.Text = "Търси";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(753, 52);
            dataGridView1.TabIndex = 6;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(52, 12);
            button3.Name = "button3";
            button3.Size = new Size(135, 54);
            button3.TabIndex = 7;
            button3.Text = "Отказ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Search/Remove Customer";
            FormClosed += Form8_FormClosed;
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
    }
}
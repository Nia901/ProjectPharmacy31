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
            button3 = new Button();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 33);
            label1.TabIndex = 0;
            label1.Text = "Имейл";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(405, 66);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 36);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(405, 153);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(367, 36);
            textBox2.TabIndex = 2;
            textBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 156);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 33);
            label2.TabIndex = 3;
            label2.Text = "Парола";
            label2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(78, 634);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(262, 89);
            button1.TabIndex = 4;
            button1.Text = "Изтрий";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(903, 634);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(262, 89);
            button2.TabIndex = 5;
            button2.Text = "Търси";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(518, 634);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(202, 89);
            button3.TabIndex = 7;
            button3.Text = "Отказ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(178, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(812, 251);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 462);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(973, 36);
            textBox3.TabIndex = 4;
            textBox3.Visible = false;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(12F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImage = Properties.Resources.stethoscope_placed_on_a_blue_surface_a_stethoscope_rests_on_a_blue_surface_showcasing_its_metallic_components_and_soft_tubing_ideal_for_medical_use_photo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 742);
            Controls.Add(textBox3);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Sitka Banner Semibold", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form8";
            Text = "Search Customer";
            FormClosed += Form8_FormClosed;
            Load += Form8_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button button3;
        private GroupBox groupBox1;
        private TextBox textBox3;
    }
}
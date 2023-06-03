namespace PIS_WinForm.Forms
{
    partial class Delete_Animal
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 246);
            label1.Name = "label1";
            label1.Size = new Size(387, 20);
            label1.TabIndex = 1;
            label1.Text = "Вы действительно хотите удалить это животное из реестра?";
            // 
            // button1
            // 
            button1.Location = new Point(132, 285);
            button1.Name = "button1";
            button1.Size = new Size(92, 26);
            button1.TabIndex = 2;
            button1.Text = "Да";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Ok;
            // 
            // button2
            // 
            button2.Location = new Point(264, 285);
            button2.Name = "button2";
            button2.Size = new Size(92, 26);
            button2.TabIndex = 3;
            button2.Text = "Нет";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cancel;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 4;
            label2.Text = "Регистрационный номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 47);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Id города";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 76);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 4;
            label4.Text = "Категория";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 105);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "Пол";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 134);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 4;
            label6.Text = "Год рождения";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 163);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 4;
            label7.Text = "Номер эл. чипа";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(111, 192);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 4;
            label8.Text = "Кличка";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 73);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 102);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(164, 131);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(164, 160);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(164, 189);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 5;
            // 
            // Delete_Animal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 381);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Delete_Animal";
            Text = "Delete_Animal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}
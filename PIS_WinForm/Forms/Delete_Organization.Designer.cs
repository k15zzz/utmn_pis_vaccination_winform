namespace PIS_WinForm.Forms
{
    partial class Delete_Organization
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
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(303, 335);
            button2.Name = "button2";
            button2.Size = new Size(96, 34);
            button2.TabIndex = 37;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cancel;
            // 
            // button1
            // 
            button1.Location = new Point(144, 335);
            button1.Name = "button1";
            button1.Size = new Size(96, 34);
            button1.TabIndex = 36;
            button1.Text = "Да";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Yes;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(63, 286);
            label10.Name = "label10";
            label10.Size = new Size(455, 23);
            label10.TabIndex = 35;
            label10.Text = "Вы действительно хотите удалить организацию из реестра?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(208, 185);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 33;
            label5.Text = "Тип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(196, 147);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 32;
            label4.Text = "Адрес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(206, 108);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 34;
            label3.Text = "КПП";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(204, 69);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 31;
            label2.Text = "ИНН";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(174, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 30;
            label1.Text = "Название";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(246, 182);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(246, 144);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(246, 105);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 66);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 28);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 25;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(246, 213);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(121, 216);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 33;
            label6.Text = "Юридическое лицо";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(246, 244);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(172, 247);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 33;
            label7.Text = "Id_Города";
            // 
            // Delete_Organization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 425);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Delete_Organization";
            Text = "Delete_Organization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
    }
}
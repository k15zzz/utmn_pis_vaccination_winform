﻿namespace PIS_WinForm.Forms
{
    partial class AddAnimalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxChip = new System.Windows.Forms.TextBox();
            this.textBoxMarcs = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCateg = new System.Windows.Forms.ComboBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRegNum = new System.Windows.Forms.TextBox();
            this.textBoxPhoto = new System.Windows.Forms.TextBox();
            this.comboBoxTown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление карточки животного:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория животного:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пол животного:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 606);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Населённый пункт:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кличка животного:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 459);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Номер электронного чипа:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(630, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Особые приметы:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(881, 161);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(360, 39);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxChip
            // 
            this.textBoxChip.Location = new System.Drawing.Point(332, 454);
            this.textBoxChip.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxChip.Name = "textBoxChip";
            this.textBoxChip.Size = new System.Drawing.Size(243, 39);
            this.textBoxChip.TabIndex = 13;
            // 
            // textBoxMarcs
            // 
            this.textBoxMarcs.Location = new System.Drawing.Point(881, 312);
            this.textBoxMarcs.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMarcs.Name = "textBoxMarcs";
            this.textBoxMarcs.Size = new System.Drawing.Size(360, 39);
            this.textBoxMarcs.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1051, 629);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(229, 72);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(812, 629);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(229, 72);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(20, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(506, 45);
            this.label9.TabIndex = 17;
            this.label9.Text = "Заполните, пожалуйста, все поля";
            // 
            // comboBoxCateg
            // 
            this.comboBoxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCateg.FormattingEnabled = true;
            this.comboBoxCateg.Items.AddRange(new object[] {
            "Собака",
            "Кошка"});
            this.comboBoxCateg.Location = new System.Drawing.Point(332, 238);
            this.comboBoxCateg.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCateg.Name = "comboBoxCateg";
            this.comboBoxCateg.Size = new System.Drawing.Size(243, 40);
            this.comboBoxCateg.TabIndex = 18;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(332, 382);
            this.numericUpDownYear.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(244, 39);
            this.numericUpDownYear.TabIndex = 19;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "жен.",
            "муж."});
            this.comboBoxSex.Location = new System.Drawing.Point(332, 312);
            this.comboBoxSex.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(243, 40);
            this.comboBoxSex.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 32);
            this.label10.TabIndex = 21;
            this.label10.Text = "Регистрационный номер:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(630, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 32);
            this.label11.TabIndex = 22;
            this.label11.Text = "Фото:";
            // 
            // textBoxRegNum
            // 
            this.textBoxRegNum.Location = new System.Drawing.Point(332, 165);
            this.textBoxRegNum.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxRegNum.Name = "textBoxRegNum";
            this.textBoxRegNum.Size = new System.Drawing.Size(243, 39);
            this.textBoxRegNum.TabIndex = 23;
            // 
            // textBoxPhoto
            // 
            this.textBoxPhoto.Location = new System.Drawing.Point(881, 238);
            this.textBoxPhoto.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPhoto.Name = "textBoxPhoto";
            this.textBoxPhoto.Size = new System.Drawing.Size(360, 39);
            this.textBoxPhoto.TabIndex = 24;
            // 
            // comboBoxTown
            // 
            this.comboBoxTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTown.FormattingEnabled = true;
            this.comboBoxTown.Location = new System.Drawing.Point(330, 606);
            this.comboBoxTown.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxTown.Name = "comboBoxTown";
            this.comboBoxTown.Size = new System.Drawing.Size(243, 40);
            this.comboBoxTown.TabIndex = 25;
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.comboBoxTown);
            this.Controls.Add(this.textBoxPhoto);
            this.Controls.Add(this.textBoxRegNum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.comboBoxCateg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMarcs);
            this.Controls.Add(this.textBoxChip);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddAnimalForm";
            this.Text = "Добавление карточки животного";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label9;
        private Label label10;
        private Label label11;
        internal Label label1;
        internal TextBox textBoxName;
        internal TextBox textBoxChip;
        internal TextBox textBoxMarcs;
        internal ComboBox comboBoxCateg;
        internal NumericUpDown numericUpDownYear;
        internal ComboBox comboBoxSex;
        internal TextBox textBoxRegNum;
        internal TextBox textBoxPhoto;
        internal ComboBox comboBoxTown;
    }
}
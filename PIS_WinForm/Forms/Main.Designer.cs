namespace PIS_WinForm.Forms
{
    partial class Main
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
            this.LookAllAnimals = new System.Windows.Forms.Button();
            this.calculateStatisticButton = new System.Windows.Forms.Button();
            this.finishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.townsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.LookAllContracts = new System.Windows.Forms.Button();
            this.LookAllOrganization = new System.Windows.Forms.Button();
            this.groupBoxStatistick = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStatistick.SuspendLayout();
            this.SuspendLayout();
            // 
            // LookAllAnimals
            // 
            this.LookAllAnimals.Location = new System.Drawing.Point(15, 15);
            this.LookAllAnimals.Margin = new System.Windows.Forms.Padding(6);
            this.LookAllAnimals.Name = "LookAllAnimals";
            this.LookAllAnimals.Size = new System.Drawing.Size(423, 90);
            this.LookAllAnimals.TabIndex = 0;
            this.LookAllAnimals.Text = "Посмотреть реестр животных";
            this.LookAllAnimals.UseVisualStyleBackColor = true;
            this.LookAllAnimals.Click += new System.EventHandler(this.OnButtonClick_LookAllAnimals);
            // 
            // calculateStatisticButton
            // 
            this.calculateStatisticButton.Location = new System.Drawing.Point(306, 301);
            this.calculateStatisticButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.calculateStatisticButton.Name = "calculateStatisticButton";
            this.calculateStatisticButton.Size = new System.Drawing.Size(150, 47);
            this.calculateStatisticButton.TabIndex = 1;
            this.calculateStatisticButton.Text = "Рассчитать";
            this.calculateStatisticButton.UseVisualStyleBackColor = true;
            // 
            // finishDateTimePicker
            // 
            this.finishDateTimePicker.Location = new System.Drawing.Point(7, 258);
            this.finishDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.finishDateTimePicker.Name = "finishDateTimePicker";
            this.finishDateTimePicker.Size = new System.Drawing.Size(449, 39);
            this.finishDateTimePicker.TabIndex = 2;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(6, 183);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(449, 39);
            this.startDateTimePicker.TabIndex = 3;
            // 
            // townsCheckedListBox
            // 
            this.townsCheckedListBox.FormattingEnabled = true;
            this.townsCheckedListBox.Location = new System.Drawing.Point(7, 37);
            this.townsCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.townsCheckedListBox.Name = "townsCheckedListBox";
            this.townsCheckedListBox.Size = new System.Drawing.Size(449, 112);
            this.townsCheckedListBox.TabIndex = 4;
            // 
            // LookAllContracts
            // 
            this.LookAllContracts.Location = new System.Drawing.Point(15, 158);
            this.LookAllContracts.Margin = new System.Windows.Forms.Padding(6);
            this.LookAllContracts.Name = "LookAllContracts";
            this.LookAllContracts.Size = new System.Drawing.Size(423, 90);
            this.LookAllContracts.TabIndex = 5;
            this.LookAllContracts.Text = "Посмотреть реестр контрактов";
            this.LookAllContracts.UseVisualStyleBackColor = true;
            this.LookAllContracts.Click += new System.EventHandler(this.OnButtonClick_LookAllContracts);
            // 
            // LookAllOrganization
            // 
            this.LookAllOrganization.Location = new System.Drawing.Point(15, 298);
            this.LookAllOrganization.Margin = new System.Windows.Forms.Padding(6, 6, 6, 10);
            this.LookAllOrganization.Name = "LookAllOrganization";
            this.LookAllOrganization.Size = new System.Drawing.Size(423, 90);
            this.LookAllOrganization.TabIndex = 6;
            this.LookAllOrganization.Text = "Посмотреть реестр организаций";
            this.LookAllOrganization.UseVisualStyleBackColor = true;
            this.LookAllOrganization.Click += new System.EventHandler(this.LookAllOrganization_Click);
            // 
            // groupBoxStatistick
            // 
            this.groupBoxStatistick.Controls.Add(this.label2);
            this.groupBoxStatistick.Controls.Add(this.label1);
            this.groupBoxStatistick.Controls.Add(this.townsCheckedListBox);
            this.groupBoxStatistick.Controls.Add(this.calculateStatisticButton);
            this.groupBoxStatistick.Controls.Add(this.startDateTimePicker);
            this.groupBoxStatistick.Controls.Add(this.finishDateTimePicker);
            this.groupBoxStatistick.Location = new System.Drawing.Point(466, 26);
            this.groupBoxStatistick.Name = "groupBoxStatistick";
            this.groupBoxStatistick.Size = new System.Drawing.Size(475, 365);
            this.groupBoxStatistick.TabIndex = 7;
            this.groupBoxStatistick.TabStop = false;
            this.groupBoxStatistick.Text = "Статистика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата  конца";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата начала";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(953, 403);
            this.Controls.Add(this.groupBoxStatistick);
            this.Controls.Add(this.LookAllOrganization);
            this.Controls.Add(this.LookAllContracts);
            this.Controls.Add(this.LookAllAnimals);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Главная форма";
            this.groupBoxStatistick.ResumeLayout(false);
            this.groupBoxStatistick.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button LookAllAnimals;
        private Button calculateStatisticButton;
        private DateTimePicker finishDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private CheckedListBox townsCheckedListBox;
        private Button LookAllContracts;
        private Button LookAllOrganizations;
        private Button LookAllOrganization;
        private GroupBox groupBoxStatistick;
        private Label label2;
        private Label label1;
    }
}
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
            LookAllAnimals = new Button();
            calculateStatisticButton = new Button();
            finishDateTimePicker = new DateTimePicker();
            startDateTimePicker = new DateTimePicker();
            townsCheckedListBox = new CheckedListBox();
            this.LookAllContracts = new Button();
            SuspendLayout();
            // 
            // LookAllAnimals
            // 
            LookAllAnimals.Location = new Point(12, 12);
            LookAllAnimals.Name = "LookAllAnimals";
            LookAllAnimals.Size = new Size(228, 42);
            LookAllAnimals.TabIndex = 0;
            LookAllAnimals.Text = "Посмотреть реестр животных";
            LookAllAnimals.UseVisualStyleBackColor = true;
            LookAllAnimals.Click += OnButtonClick_LookAllAnimals;
            // 
            // calculateStatisticButton
            // 
            calculateStatisticButton.Location = new Point(713, 103);
            calculateStatisticButton.Margin = new Padding(2, 1, 2, 1);
            calculateStatisticButton.Name = "calculateStatisticButton";
            calculateStatisticButton.Size = new Size(81, 22);
            calculateStatisticButton.TabIndex = 1;
            calculateStatisticButton.Text = "Рассчитать";
            calculateStatisticButton.UseVisualStyleBackColor = true;
            // 
            // finishDateTimePicker
            // 
            finishDateTimePicker.Location = new Point(578, 82);
            finishDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            finishDateTimePicker.Name = "finishDateTimePicker";
            finishDateTimePicker.Size = new Size(217, 23);
            finishDateTimePicker.TabIndex = 2;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(578, 61);
            startDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(217, 23);
            startDateTimePicker.TabIndex = 3;
            // 
            // townsCheckedListBox
            // 
            townsCheckedListBox.FormattingEnabled = true;
            townsCheckedListBox.Location = new Point(578, 6);
            townsCheckedListBox.Margin = new Padding(2, 1, 2, 1);
            townsCheckedListBox.Name = "townsCheckedListBox";
            townsCheckedListBox.Size = new Size(218, 22);
            townsCheckedListBox.TabIndex = 4;
            // 
            // LookAllContracts
            // 
            this.LookAllContracts.Location = new Point(12, 60);
            this.LookAllContracts.Name = "LookAllContracts";
            this.LookAllContracts.Size = new Size(228, 42);
            this.LookAllContracts.TabIndex = 5;
            this.LookAllContracts.Text = "Посмотреть реестр контрактов";
            this.LookAllContracts.UseVisualStyleBackColor = true;
            this.LookAllContracts.Click += this.OnButtonClick_LookAllContracts;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.LookAllContracts);
            Controls.Add(townsCheckedListBox);
            Controls.Add(startDateTimePicker);
            Controls.Add(finishDateTimePicker);
            Controls.Add(calculateStatisticButton);
            Controls.Add(LookAllAnimals);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button LookAllAnimals;
        private Button calculateStatisticButton;
        private DateTimePicker finishDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private CheckedListBox townsCheckedListBox;
        private Button LookAllContracts;
        private Button LookAllOrganizations;
    }
}
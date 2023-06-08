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
            this.SuspendLayout();
            // 
            // LookAllAnimals
            // 
            this.LookAllAnimals.Location = new System.Drawing.Point(14, 16);
            this.LookAllAnimals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LookAllAnimals.Name = "LookAllAnimals";
            this.LookAllAnimals.Size = new System.Drawing.Size(261, 56);
            this.LookAllAnimals.TabIndex = 0;
            this.LookAllAnimals.Text = "Посмотреть реестр животных";
            this.LookAllAnimals.UseVisualStyleBackColor = true;
            this.LookAllAnimals.Click += new System.EventHandler(this.OnButtonClick_LookAllAnimals);
            // 
            // calculateStatisticButton
            // 
            this.calculateStatisticButton.Location = new System.Drawing.Point(815, 137);
            this.calculateStatisticButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.calculateStatisticButton.Name = "calculateStatisticButton";
            this.calculateStatisticButton.Size = new System.Drawing.Size(93, 29);
            this.calculateStatisticButton.TabIndex = 1;
            this.calculateStatisticButton.Text = "Рассчитать";
            this.calculateStatisticButton.UseVisualStyleBackColor = true;
            // 
            // finishDateTimePicker
            // 
            this.finishDateTimePicker.Location = new System.Drawing.Point(661, 109);
            this.finishDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.finishDateTimePicker.Name = "finishDateTimePicker";
            this.finishDateTimePicker.Size = new System.Drawing.Size(247, 27);
            this.finishDateTimePicker.TabIndex = 2;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(661, 81);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(247, 27);
            this.startDateTimePicker.TabIndex = 3;
            // 
            // townsCheckedListBox
            // 
            this.townsCheckedListBox.FormattingEnabled = true;
            this.townsCheckedListBox.Location = new System.Drawing.Point(661, 8);
            this.townsCheckedListBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.townsCheckedListBox.Name = "townsCheckedListBox";
            this.townsCheckedListBox.Size = new System.Drawing.Size(249, 48);
            this.townsCheckedListBox.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.townsCheckedListBox);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.finishDateTimePicker);
            this.Controls.Add(this.calculateStatisticButton);
            this.Controls.Add(this.LookAllAnimals);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button LookAllAnimals;
        private Button calculateStatisticButton;
        private DateTimePicker finishDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private CheckedListBox townsCheckedListBox;
    }
}
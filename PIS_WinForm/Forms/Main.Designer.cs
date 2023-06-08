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
            LookAllMnimals = new Button();
            calculateStatisticButton = new Button();
            finishDateTimePicker = new DateTimePicker();
            startDateTimePicker = new DateTimePicker();
            townsCheckedListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // LookAllMnimals
            // 
            LookAllMnimals.Location = new Point(12, 12);
            LookAllMnimals.Name = "LookAllMnimals";
            LookAllMnimals.Size = new Size(189, 23);
            LookAllMnimals.TabIndex = 0;
            LookAllMnimals.Text = "Посмотреть реестр Животных";
            LookAllMnimals.UseVisualStyleBackColor = true;
            LookAllMnimals.Click += OnButtonClick_LookAllAnimals;
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
            calculateStatisticButton.Click += calculateStatisticButton_Click;
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
            townsCheckedListBox.Size = new Size(218, 40);
            townsCheckedListBox.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(townsCheckedListBox);
            Controls.Add(startDateTimePicker);
            Controls.Add(finishDateTimePicker);
            Controls.Add(calculateStatisticButton);
            Controls.Add(LookAllMnimals);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button LookAllMnimals;
        private Button calculateStatisticButton;
        private DateTimePicker finishDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private CheckedListBox townsCheckedListBox;
    }
}
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
            this.LookAllMnimals = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.finishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.townsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // LookAllMnimals
            // 
            this.LookAllMnimals.Enabled = false;
            this.LookAllMnimals.Location = new System.Drawing.Point(22, 26);
            this.LookAllMnimals.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LookAllMnimals.Name = "LookAllMnimals";
            this.LookAllMnimals.Size = new System.Drawing.Size(351, 49);
            this.LookAllMnimals.TabIndex = 0;
            this.LookAllMnimals.Text = "Посмотреть реестр Животных";
            this.LookAllMnimals.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1324, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // finishDateTimePicker
            // 
            this.finishDateTimePicker.Location = new System.Drawing.Point(1074, 175);
            this.finishDateTimePicker.Name = "finishDateTimePicker";
            this.finishDateTimePicker.Size = new System.Drawing.Size(400, 39);
            this.finishDateTimePicker.TabIndex = 2;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(1074, 130);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(400, 39);
            this.startDateTimePicker.TabIndex = 3;
            // 
            // townsCheckedListBox
            // 
            this.townsCheckedListBox.FormattingEnabled = true;
            this.townsCheckedListBox.Location = new System.Drawing.Point(1073, 12);
            this.townsCheckedListBox.Name = "townsCheckedListBox";
            this.townsCheckedListBox.Size = new System.Drawing.Size(401, 112);
            this.townsCheckedListBox.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.townsCheckedListBox);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.finishDateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LookAllMnimals);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button LookAllMnimals;
        private Button button1;
        private DateTimePicker finishDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private CheckedListBox townsCheckedListBox;
    }
}
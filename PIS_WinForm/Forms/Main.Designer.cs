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
            SuspendLayout();
            // 
            // LookAllAnimals
            // 
            LookAllAnimals.Location = new Point(12, 12);
            LookAllAnimals.Name = "LookAllAnimals";
            LookAllAnimals.Size = new Size(189, 23);
            LookAllAnimals.TabIndex = 0;
            LookAllAnimals.Text = "Посмотреть реестр животных";
            LookAllAnimals.UseVisualStyleBackColor = true;
            LookAllAnimals.Click += OnButtonClick_LookAllAnimals;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LookAllAnimals);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button LookAllAnimals;
    }
}
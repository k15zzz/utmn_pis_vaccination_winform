namespace PIS_WinForm
{
    partial class mainForm
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
            menuStrip1 = new MenuStrip();
            фаилToolStripMenuItem = new ToolStripMenuItem();
            животныеToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            посмотретьToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { фаилToolStripMenuItem, животныеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // фаилToolStripMenuItem
            // 
            фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            фаилToolStripMenuItem.Size = new Size(48, 20);
            фаилToolStripMenuItem.Text = "Фаил";
            // 
            // животныеToolStripMenuItem
            // 
            животныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, посмотретьToolStripMenuItem });
            животныеToolStripMenuItem.Name = "животныеToolStripMenuItem";
            животныеToolStripMenuItem.Size = new Size(77, 20);
            животныеToolStripMenuItem.Text = "Животные";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(180, 22);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // посмотретьToolStripMenuItem
            // 
            посмотретьToolStripMenuItem.Name = "посмотретьToolStripMenuItem";
            посмотретьToolStripMenuItem.Size = new Size(180, 22);
            посмотретьToolStripMenuItem.Text = "Посмотреть";
            посмотретьToolStripMenuItem.Click += OnButtonClick_LookAllAnimals;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "mainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem фаилToolStripMenuItem;
        private ToolStripMenuItem животныеToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem посмотретьToolStripMenuItem;
    }
}
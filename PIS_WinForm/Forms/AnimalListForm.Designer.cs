namespace PIS_WinForm.Forms
{
    partial class AnimalListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(529, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(547, 108);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(231, 42);
            this.button_Edit.TabIndex = 1;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(547, 60);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(231, 42);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.OnButtonClick_AddAnimal);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(547, 156);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(231, 42);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_View
            // 
            this.button_View.Location = new System.Drawing.Point(547, 12);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(231, 42);
            this.button_View.TabIndex = 4;
            this.button_View.Text = "Посмотреть";
            this.button_View.UseVisualStyleBackColor = true;
            // 
            // button_Menu
            // 
            this.button_Menu.Location = new System.Drawing.Point(547, 396);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(231, 42);
            this.button_Menu.TabIndex = 5;
            this.button_Menu.Text = "На главную";
            this.button_Menu.UseVisualStyleBackColor = true;
            // 
            // AnimalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnimalListForm";
            this.Text = "AnimalListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_Edit;
        private Button button_Add;
        private Button button_Delete;
        private Button button_View;
        private Button button_Menu;
    }
}
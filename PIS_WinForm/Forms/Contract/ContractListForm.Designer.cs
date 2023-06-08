namespace PIS_WinForm.Forms.Contract
{
    partial class ContractListForm
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ispolnitel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isponlitelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zacazchik_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zacazchikName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filter = new System.Windows.Forms.ToolStripMenuItem();
            this.Ispolnitel = new System.Windows.Forms.ToolStripMenuItem();
            this.Zakazchic = new System.Windows.Forms.ToolStripMenuItem();
            this.button_View = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.filterbutton = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.startDate,
            this.endDate,
            this.ispolnitel_id,
            this.isponlitelName,
            this.zacazchik_id,
            this.zacazchikName});
            this.dataGridView1.Location = new System.Drawing.Point(22, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 683);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 200;
            // 
            // number
            // 
            this.number.HeaderText = "Номер";
            this.number.MinimumWidth = 10;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 200;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Дата заключения";
            this.startDate.MinimumWidth = 10;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 200;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "Дата Действия";
            this.endDate.MinimumWidth = 10;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 200;
            // 
            // ispolnitel_id
            // 
            this.ispolnitel_id.HeaderText = "Имсполнилель id";
            this.ispolnitel_id.MinimumWidth = 10;
            this.ispolnitel_id.Name = "ispolnitel_id";
            this.ispolnitel_id.ReadOnly = true;
            this.ispolnitel_id.Visible = false;
            this.ispolnitel_id.Width = 200;
            // 
            // isponlitelName
            // 
            this.isponlitelName.HeaderText = "Исполнитель";
            this.isponlitelName.MinimumWidth = 10;
            this.isponlitelName.Name = "isponlitelName";
            this.isponlitelName.ReadOnly = true;
            this.isponlitelName.Width = 200;
            // 
            // zacazchik_id
            // 
            this.zacazchik_id.HeaderText = "Заказчик id";
            this.zacazchik_id.MinimumWidth = 10;
            this.zacazchik_id.Name = "zacazchik_id";
            this.zacazchik_id.ReadOnly = true;
            this.zacazchik_id.Visible = false;
            this.zacazchik_id.Width = 200;
            // 
            // zacazchikName
            // 
            this.zacazchikName.HeaderText = "Заказчик";
            this.zacazchikName.MinimumWidth = 10;
            this.zacazchikName.Name = "zacazchikName";
            this.zacazchikName.ReadOnly = true;
            this.zacazchikName.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 44);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filter
            // 
            this.filter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ispolnitel,
            this.Zakazchic});
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(114, 36);
            this.filter.Text = "Фильтр";
            // 
            // Ispolnitel
            // 
            this.Ispolnitel.Name = "Ispolnitel";
            this.Ispolnitel.Size = new System.Drawing.Size(359, 44);
            this.Ispolnitel.Text = "Исполнитель";
            // 
            // Zakazchic
            // 
            this.Zakazchic.Name = "Zakazchic";
            this.Zakazchic.Size = new System.Drawing.Size(359, 44);
            this.Zakazchic.Text = "Заказчик";
            // 
            // button_View
            // 
            this.button_View.Location = new System.Drawing.Point(893, 55);
            this.button_View.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(375, 68);
            this.button_View.TabIndex = 8;
            this.button_View.Text = "Посмотреть";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(893, 132);
            this.button_Add.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(375, 68);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(893, 209);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(375, 68);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // filterbutton
            // 
            this.filterbutton.Location = new System.Drawing.Point(893, 286);
            this.filterbutton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(375, 68);
            this.filterbutton.TabIndex = 11;
            this.filterbutton.Text = "Отфильтровать";
            this.filterbutton.UseVisualStyleBackColor = true;
            // 
            // button_Menu
            // 
            this.button_Menu.Location = new System.Drawing.Point(893, 670);
            this.button_Menu.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(375, 68);
            this.button_Menu.TabIndex = 12;
            this.button_Menu.Text = "На главную";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click_1);
            // 
            // ContractListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1283, 754);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.filterbutton);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ContractListForm";
            this.Text = "Реестр контактов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filter;
        private ToolStripMenuItem Ispolnitel;
        private ToolStripMenuItem Zakazchic;
        private Button button_View;
        private Button button_Add;
        private Button button_Delete;
        private Button filterbutton;
        private Button button_Menu;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewTextBoxColumn ispolnitel_id;
        private DataGridViewTextBoxColumn isponlitelName;
        private DataGridViewTextBoxColumn zacazchik_id;
        private DataGridViewTextBoxColumn zacazchikName;
    }
}
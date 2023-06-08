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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            number = new DataGridViewTextBoxColumn();
            startDate = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            ispolnitel_id = new DataGridViewTextBoxColumn();
            isponlitelName = new DataGridViewTextBoxColumn();
            zacazchik_id = new DataGridViewTextBoxColumn();
            zacazchikName = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            filter = new ToolStripMenuItem();
            Ispolnitel = new ToolStripMenuItem();
            Zakazchic = new ToolStripMenuItem();
            button_View = new Button();
            button_Add = new Button();
            button_Delete = new Button();
            filterbutton = new Button();
            button_Menu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, number, startDate, endDate, ispolnitel_id, isponlitelName, zacazchik_id, zacazchikName });
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(463, 320);
            dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 200;
            // 
            // number
            // 
            number.HeaderText = "Номер";
            number.MinimumWidth = 10;
            number.Name = "number";
            number.ReadOnly = true;
            number.Width = 200;
            // 
            // startDate
            // 
            startDate.HeaderText = "Дата заключения";
            startDate.MinimumWidth = 10;
            startDate.Name = "startDate";
            startDate.ReadOnly = true;
            startDate.Width = 200;
            // 
            // endDate
            // 
            endDate.HeaderText = "Дата Действия";
            endDate.MinimumWidth = 10;
            endDate.Name = "endDate";
            endDate.ReadOnly = true;
            endDate.Width = 200;
            // 
            // ispolnitel_id
            // 
            ispolnitel_id.HeaderText = "Имсполнилель id";
            ispolnitel_id.MinimumWidth = 10;
            ispolnitel_id.Name = "ispolnitel_id";
            ispolnitel_id.ReadOnly = true;
            ispolnitel_id.Visible = false;
            ispolnitel_id.Width = 200;
            // 
            // isponlitelName
            // 
            isponlitelName.HeaderText = "Исполнитель";
            isponlitelName.MinimumWidth = 10;
            isponlitelName.Name = "isponlitelName";
            isponlitelName.ReadOnly = true;
            isponlitelName.Width = 200;
            // 
            // zacazchik_id
            // 
            zacazchik_id.HeaderText = "Заказчик id";
            zacazchik_id.MinimumWidth = 10;
            zacazchik_id.Name = "zacazchik_id";
            zacazchik_id.ReadOnly = true;
            zacazchik_id.Visible = false;
            zacazchik_id.Width = 200;
            // 
            // zacazchikName
            // 
            zacazchikName.HeaderText = "Заказчик";
            zacazchikName.MinimumWidth = 10;
            zacazchikName.Name = "zacazchikName";
            zacazchikName.ReadOnly = true;
            zacazchikName.Width = 200;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filter });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(691, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // filter
            // 
            filter.DropDownItems.AddRange(new ToolStripItem[] { Ispolnitel, Zakazchic });
            filter.Name = "filter";
            filter.Size = new Size(60, 20);
            filter.Text = "Фильтр";
            // 
            // Ispolnitel
            // 
            Ispolnitel.Name = "Ispolnitel";
            Ispolnitel.Size = new Size(148, 22);
            Ispolnitel.Text = "Исполнитель";
            // 
            // Zakazchic
            // 
            Zakazchic.Name = "Zakazchic";
            Zakazchic.Size = new Size(148, 22);
            Zakazchic.Text = "Заказчик";
            // 
            // button_View
            // 
            button_View.Location = new Point(481, 26);
            button_View.Margin = new Padding(3, 2, 3, 2);
            button_View.Name = "button_View";
            button_View.Size = new Size(202, 32);
            button_View.TabIndex = 8;
            button_View.Text = "Посмотреть";
            button_View.UseVisualStyleBackColor = true;
            button_View.Click += button_View_Click;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(481, 62);
            button_Add.Margin = new Padding(3, 2, 3, 2);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(202, 32);
            button_Add.TabIndex = 9;
            button_Add.Text = "Добавить";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(481, 98);
            button_Delete.Margin = new Padding(3, 2, 3, 2);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(202, 32);
            button_Delete.TabIndex = 10;
            button_Delete.Text = "Удалить";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // filterbutton
            // 
            filterbutton.Location = new Point(481, 134);
            filterbutton.Margin = new Padding(3, 2, 3, 2);
            filterbutton.Name = "filterbutton";
            filterbutton.Size = new Size(202, 32);
            filterbutton.TabIndex = 11;
            filterbutton.Text = "Отфильтровать";
            filterbutton.UseVisualStyleBackColor = true;
            filterbutton.Click += filterbutton_Click;
            // 
            // button_Menu
            // 
            button_Menu.Location = new Point(481, 314);
            button_Menu.Margin = new Padding(3, 2, 3, 2);
            button_Menu.Name = "button_Menu";
            button_Menu.Size = new Size(202, 32);
            button_Menu.TabIndex = 12;
            button_Menu.Text = "На главную";
            button_Menu.UseVisualStyleBackColor = true;
            button_Menu.Click += button_Menu_Click_1;
            // 
            // ContractListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(691, 353);
            Controls.Add(button_Menu);
            Controls.Add(filterbutton);
            Controls.Add(button_Delete);
            Controls.Add(button_Add);
            Controls.Add(button_View);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            Name = "ContractListForm";
            Text = "Реестр контактов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
namespace PIS_WinForm.Forms.Organization
{
    partial class OrganizationListForm
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
            filterbutton = new Button();
            button_Menu = new Button();
            button_View = new Button();
            button_Delete = new Button();
            button_Add = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            INN = new DataGridViewTextBoxColumn();
            KPP = new DataGridViewTextBoxColumn();
            aderss = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            UrFace = new DataGridViewTextBoxColumn();
            town_id = new DataGridViewTextBoxColumn();
            townName = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            filter = new ToolStripMenuItem();
            Town = new ToolStripMenuItem();
            Categorya = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // filterbutton
            // 
            filterbutton.Location = new Point(469, 134);
            filterbutton.Margin = new Padding(3, 2, 3, 2);
            filterbutton.Name = "filterbutton";
            filterbutton.Size = new Size(202, 32);
            filterbutton.TabIndex = 14;
            filterbutton.Text = "Отфильтровать";
            filterbutton.UseVisualStyleBackColor = true;
            filterbutton.Click += filterbutton_Click;
            // 
            // button_Menu
            // 
            button_Menu.Location = new Point(469, 314);
            button_Menu.Margin = new Padding(3, 2, 3, 2);
            button_Menu.Name = "button_Menu";
            button_Menu.Size = new Size(202, 32);
            button_Menu.TabIndex = 12;
            button_Menu.Text = "На главную";
            button_Menu.UseVisualStyleBackColor = true;
            button_Menu.Click += button_Menu_Click;
            // 
            // button_View
            // 
            button_View.Location = new Point(469, 26);
            button_View.Margin = new Padding(3, 2, 3, 2);
            button_View.Name = "button_View";
            button_View.Size = new Size(202, 32);
            button_View.TabIndex = 11;
            button_View.Text = "Посмотреть";
            button_View.UseVisualStyleBackColor = true;
            button_View.Click += button_View_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(469, 98);
            button_Delete.Margin = new Padding(3, 2, 3, 2);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(202, 32);
            button_Delete.TabIndex = 10;
            button_Delete.Text = "Удалить";
            button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(469, 62);
            button_Add.Margin = new Padding(3, 2, 3, 2);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(202, 32);
            button_Add.TabIndex = 9;
            button_Add.Text = "Добавить";
            button_Add.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, fullName, INN, KPP, aderss, type, UrFace, town_id, townName });
            dataGridView1.Location = new Point(0, 26);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(463, 320);
            dataGridView1.TabIndex = 8;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // fullName
            // 
            fullName.HeaderText = "Полное наименование организации";
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            // 
            // INN
            // 
            INN.HeaderText = "ИНН";
            INN.Name = "INN";
            INN.ReadOnly = true;
            // 
            // KPP
            // 
            KPP.HeaderText = "КПП";
            KPP.Name = "KPP";
            KPP.ReadOnly = true;
            // 
            // aderss
            // 
            aderss.HeaderText = "Адрес регистрации";
            aderss.Name = "aderss";
            aderss.ReadOnly = true;
            // 
            // type
            // 
            type.HeaderText = "Тип организации";
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // UrFace
            // 
            UrFace.HeaderText = "ИП/Юридическое лицо";
            UrFace.Name = "UrFace";
            UrFace.ReadOnly = true;
            // 
            // town_id
            // 
            town_id.HeaderText = "Населённый пункт";
            town_id.Name = "town_id";
            town_id.ReadOnly = true;
            town_id.Visible = false;
            // 
            // townName
            // 
            townName.HeaderText = "Населённый пункт";
            townName.Name = "townName";
            townName.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filter });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // filter
            // 
            filter.DropDownItems.AddRange(new ToolStripItem[] { Town, Categorya });
            filter.Name = "filter";
            filter.Size = new Size(60, 20);
            filter.Text = "фильтр";
            // 
            // Town
            // 
            Town.Name = "Town";
            Town.Size = new Size(180, 22);
            Town.Text = "Город";
            // 
            // Categorya
            // 
            Categorya.Name = "Categorya";
            Categorya.Size = new Size(180, 22);
            Categorya.Text = "Тип организации";
            // 
            // OrganizationListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(filterbutton);
            Controls.Add(button_Menu);
            Controls.Add(button_View);
            Controls.Add(button_Delete);
            Controls.Add(button_Add);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Name = "OrganizationListForm";
            Text = "Реестр организаций";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button filterbutton;
        private Button button_Menu;
        private Button button_View;
        private Button button_Delete;
        private Button button_Add;
        internal DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filter;
        private ToolStripMenuItem Town;
        private ToolStripMenuItem Categorya;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn INN;
        private DataGridViewTextBoxColumn KPP;
        private DataGridViewTextBoxColumn aderss;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn UrFace;
        private DataGridViewTextBoxColumn town_id;
        private DataGridViewTextBoxColumn townName;
    }
}
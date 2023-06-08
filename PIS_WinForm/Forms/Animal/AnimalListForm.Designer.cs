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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            RegNum = new DataGridViewTextBoxColumn();
            town_id = new DataGridViewTextBoxColumn();
            townName = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            sex = new DataGridViewTextBoxColumn();
            burthYear = new DataGridViewTextBoxColumn();
            e_chipNumber = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            photos = new DataGridViewTextBoxColumn();
            specMarks = new DataGridViewTextBoxColumn();
            button_Edit = new Button();
            button_Add = new Button();
            button_Delete = new Button();
            button_View = new Button();
            button_Menu = new Button();
            menuStrip1 = new MenuStrip();
            filter = new ToolStripMenuItem();
            Town = new ToolStripMenuItem();
            Categorya = new ToolStripMenuItem();
            Sexy = new ToolStripMenuItem();
            filterbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, RegNum, town_id, townName, category, sex, burthYear, e_chipNumber, name, photos, specMarks });
            dataGridView1.Location = new Point(12, 33);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(463, 320);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // RegNum
            // 
            RegNum.HeaderText = "Ристриционный номер";
            RegNum.Name = "RegNum";
            RegNum.ReadOnly = true;
            // 
            // town_id
            // 
            town_id.HeaderText = "Город";
            town_id.Name = "town_id";
            town_id.ReadOnly = true;
            town_id.Visible = false;
            // 
            // townName
            // 
            townName.HeaderText = "Город";
            townName.Name = "townName";
            townName.ReadOnly = true;
            // 
            // category
            // 
            category.HeaderText = "категору";
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // sex
            // 
            sex.HeaderText = "Пол";
            sex.Name = "sex";
            sex.ReadOnly = true;
            // 
            // burthYear
            // 
            burthYear.HeaderText = "День рождения";
            burthYear.Name = "burthYear";
            burthYear.ReadOnly = true;
            // 
            // e_chipNumber
            // 
            e_chipNumber.HeaderText = "Номер э-чипа";
            e_chipNumber.Name = "e_chipNumber";
            e_chipNumber.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Кличка";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // photos
            // 
            photos.HeaderText = "Фото";
            photos.Name = "photos";
            photos.ReadOnly = true;
            // 
            // specMarks
            // 
            specMarks.HeaderText = "Особые приметы";
            specMarks.Name = "specMarks";
            specMarks.ReadOnly = true;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(479, 105);
            button_Edit.Margin = new Padding(3, 2, 3, 2);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(202, 32);
            button_Edit.TabIndex = 1;
            button_Edit.Text = "Редактировать";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(479, 69);
            button_Add.Margin = new Padding(3, 2, 3, 2);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(202, 32);
            button_Add.TabIndex = 2;
            button_Add.Text = "Добавить";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += OnButtonClick_AddAnimal;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(479, 141);
            button_Delete.Margin = new Padding(3, 2, 3, 2);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(202, 32);
            button_Delete.TabIndex = 3;
            button_Delete.Text = "Удалить";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += Delete;
            // 
            // button_View
            // 
            button_View.Location = new Point(479, 33);
            button_View.Margin = new Padding(3, 2, 3, 2);
            button_View.Name = "button_View";
            button_View.Size = new Size(202, 32);
            button_View.TabIndex = 4;
            button_View.Text = "Посмотреть";
            button_View.UseVisualStyleBackColor = true;
            button_View.Click += OnDoubleClick_LookAtContract;
            // 
            // button_Menu
            // 
            button_Menu.Location = new Point(479, 321);
            button_Menu.Margin = new Padding(3, 2, 3, 2);
            button_Menu.Name = "button_Menu";
            button_Menu.Size = new Size(202, 32);
            button_Menu.TabIndex = 5;
            button_Menu.Text = "На главную";
            button_Menu.UseVisualStyleBackColor = true;
            button_Menu.Click += button_Menu_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { filter });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(695, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // filter
            // 
            filter.DropDownItems.AddRange(new ToolStripItem[] { Town, Categorya, Sexy });
            filter.Name = "filter";
            filter.Size = new Size(60, 20);
            filter.Text = "фильтр";
            // 
            // Town
            // 
            Town.Name = "Town";
            Town.Size = new Size(130, 22);
            Town.Text = "Город";
            // 
            // Categorya
            // 
            Categorya.Name = "Categorya";
            Categorya.Size = new Size(130, 22);
            Categorya.Text = "Категория";
            // 
            // Sexy
            // 
            Sexy.Name = "Sexy";
            Sexy.Size = new Size(130, 22);
            Sexy.Text = "Пол";
            // 
            // filterbutton
            // 
            filterbutton.Location = new Point(479, 177);
            filterbutton.Margin = new Padding(3, 2, 3, 2);
            filterbutton.Name = "filterbutton";
            filterbutton.Size = new Size(202, 32);
            filterbutton.TabIndex = 7;
            filterbutton.Text = "Отфильтровать";
            filterbutton.UseVisualStyleBackColor = true;
            filterbutton.Click += filterbutton_Click;
            // 
            // AnimalListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 364);
            Controls.Add(filterbutton);
            Controls.Add(button_Menu);
            Controls.Add(button_View);
            Controls.Add(button_Delete);
            Controls.Add(button_Add);
            Controls.Add(button_Edit);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnimalListForm";
            Text = "AnimalListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_Edit;
        private Button button_Add;
        private Button button_Delete;
        private Button button_View;
        private Button button_Menu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filter;
        private ToolStripMenuItem bngngngnToolStripMenuItem;
        private ToolStripMenuItem категорияToolStripMenuItem;
        private ToolStripMenuItem полToolStripMenuItem;
        private ToolStripMenuItem Town;
        private ToolStripMenuItem Categorya;
        private ToolStripMenuItem Sexy;
        private Button filterbutton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn RegNum;
        private DataGridViewTextBoxColumn town_id;
        private DataGridViewTextBoxColumn townName;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn sex;
        private DataGridViewTextBoxColumn burthYear;
        private DataGridViewTextBoxColumn e_chipNumber;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn photos;
        private DataGridViewTextBoxColumn specMarks;
    }
}
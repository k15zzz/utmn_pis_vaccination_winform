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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.town_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_chipNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filter = new System.Windows.Forms.ToolStripMenuItem();
            this.Town = new System.Windows.Forms.ToolStripMenuItem();
            this.Categorya = new System.Windows.Forms.ToolStripMenuItem();
            this.Sexy = new System.Windows.Forms.ToolStripMenuItem();
            this.filterbutton = new System.Windows.Forms.Button();
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
            this.RegNum,
            this.town_id,
            this.townName,
            this.category,
            this.sex,
            this.burthYear,
            this.e_chipNumber,
            this.name,
            this.photos,
            this.specMarks});
            this.dataGridView1.Location = new System.Drawing.Point(14, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(529, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // RegNum
            // 
            this.RegNum.HeaderText = "Ристриционный номер";
            this.RegNum.MinimumWidth = 6;
            this.RegNum.Name = "RegNum";
            this.RegNum.ReadOnly = true;
            this.RegNum.Width = 125;
            // 
            // town_id
            // 
            this.town_id.HeaderText = "Город";
            this.town_id.MinimumWidth = 6;
            this.town_id.Name = "town_id";
            this.town_id.ReadOnly = true;
            this.town_id.Visible = false;
            this.town_id.Width = 125;
            // 
            // townName
            // 
            this.townName.HeaderText = "Город";
            this.townName.MinimumWidth = 6;
            this.townName.Name = "townName";
            this.townName.ReadOnly = true;
            this.townName.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "категория";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // sex
            // 
            this.sex.HeaderText = "Пол";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 125;
            // 
            // burthYear
            // 
            this.burthYear.HeaderText = "Дата рождения";
            this.burthYear.MinimumWidth = 6;
            this.burthYear.Name = "burthYear";
            this.burthYear.ReadOnly = true;
            this.burthYear.Width = 125;
            // 
            // e_chipNumber
            // 
            this.e_chipNumber.HeaderText = "Номер э-чипа";
            this.e_chipNumber.MinimumWidth = 6;
            this.e_chipNumber.Name = "e_chipNumber";
            this.e_chipNumber.ReadOnly = true;
            this.e_chipNumber.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Кличка";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // photos
            // 
            this.photos.HeaderText = "Фото";
            this.photos.MinimumWidth = 6;
            this.photos.Name = "photos";
            this.photos.ReadOnly = true;
            this.photos.Width = 125;
            // 
            // specMarks
            // 
            this.specMarks.HeaderText = "Особые приметы";
            this.specMarks.MinimumWidth = 6;
            this.specMarks.Name = "specMarks";
            this.specMarks.ReadOnly = true;
            this.specMarks.Width = 125;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(547, 92);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(231, 43);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.OnButtonClick_AddAnimal);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(547, 140);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(231, 43);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.Delete);
            // 
            // button_View
            // 
            this.button_View.Location = new System.Drawing.Point(547, 44);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(231, 43);
            this.button_View.TabIndex = 4;
            this.button_View.Text = "Посмотреть";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.OnDoubleClick_LookAtAnimals);
            // 
            // button_Menu
            // 
            this.button_Menu.Location = new System.Drawing.Point(547, 428);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(231, 43);
            this.button_Menu.TabIndex = 5;
            this.button_Menu.Text = "На главную";
            this.button_Menu.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(794, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filter
            // 
            this.filter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Town,
            this.Categorya,
            this.Sexy});
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(73, 24);
            this.filter.Text = "фильтр";
            // 
            // Town
            // 
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(164, 26);
            this.Town.Text = "Город";
            // 
            // Categorya
            // 
            this.Categorya.Name = "Categorya";
            this.Categorya.Size = new System.Drawing.Size(164, 26);
            this.Categorya.Text = "Категория";
            // 
            // Sexy
            // 
            this.Sexy.Name = "Sexy";
            this.Sexy.Size = new System.Drawing.Size(164, 26);
            this.Sexy.Text = "Пол";
            // 
            // filterbutton
            // 
            this.filterbutton.Location = new System.Drawing.Point(547, 188);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(231, 43);
            this.filterbutton.TabIndex = 7;
            this.filterbutton.Text = "Отфильтровать";
            this.filterbutton.UseVisualStyleBackColor = true;
            // 
            // AnimalListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 485);
            this.Controls.Add(this.filterbutton);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnimalListForm";
            this.Text = "AnimalListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        internal DataGridView dataGridView1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_WinForm.Forms.Animal
{
    public partial class AnimalCard : Form
    {
        AnimalListForm formList;
        Card.Animal card;
        private Dictionary<int, Dictionary<string, string>> towns = DBAdapter.GetAll("Tows");
        private bool editing;
        public AnimalCard(Card.Animal card, AnimalListForm formList)
        {
            InitializeComponent();
            this.formList = formList;
            this.card = card;
            var x = 12;
            var y = 12;

            var atributs = new Dictionary<string, string>()
            {
                { "Категория", card.category },
                { "Пол", card.sex },
                { "Регистационнвый номер", card.regNum },
                { "Год рождения", card.burthYear },
                { "Город", card.town_id },
                { "Имя", card.name },
                { "Номер чипа", card.chipNumber },
                { "Фото", card.photos },
                { "Специальные приметы", card.specMarcks }
            };

            foreach (var atribut in atributs)
            {
                var label1 = new Label();
                label1.TextAlign = ContentAlignment.MiddleLeft;
                label1.AutoSize = true;
                label1.Parent = this;
                label1.Text = atribut.Key;
                label1.Location = new Point(x, y);
                var label2 = new Label();
                label2.AutoSize = true;
                label2.Parent = this;
                label2.Text = atribut.Value;
                label2.BorderStyle = BorderStyle.Fixed3D;
                label2.Location = new Point(x, y + label2.Size.Height);
                y += label2.Size.Height + label1.Size.Height + 5;
            }

            var buttonClose = new Button();
            buttonClose.Parent = this;
            buttonClose.Location = new Point(x, y);
            buttonClose.Text = "Закрыть";
            buttonClose.Click += Close;
            x += buttonClose.Size.Width;

            var buttonEdit = new Button();
            buttonEdit.Parent = this;
            buttonEdit.Location = new Point(x, y);
            buttonEdit.Text = "Изменить";
            buttonEdit.Click += OnButtonClick_EditOrganizations;

        }

        private void AnimalCard_Load(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e) => this.Close();

        
        private void OnButtonClick_EditOrganizations(object sender, EventArgs e)
        {

            try
            {
                editing = PermissionGuard.CanEdit("Animals");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK);
            }
            if (editing)
            {
                AddAnimalForm editF = new AddAnimalForm(formList, false);

                editF.id = card.id;
                editF.Text = "Edit";
                editF.label1.Text = "Редактирование карточки животного:";
                editF.textBoxRegNum.Text = card.regNum;
                editF.textBoxRegNum.Text = card.regNum;
                editF.comboBoxCateg.Text = card.category;
                editF.comboBoxSex.Text = card.sex;
                editF.numericUpDownYear.Value = Convert.ToInt32(card.burthYear);
                editF.textBoxChip.Text = card.chipNumber;
                editF.comboBoxTown.Text = card.town_id;
                editF.textBoxName.Text = card.name;
                editF.textBoxPhoto.Text = card.photos;
                editF.textBoxMarcs.Text = card.specMarcks;

                this.Hide();
                editF.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Недостаточно прав", "Ошибка прав доступа", MessageBoxButtons.OK);
            }
        }
    }
}

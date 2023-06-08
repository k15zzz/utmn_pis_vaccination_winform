using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Card;
using Controller;


namespace PIS_WinForm.Forms
{
    public partial class AddAnimalForm : Form
    {
        private Dictionary<string, string> filter = new Dictionary<string, string>();
        internal Card.Animal? animal;
        private Dictionary<int, Dictionary<string, string>> towns = DBAdapter.GetAll("Tows");
        private bool isItAdd;
        AnimalListForm formList;
        public AddAnimalForm(AnimalListForm formList, bool isItAdd, string townFromCard="")
        {
            this.formList = formList;
            this.isItAdd = isItAdd;
            InitializeComponent();
            
            string townFilter = PermissionGuard.GetTown();
            if (townFilter!= null)
            {
                MessageBox.Show("Для вас выбран город");
                filter.Add("town", townFilter);
                comboBoxTown.Text = townFilter;
                comboBoxTown.Enabled = false; // запрещаем что-либо вводить
            }
            else
            {
                foreach (var town in towns)
                {
                    comboBoxTown.Items.Add(town.Value["name"]);
                }
                if (!isItAdd)
                    comboBoxTown.Text = townFromCard;

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            filter.Add("regNum", textBoxRegNum.Text);
            foreach(var town in towns)
            {
                if (comboBoxTown.Text==town.Value["name"])
                    filter.Add("town_id", town.Key.ToString());
            }
            filter.Add("category", comboBoxCateg.Text);
            filter.Add("sex", comboBoxSex.Text);
            filter.Add("burthYear", numericUpDownYear.Value.ToString()); 
            filter.Add("e-chipNumber", textBoxChip.Text);
            filter.Add("name", textBoxName.Text);
            filter.Add("photos", textBoxPhoto.Text);
            filter.Add("specMarcks", textBoxMarcs.Text);

            bool added=false;
            animal = new Card.Animal(filter);
            try 
            {
                added = Controller.Animal.Add(animal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK);
                filter = new Dictionary<string, string>();
            }
            if (added)
            {
                if (isItAdd)
                    MessageBox.Show("Карточка успешно добавлена", "Добавление", MessageBoxButtons.OK);
                else
                {
                    MessageBox.Show("Карточка успешно изменена", "Изменение", MessageBoxButtons.OK);
                    
                }
                var id = DBAdapter.NewIdAnimal();
                formList.dataGridView1.Rows.Add
                    (
                    id-1,
                    animal.regNum,
                    animal.town_id,
                    comboBoxTown.Text,
                    animal.category,
                    animal.sex,
                    animal.burthYear,
                    animal.chipNumber,
                    animal.name,
                    animal.photos,
                    animal.specMarcks
                    );
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

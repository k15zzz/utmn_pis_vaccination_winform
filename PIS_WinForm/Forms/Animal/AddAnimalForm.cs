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
        public AddAnimalForm()
        {
            InitializeComponent();
            string townFilter = PermissionGuard.GetTown();
            if (townFilter!= null)
            {
                MessageBox.Show("Для вас выбран город");
                filter.Add("town", townFilter);
                textBoxTown.Text = townFilter;
                textBoxTown.Enabled = false; // запрещаем что-либо вводить
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            filter.Add("category", comboBox1.DisplayMember.ToString());
            filter.Add("gender", comboBox2.DisplayMember.ToString());
            filter.Add("yearBirth", numericUpDown1.Value.ToString());
            filter.Add("town", textBoxTown.Text);
            filter.Add("name", textBox5.Text);
            filter.Add("chip", textBox6.Text);
            filter.Add("signs", textBox7.Text);
            //добавить фото - путь к фотке

            

            animal = new Card.Animal(filter);
           // Controller.Animal.Add(animal);
        }
    }
}

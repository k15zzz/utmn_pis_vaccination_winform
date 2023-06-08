using PIS_WinForm.Forms.Animal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PIS_WinForm.Forms
{
    public partial class AnimalListForm : Form
    {


        public AnimalListForm(Dictionary<int, Dictionary<string, string>> cards)
        {
            List<string>[] t = new[] { new List<string>(), new List<string>(), new List<string>() };
            InitializeComponent();

            foreach (var card in cards)
            {
                dataGridView1.Rows.Add
                    (
                    card.Key,
                    cards[card.Key]["regNum"],
                    cards[card.Key]["town_id"],
                    cards[card.Key]["townName"],
                    cards[card.Key]["сategory"],
                    cards[card.Key]["sex"],
                    cards[card.Key]["burthYear"],
                    cards[card.Key]["e-chipNumber"],
                    cards[card.Key]["name"],
                    cards[card.Key]["photos"],
                    cards[card.Key]["specMarcks"]
                    );

                if (!t[0].Contains(cards[card.Key]["townName"]))
                {
                    t[0].Add(cards[card.Key]["townName"]);
                    t[0].Add(cards[card.Key]["town_id"]);
                };
                if (!t[1].Contains(cards[card.Key]["сategory"])) t[1].Add(cards[card.Key]["сategory"]);
                if (!t[2].Contains(cards[card.Key]["sex"])) t[2].Add(cards[card.Key]["sex"]);
            }

            for (var i = 0; i < t[0].Count - 1; i += 2)
            {
                var stripItem = new ToolStripMenuItem();
                stripItem.Text = t[0][i].ToString();
                stripItem.CheckOnClick = true;
                stripItem.Tag = t[0][i + 1].ToString();
                Town.DropDownItems.Add(stripItem);
            }

            foreach (var tone in t[1])
            {
                var stripItem = new ToolStripMenuItem();
                stripItem.Text = tone.ToString();
                stripItem.CheckOnClick = true;
                Categorya.DropDownItems.Add(stripItem);
            }
            foreach (var tone in t[2])
            {
                var stripItem = new ToolStripMenuItem();
                stripItem.Text = tone.ToString();
                stripItem.CheckOnClick = true;
                Sexy.DropDownItems.Add(stripItem);
            }
        }

        bool adding;
        private void OnButtonClick_AddAnimal(object sender, EventArgs e)
        {
            try
            {
                adding = PermissionGuard.CanAdd("Animals");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK);
            }

            //запрашиваем город, вернется  null или город. если город - то кидаем
            //сообщение мол вам доступен этот город (выбран за вас), его же заполняем
            // в фильтр . Высвечиваем форму, чел заполняет поля. создаем карточку
            // (точно?). Далее добавляем в контроллер. там проверка как в начале. Тогда контроллер отдает
            // в модельку, она проверяет пустые пля. кидаем алерт если незаполненны, иначе добавляем в
            // (?)модель. И потом в бд

            if (adding)
            {
                AddAnimalForm addF = new AddAnimalForm(this);
                this.Hide();
                addF.ShowDialog();
                //
                
                this.Show();
            }
            else
            {
                MessageBox.Show("Недостаточно прав", "Ошибка прав доступа", MessageBoxButtons.OK);
            }



        }

        private void button_View_Click(object sender, EventArgs e)
        {
        }

        private void Delete(object sender, EventArgs e)
        {
            if (PermissionGuard.CanDelete("Animals"))
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = (int)dataGridView1.SelectedCells[0].Value;
                Delete_Animal delete = new Delete_Animal(id, row);
                delete.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет прав на это действие");
            }
            Dictionary<string, List<string>> filter = new Dictionary<string, List<string>>();

            filter.Add("town_id", new List<string>());
            foreach (ToolStripMenuItem item in Town.DropDownItems)
                if (item.Checked) filter["town_id"].Add(item.Tag.ToString());

            filter.Add("сategory", new List<string>());
            foreach (ToolStripMenuItem item in Categorya.DropDownItems)
                if (item.Checked) filter["сategory"].Add(item.Text);

            filter.Add("sex", new List<string>());
            foreach (ToolStripMenuItem item in Sexy.DropDownItems)
                if (item.Checked) filter["sex"].Add(item.Text);

            Dictionary<int, Dictionary<string, string>> cards = new Dictionary<int, Dictionary<string, string>>();
            try
            {
                PermissionGuard.CanLookAll("Animals");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "you cant look at yhis list", MessageBoxButtons.OK);
            }

            try
            {
                cards = Controller.Animal.LookAll(filter);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "you cant look at yhis list", MessageBoxButtons.OK);
            }

            dataGridView1.Rows.Clear();

            foreach (var card in cards)
            {
                dataGridView1.Rows.Add
                    (
                    card.Key,
                    cards[card.Key]["regNum"],
                    cards[card.Key]["town_id"],
                    cards[card.Key]["townName"],
                    cards[card.Key]["сategory"],
                    cards[card.Key]["sex"],
                    cards[card.Key]["burthYear"],
                    cards[card.Key]["e-chipNumber"],
                    cards[card.Key]["name"],
                    cards[card.Key]["photos"],
                    cards[card.Key]["specMarcks"]
                    );
            }

        }

        private void button_Menu_Click(object sender, EventArgs e) => this.Close();

        private void filterbutton_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> filter = new Dictionary<string, List<string>>();

            filter.Add("town_id", new List<string>());
            foreach (ToolStripMenuItem item in Town.DropDownItems)
                if (item.Checked) filter["town_id"].Add(item.Tag.ToString());

            filter.Add("сategory", new List<string>());
            foreach (ToolStripMenuItem item in Categorya.DropDownItems)
                if (item.Checked) filter["сategory"].Add(item.Text);

            filter.Add("sex", new List<string>());
            foreach (ToolStripMenuItem item in Sexy.DropDownItems)
                if (item.Checked) filter["sex"].Add(item.Text);

            Dictionary<int, Dictionary<string, string>> cards = new Dictionary<int, Dictionary<string, string>>();
            try
            {
                PermissionGuard.CanLookAll("Animals");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "you cant look at yhis list", MessageBoxButtons.OK);
            }

            try
            {
                cards = Controller.Animal.LookAll(filter);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "you cant look at yhis list", MessageBoxButtons.OK);
            }

            dataGridView1.Rows.Clear();

            foreach (var card in cards)
            {
                dataGridView1.Rows.Add
                    (
                    card.Key,
                    cards[card.Key]["regNum"],
                    cards[card.Key]["town_id"],
                    cards[card.Key]["townName"],
                    cards[card.Key]["сategory"],
                    cards[card.Key]["sex"],
                    cards[card.Key]["burthYear"],
                    cards[card.Key]["e-chipNumber"],
                    cards[card.Key]["name"],
                    cards[card.Key]["photos"],
                    cards[card.Key]["specMarcks"]
                    );
            }
        }

        private void OnDoubleClick_LookAtContract(object sender, EventArgs e)
        {
            var SelectedRow = dataGridView1.SelectedRows[0];
            var animalCard = Controller.Animal.LookAtCard(SelectedRow);
            var animalCardForm = new AnimalCard(animalCard);
            this.Hide();
            animalCardForm.ShowDialog();
            this.Show();


        }

        private void button_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}

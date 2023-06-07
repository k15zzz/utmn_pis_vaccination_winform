using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_WinForm.Forms
{
    public partial class AnimalListForm : Form
    {
        public AnimalListForm(Dictionary<int, Dictionary<string, string>> cards)
        {
            InitializeComponent();

            for (var i = 1; i <= cards.Count; i++)
            {
                dataGridView1.Rows.Add(i, cards[i]["regNum"], cards[i]["town_id"], cards[i]["сategory"], cards[i]["sex"], cards[i]["burthYear"], cards[i]["e-chipNumber"], cards[i]["name"], cards[i]["photos"], cards[i]["specMarcks"]);

                if (!bngngngnToolStripMenuItem.DropDownItems.Contains(new ToolStripMenuItem(cards[i]["town_id"])))
                    bngngngnToolStripMenuItem.DropDownItems.Add(cards[i]["town_id"]);

                if (!категорияToolStripMenuItem.DropDownItems.ContainsKey(cards[i]["сategory"]))
                    категорияToolStripMenuItem.DropDownItems.Add(cards[i]["сategory"]);

                if (!полToolStripMenuItem.DropDownItems.ContainsKey(cards[i]["sex"]))
                    полToolStripMenuItem.DropDownItems.Add(cards[i]["sex"]);
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
                AddAnimalForm addF = new AddAnimalForm();
                this.Hide();
                addF.ShowDialog();
                this.Show();
            }



        }

        private void button_View_Click(object sender, EventArgs e)
        {
        }

        private void Delete(object sender, EventArgs e)
        {
            if (PermissionGuard.CanDelete("Animal"))
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
        }
    }
}

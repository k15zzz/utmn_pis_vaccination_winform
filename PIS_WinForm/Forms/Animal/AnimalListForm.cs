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
            dataGridView1.Rows.Add(cards);

            InitializeComponent();
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
                addF.ShowDialog();
            }



        }

        private void button_View_Click(object sender, EventArgs e)
        {
        }
    }
}

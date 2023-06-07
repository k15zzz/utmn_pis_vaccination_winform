﻿using System;
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
        public AnimalListForm()
        {
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
            // в фильтр . Высвечиваем форму, чел заполняет поля.
            // создаем карточку
            // Далее добавляем в контроллер. там проверка как в начале. контроллер отдает
            // в модельку, она проверяет пустые пля. кидаем алерт если незаполненны,
            // если ок, модель вернет карту  в адаптер, и выводим алерты
            // что все хоорошо
            if (adding)
            {
                AddAnimalForm addF = new AddAnimalForm();
                addF.ShowDialog();
            }
        }
    }
}
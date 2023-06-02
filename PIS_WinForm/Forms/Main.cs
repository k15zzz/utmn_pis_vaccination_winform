using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace PIS_WinForm.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SetTown(Town.LookAll());
        }

        private void calculateStatisticButton_Click(object sender, EventArgs e)
        {
            if (!PermissionGuard.CanStatistic())
            {
                MessageBox.Show("Ошибка доступа", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void SetTown(Dictionary<int, Dictionary<string, string>> tows)
        {
            foreach (var item in tows)
                townsCheckedListBox.Items.Add(item.Value["name"]);
        }

        private void OnButtonClick_LookAllAnimals(object sender, EventArgs e)
        {
            try
            {
                PermissionGuard.CanAdd("Animals");
            }
            catch(Exception ex)
            {
                MessageBox.Show("You can`t view this list!", ex.Message, MessageBoxButtons.OK);
            }

            //Dictionary<string, string> filter = new Dictionary<string, string>()
            //{
            //    { }
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Controller;

namespace PIS_WinForm.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SetListBoxTowns(Town.LookAll());
        }

        private void calculateStatisticButton_Click(object sender, EventArgs e)
        {
            if (!PermissionGuard.CanStatistic())
            {
                MessageBox.Show("Ошибка доступа", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idList = GetCheckedListBoxTowns();

            if (idList.Count == 0)
            {
                MessageBox.Show("Город не выбран!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startDateTime = startDateTimePicker.Value;
            DateTime firstDateTime = finishDateTimePicker.Value;


            var retort = Statistic.MakeReport(startDateTime, firstDateTime, idList);
            var retoryForm = new Report(retort);
            retoryForm.ShowDialog();

            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<int> GetCheckedListBoxTowns()
        {
            List<int> idList = new List<int>();

            string pattern = @"(\d+)";

            foreach (object item in townsCheckedListBox.CheckedItems)
            {
                string text = item.ToString();
                Match match = Regex.Match(text, pattern);
                if (match.Success)
                {
                    int id = int.Parse(match.Groups[1].Value);
                    idList.Add(id);
                }
            }

            return idList;
        }

        private void SetListBoxTowns(Dictionary<int, Dictionary<string, string>> tows)
        {
            foreach (var item in tows)
                townsCheckedListBox.Items.Add($"{item.Value["name"]}({item.Key})");
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

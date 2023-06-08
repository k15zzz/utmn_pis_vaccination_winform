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
using PIS_WinForm.Forms.Contract;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            var filter = new Dictionary<string, List<string>>()
            {
                {
                    "town_id",
                    new List<string>() { PermissionGuard.GetTown() }
                }
            };

            Dictionary<int, Dictionary<string, string>> cards = new Dictionary<int, Dictionary<string, string>>();
            try
            {
                cards = GetCards("Animals", filter, Controller.Animal.LookAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Visible = false;

            AnimalListForm _form = new AnimalListForm(cards);
            _form.ShowDialog();

            this.Visible = true;
        }

        private void OnButtonClick_LookAllContracts(object sender, EventArgs e)
        {
            var filter = new Dictionary<string, List<string>>()
            {
                {
                    "town_id",
                    new List<string>() { PermissionGuard.GetTown() }
                }
            };
            Dictionary<int, Dictionary<string, string>> cards = new Dictionary<int, Dictionary<string, string>>();
            try
            {
                cards = GetCards("Contracts", filter, Controller.Contract.LookAll);
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Visible = false;

            ContractListForm _form = new ContractListForm(cards);
            _form.ShowDialog();

            this.Visible = true;
        }

        private Dictionary<int, Dictionary<string, string>> GetCards(
            string reestrName,
            Dictionary<string, List<string>> filters,
            Func<Dictionary<string, List<string>>, Dictionary<int, Dictionary<string, string>>> controller)
        {
            if (PermissionGuard.CanLookAll(reestrName))
                try
                {
                    return controller(filters);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            else
                throw new Exception("Ошибка прав доступа");
        }
    }
}

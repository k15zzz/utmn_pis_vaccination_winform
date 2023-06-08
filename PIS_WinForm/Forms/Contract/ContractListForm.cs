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


namespace PIS_WinForm.Forms.Contract
{
    public partial class ContractListForm : Form
    {
        public ContractListForm(Dictionary<int, Dictionary<string, string>> cards)
        {
            List<string>[] t = new[] { new List<string>(), new List<string>() };
            InitializeComponent();

            foreach (var card in cards)
            {
                dataGridView1.Rows.Add
                    (
                    card.Key,
                    cards[card.Key]["number"],
                    cards[card.Key]["startDate"],
                    cards[card.Key]["endDate"],
                    cards[card.Key]["ispolnitel_id"],
                    cards[card.Key]["ispolnitelName"],
                    cards[card.Key]["zacazchik_id"],
                    cards[card.Key]["zacazchikName"]
                    );

                if (!t[0].Contains(cards[card.Key]["ispolnitelName"]))
                {
                    t[0].Add(cards[card.Key]["ispolnitelName"]);
                    t[0].Add(cards[card.Key]["ispolnitel_id"]);
                };
                if (!t[1].Contains(cards[card.Key]["zacazchikName"]))
                {
                    t[1].Add(cards[card.Key]["zacazchikName"]);
                    t[1].Add(cards[card.Key]["zacazchik_id"]);
                };
            }

            for (var i = 0; i < t[0].Count - 1; i += 2)
            {
                var stripItem = new ToolStripMenuItem();
                stripItem.Text = t[0][i].ToString();
                stripItem.CheckOnClick = true;
                stripItem.Tag = t[0][i + 1].ToString();
                Ispolnitel.DropDownItems.Add(stripItem);
            }
            for (var i = 0; i < t[1].Count - 1; i += 2)
            {
                var stripItem = new ToolStripMenuItem();
                stripItem.Text = t[1][i].ToString();
                stripItem.CheckOnClick = true;
                stripItem.Tag = t[1][i + 1].ToString();
                Zakazchic.DropDownItems.Add(stripItem);
            }
        }

        private void button_Menu_Click(object sender, EventArgs e) => Close();

        private void button_View_Click(object sender, EventArgs e)
        {
            var SelectedRow = dataGridView1.SelectedRows[0];
            var contractlCard = Controller.Contract.LookAtCard(SelectedRow);
            var contractCardForm = new ContractCard(contractlCard);
            this.Hide();
            contractCardForm.ShowDialog();
            this.Show();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (PermissionGuard.CanDelete("Animals"))
            {
                var row = dataGridView1.SelectedRows[0];
                int id = (int)dataGridView1.SelectedCells[0].Value;
                var delete = new Delete_Contract(id, row);
                delete.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет прав на это действие");
            }
            //TODO: открыть после реализации функции 
            //SerFilter();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //TODO: реализация добавления контактов
        }

        private void button_Menu_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        /*
        private void SerFilter()
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
        */
    }
}

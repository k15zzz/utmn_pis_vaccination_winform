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

        private void ContractListForm_Load(object sender, EventArgs e)
        {

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

        private void filterbutton_Click(object sender, EventArgs e)
        {

        }
    }
}

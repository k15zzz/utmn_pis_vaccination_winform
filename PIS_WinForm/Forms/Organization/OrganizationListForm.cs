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

namespace PIS_WinForm.Forms.Organization
{
    public partial class OrganizationListForm : Form
    {
        public OrganizationListForm(Dictionary<int, Dictionary<string, string>> cards)
        {
            List<string>[] t = new[] { new List<string>(), new List<string>(), new List<string>() };
            InitializeComponent();

            foreach (var card in cards)
            {
                dataGridView1.Rows.Add
                    (
                    card.Key,
                    cards[card.Key]["fullName"],
                    cards[card.Key]["INN"],
                    cards[card.Key]["KPP"],
                    cards[card.Key]["aderss"],
                    cards[card.Key]["type"],
                    cards[card.Key]["UrFace"],
                    cards[card.Key]["town_id"],
                    cards[card.Key]["townName"]
                    );

                if (!t[0].Contains(cards[card.Key]["townName"]))
                {
                    t[0].Add(cards[card.Key]["townName"]);
                    t[0].Add(cards[card.Key]["town_id"]);
                };
                if (!t[1].Contains(cards[card.Key]["type"])) t[1].Add(cards[card.Key]["type"]);
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
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            DataGridViewRow SelectedRow = new DataGridViewRow();
            try
            {
                SelectedRow = dataGridView1.SelectedRows[0];
            }
            catch
            {
                MessageBox.Show("Невозмозно посмотреть карточку, так как ни одна не выбрана");
                return;
            }
            var organizationCard = Controller.Organization.LookAtCard(SelectedRow);
            var organizationCardForm = new OrganizationCard(organizationCard);
            this.Hide();
            organizationCardForm.ShowDialog();
            this.Show();
        }

        private void button_Menu_Click(object sender, EventArgs e) => this.Close();

        private void SerFilter()
        {
            Dictionary<string, List<string>> filter = new Dictionary<string, List<string>>();

            filter.Add("town_id", new List<string>());
            foreach (ToolStripMenuItem item in Town.DropDownItems)
                if (item.Checked) filter["town_id"].Add(item.Tag.ToString());

            filter.Add("type", new List<string>());
            foreach (ToolStripMenuItem item in Categorya.DropDownItems)
                if (item.Checked) filter["type"].Add(item.Text);

            Dictionary<int, Dictionary<string, string>> cards = new Dictionary<int, Dictionary<string, string>>();

            if (PermissionGuard.CanLookAll("Organizations"))
                try
                {
                    cards = Controller.Organization.LookAll(filter);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "you cant look at yhis list", MessageBoxButtons.OK);
                }
            else
                MessageBox.Show("У вас нет прав на это", "you cant look at yhis list", MessageBoxButtons.OK);

            dataGridView1.Rows.Clear();

            foreach (var card in cards)
            {
                dataGridView1.Rows.Add
                    (
                    card.Key,
                    cards[card.Key]["fullName"],
                    cards[card.Key]["INN"],
                    cards[card.Key]["KPP"],
                    cards[card.Key]["aderss"],
                    cards[card.Key]["type"],
                    cards[card.Key]["UrFace"],
                    cards[card.Key]["town_id"],
                    cards[card.Key]["townName"]
                    );
            }
        }

        private void filterbutton_Click(object sender, EventArgs e) => SerFilter();
    }
}
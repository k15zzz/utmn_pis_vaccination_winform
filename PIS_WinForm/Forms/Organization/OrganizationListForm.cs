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
                    cards[card.Key]["townName"],
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

        }
    }
}

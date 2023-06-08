using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_WinForm.Forms.Organization
{
    public partial class OrganizationCard : Form
    {
        public OrganizationCard(Card.Organization card)
        {
            InitializeComponent();

            var x = 12;
            var y = 12;

            var atributs = new Dictionary<string, string>()
            {
                { "Полное наименование организации", card.fullName },
                { "ИНН", card.INN },
                { "КПП", card.KPP },
                { "Адрес регистрации", card.aderss },
                { "Тип организации", card.type },
                { "ИП/Юридическое лицо", card.UrFace },
                { "Населённый пункт", card.town_id },
            };

            foreach (var atribut in atributs)
            {
                var label1 = new Label();
                label1.TextAlign = ContentAlignment.MiddleLeft;
                label1.AutoSize = true;
                label1.Parent = this;
                label1.Text = atribut.Key;
                label1.Location = new Point(x, y);
                var label2 = new Label();
                label2.AutoSize = true;
                label2.Parent = this;
                label2.Text = atribut.Value;
                label2.BorderStyle = BorderStyle.Fixed3D;
                label2.Location = new Point(x, y + label2.Size.Height);
                y += label2.Size.Height + label1.Size.Height + 5;
            }

            var buttonClose = new Button();
            buttonClose.Parent = this;
            buttonClose.Location = new Point(x, y);
            buttonClose.Text = "Закрыть";
            buttonClose.Click += Close;
            x += buttonClose.Size.Width;

            var buttonEdit = new Button();
            buttonEdit.Parent = this;
            buttonEdit.Location = new Point(x, y);
            buttonEdit.Text = "Изменить";
            buttonEdit.Click += OnButtonClick_EditOrganizations;
        }

        private void Close(object sender, EventArgs e) => this.Close();

        private void OnButtonClick_EditOrganizations(object sender, EventArgs e)
            => throw new NotImplementedException();
    }
}

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
    public partial class Delete_Animal : Form
    {
        int id;
        public Delete_Animal(Card.Animal animal, int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Ok(object sender, EventArgs e)
        {
            Controller.Animal.Delete(id);
            Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}

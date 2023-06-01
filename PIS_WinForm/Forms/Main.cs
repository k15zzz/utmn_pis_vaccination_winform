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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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

            Dictionary<string, string> filter = new Dictionary<string, string>()
            {
                { }
            }
        }
    }
}

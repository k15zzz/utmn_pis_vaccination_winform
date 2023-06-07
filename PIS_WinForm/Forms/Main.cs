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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void OnButtonClick_LookAllAnimals(object sender, EventArgs e)
        {
            this.Visible = false;
            try
            {
                PermissionGuard.CanLookAll("Animals");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "you cant look at yhis list", MessageBoxButtons.OK);
            }
            var filter = new Dictionary<string, List<string>>() { { "town_id", new List<string>() { PermissionGuard.GetTown() } } };

            try
            {
                Controller.Animal.LookAll(filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "you cant look at yhis list", MessageBoxButtons.OK);
            }
            this.Visible = true;
        }
    }
}

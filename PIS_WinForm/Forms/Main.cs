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
            try
            {
                PermissionGuard.CanLookAll("Animals");
            }
            catch(Exception ex)
            {
                MessageBox.Show("you cant look at yhis list", ex.Message, MessageBoxButtons.OK);
            }

            var filter = new Dictionary<string, string>()
            {
                {"town_id", PermissionGuard.GetTown() }
            };

            var sort = new Dictionary<string, string>();

            try
            {
                Controller.Animal.LookAll(filter, sort);
            }
            catch (Exception ex)
            {
                MessageBox.Show("you cant look at yhis list", ex.Message, MessageBoxButtons.OK);
            }            
        }
    }
}

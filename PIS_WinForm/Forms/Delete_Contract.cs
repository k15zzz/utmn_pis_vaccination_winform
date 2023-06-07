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
    public partial class Delete_Contract : Form
    {
        int id;
        public Delete_Contract(int id, DataGridViewRow row)
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString();
            this.id = id;
        }

        private void Yes(object sender, EventArgs e)
        {
            Contracts.Delete(id);
            MessageBox.Show("Контракт успешно удален");
            this.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

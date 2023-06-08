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
        public Delete_Animal(int id, DataGridViewRow row)
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString();
            textBox6.Text = row.Cells[6].Value.ToString();
            textBox7.Text = row.Cells[7].Value.ToString();
            textBox8.Text = row.Cells[8].Value.ToString();
            textBox9.Text = row.Cells[9].Value.ToString();
            this.id = id;
        }

        private void Delete_Animal_Load(object sender, EventArgs e)
        {

        }

        private void Ok(object sender, EventArgs e)
        {
            Controller.Animal.Delete(id);
            MessageBox.Show("Животное успешно удалено");
            this.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}

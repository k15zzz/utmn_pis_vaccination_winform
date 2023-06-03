using PIS_WinForm;
using PIS_WinForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_WinForm
{
    public partial class LogIn : Form
    {
        private string _errorlabel = "Пароль или логин неверен";

        public LogIn()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;

            try 
            { 
                PermissionGuard.ValidateUser(login, password);
                Main mainForm = new Main();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        public void ResetError()
        {
            errorLabel.Text = "";
        }

        public void SetError()
        {
            errorLabel.Text = this._errorlabel;
        }

        public bool ValidateLogin(string login)
        {
            string pattern = @"^[a-zA-Z0-9]+$";
            return Regex.IsMatch(login, pattern);
        }

        public bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}

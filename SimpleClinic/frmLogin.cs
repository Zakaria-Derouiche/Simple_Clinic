using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicBusiness;
using Microsoft.Win32;

namespace SimpleClinic
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtBoxUserName.Focus();

        }
        private void txtBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled =  !char.IsControl(e.KeyChar);
        }
        private bool _CheckInputsValidation()
        {
            return !string.IsNullOrEmpty(txtBoxUserName.Text.Trim()) && !string.IsNullOrEmpty(txtBoxPassword.Text.Trim());
        }

        private void _CheckUserExistence()
        {
            if (clsUser.IsUserExistByUserName(clsEncryptionDecryption.Encrypt(txtBoxUserName.Text.Trim()),
                ref clsGlobal.ErrorMessage))
            {

                clsGlobal.CurrentUser = clsUser.GetUserInfoByUserName(clsEncryptionDecryption.Encrypt(txtBoxUserName.Text.Trim()),
                    ref clsGlobal.ErrorMessage);
                
                _CheckPassword();
            }
            else
            {
                MessageBox.Show("No User With This User Name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void _DeleteLoginInfo()
        {
            txtBoxUserName.Text = string.Empty;
            txtBoxPassword.Text = string.Empty;
        }

        private void _CheckPassword()
        {

            if(clsEncryptionDecryption.ComputeHash(txtBoxPassword.Text.Trim()) == clsGlobal.CurrentUser.Password)
            {
                

                frmMenu menu = new frmMenu(this);

                
                this.Hide();

                menu.ShowDialog();

                _DeleteLoginInfo();

            }else
            {
                MessageBox.Show("Wrong Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void _Login()
        {
            if (_CheckInputsValidation())
            {
                _CheckUserExistence();
            }
            else
            {
                MessageBox.Show("Invalid Inputs", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _Login();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicBusiness;

namespace SimpleClinic
{
    public partial class frmLogin : Form
    {
        private string ErrorMessage = string.Empty;
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
        private bool CheckInputsValidation()
        {
            return string.IsNullOrEmpty(txtBoxUserName.Text.Trim()) || string.IsNullOrEmpty(txtBoxPassword.Text.Trim());
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

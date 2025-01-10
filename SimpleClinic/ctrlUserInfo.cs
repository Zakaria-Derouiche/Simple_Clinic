using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class ctrlUserInfo : UserControl
    {
        clsUser _User = new clsUser();
        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(clsUser User)
        {
            _User = User;

            _User.Password = clsEncryptionDecryption.Decrypt(User.Password);

            _User.Permission = clsEncryptionDecryption.Decrypt(User.Permission);

            lblUserID.Text = User != null && User.UserID > 0 ? User.UserID.ToString() : "[???]";

            lblEmployeeID.Text = User != null && User.UserID > 0 ? User.EmployeeID.ToString() : "[???]";

            lblUserName.Text = User != null && User.UserID > 0 ? clsEncryptionDecryption.Decrypt(User.UserName) : "[???]";

            linkLblEmployeeInfo.Visible = User != null && User.UserID > 0;

            linkLblUserPermissions.Visible = User != null && User.UserID > 0;
        }

        private void linkLblUserPermissions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserPermissions permissions = new frmUserPermissions(_User.Permission, true, this.ParentForm);

            ParentForm.Hide();

            permissions.ShowDialog();
        }

        private void linkLblEmployeeInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeeInfo Employee = new frmEmployeeInfo(_User.EmployeeID, this.ParentForm);

            ParentForm.Hide();

            Employee.ShowDialog();
        }
    }
}

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
            if (_User != null)
            {
                _User.UserName = clsEncryptionDecryption.Decrypt(_User.UserName);

                _User.Permission = clsEncryptionDecryption.Decrypt(_User.Permission);
            }
           

            lblUserID.Text = _User != null && _User.UserID > 0 ? _User.UserID.ToString() : "[???]";

            lblEmployeeID.Text = _User != null && _User.UserID > 0 ? _User.EmployeeID.ToString() : "[???]";

            lblUserName.Text = _User != null && _User.UserID > 0 ? _User.UserName : "[???]";

            linkLblEmployeeInfo.Visible = _User != null && _User.UserID > 0;

            linkLblUserPermissions.Visible = _User != null && _User.UserID > 0;

            lblIsActive.Text = _User == null || _User.UserID < 1 ? "[???]" : _User.IsActive? "Yes" : "No" ;

           
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

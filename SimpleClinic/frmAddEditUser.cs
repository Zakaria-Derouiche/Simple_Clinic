using ClinicBusiness;
using SimpleClinic.Properties;
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
    public partial class frmAddEditUser : Form
    {
        private enum enMode { Add, Edit}

        private enMode _Mode;

        clsUser _User = new clsUser();
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _User = clsUser.GetUserInfoByID(UserID, ref clsGlobal.ErrorMessage);

            _Mode = _User == null || _User.ID == -1 ? enMode.Add : enMode.Edit;

            ctrlEmployeeWithFilter1.SelectedEmployee += _Raise;
        }

        private void _Raise(object sender, EventArgs e)
        {
            if(clsUser.IsUserExistByEmployeeID(ctrlEmployeeWithFilter1.Employee.EmployeeID, ref clsGlobal.ErrorMessage))
            {
                _User = clsUser.GetUserInfoByEmployeeID(ctrlEmployeeWithFilter1.Employee.EmployeeID, ref clsGlobal.ErrorMessage);

                _LoadUserInfo();

            }
            gBoxUserInfo.Enabled = ctrlEmployeeWithFilter1.Employee != null && ctrlEmployeeWithFilter1.Employee.EmployeeID > 0;
        }
        private void _LoadUserInfo()
        {

            txtBoxUserName.Text = _Mode == enMode.Add? "" : _User.UserName;

            txtBoxPassword.Text = _Mode == enMode.Add ? "" : _User.Password;

            rbFullControl.Checked = _Mode == enMode.Add ? false : _User.Permission == "All" ? true : false;

            rbCustom.Checked = _Mode == enMode.Add ? false : _User.Permission != "All" ? true : false;

        }

        private void _PrepareFormInfo()
        {
            lblTitle.Text = _Mode == enMode.Add ? "Add New User" : "Update User Info";

            lblTitle.Location = new Point((this.Size.Width / 2) - (lblTitle.Size.Width / 2) , 13);

            gBoxUserInfo.Enabled = ctrlEmployeeWithFilter1.Employee != null && ctrlEmployeeWithFilter1.Employee.EmployeeID > 0;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _PrepareFormInfo();

            ctrlEmployeeWithFilter1.LoadEmployeeInfo((clsEmployee)_User);

            _LoadUserInfo();
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = !txtBoxPassword.UseSystemPasswordChar;

            btnShowHidePassword.BackgroundImage = txtBoxPassword.UseSystemPasswordChar ? Resources.eye : Resources.HidePassword1;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbCustom_Click(object sender, EventArgs e)
        {
            if (rbCustom.Checked)
            {
                string UserPermissions = _Mode == enMode.Add ? string.Empty : _User.Permission;

                frmUserPermissions Permissions = new frmUserPermissions(ref UserPermissions);

                Permissions.Show();
            }
        }
    }
}

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

        private bool _IsUserPermissionChanged;

        clsUser _User = new clsUser();
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _User = clsUser.GetUserInfoByID(UserID, ref clsGlobal.ErrorMessage);

            _Mode = _User == null || _User.ID == -1 ? enMode.Add : enMode.Edit;

            ctrlEmployeeWithFilter1.SelectedEmployee += _Raise;

            _IsUserPermissionChanged = false;
        }

        private void _Raise(object sender, EventArgs e)
        {
            if(ctrlEmployeeWithFilter1.Employee != null && ctrlEmployeeWithFilter1.Employee.EmployeeID > 0 && 
                clsUser.IsUserExistByEmployeeID(ctrlEmployeeWithFilter1.Employee.EmployeeID, ref clsGlobal.ErrorMessage))
            {

                _User = clsUser.GetUserInfoByEmployeeID(ctrlEmployeeWithFilter1.Employee.EmployeeID, ref clsGlobal.ErrorMessage);

                _DecryptFetechedData();

                _LoadUserInfoToForm();

            }
            gBoxUserInfo.Enabled = _Mode == enMode.Edit;
        }

        private void _DecryptFetechedData()
        {
            _User.UserName = clsEncryptionDecryption.Decrypt(_User.UserName);

            _User.Permission = clsEncryptionDecryption.Decrypt(_User.Permission);
        }
        private void _LoadUserInfoToForm()
        {

            lblUserID.Text = _Mode == enMode.Add ? "N/A" : _User.UserID.ToString();

            txtBoxUserName.Text = _Mode == enMode.Add? "" : _User.UserName;

            txtBoxPassword.Text =  "" ;

            rbFullControl.Checked = _Mode == enMode.Add ? false : _User.Permission == "Full Control" ? true : false;

            rbCustom.Checked = _Mode == enMode.Add ? false : _User.Permission != "Full Control" ? true : false;

        }

        private void _PrepareFormInfo()
        {
            lblTitle.Text = _Mode == enMode.Add ? "Add New User" : "Update User Info";

            lblTitle.Location = new Point((this.Size.Width / 2) - (lblTitle.Size.Width / 2) , 13);

            gBoxUserInfo.Enabled = _Mode == enMode.Edit;

            
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {

            ctrlEmployeeWithFilter1.LoadEmployeeInfo((clsEmployee)_User);

            _PrepareFormInfo();

            _DecryptFetechedData();

            _LoadUserInfoToForm();
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = !txtBoxPassword.UseSystemPasswordChar;

            btnShowHidePassword.BackgroundImage = txtBoxPassword.UseSystemPasswordChar ? Resources.eye : Resources.HidePassword1;

        }


        private bool _IsUserDataChanged()
        {
            return _User.UserName != txtBoxUserName.Text.Trim() || _IsUserPermissionChanged 
                || clsEncryptionDecryption.ComputeHash(txtBoxPassword.Text.Trim()) != _User.Password;
            
        }

        private void _PrepareUserData()
        {
            if (_Mode == enMode.Add || _IsUserDataChanged())
            {
                _LoadUserInfoFromForm();
            }
           
        }

        private void _LoadUserInfoFromForm ()
        {
           
            _User.UserName = clsEncryptionDecryption.Encrypt(txtBoxUserName.Text.Trim());

            _User.Password = clsEncryptionDecryption.ComputeHash(txtBoxPassword.Text.Trim());

            _User.Permission = clsEncryptionDecryption.Encrypt(_User.Permission);

            _User.EmployeeID = _Mode == enMode.Add? ctrlEmployeeWithFilter1.Employee.EmployeeID : _User.EmployeeID;
            
        }
        private bool _IsValidInputs()
        {
            return txtBoxUserName.Text.Trim().Length > 0 && txtBoxPassword.Text.Trim().Length > 0 &&
                   (rbCustom.Checked || rbFullControl.Checked);
        }

        private void _Save()
        {

            _PrepareUserData();

            bool IsSaved = _User.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            _UpdateFormInfo(IsSaved);

        }
        private void _UpdateFormInfo(bool IsSaved)
        {
            lblUserID.Text = _User.UserID == -1 ? lblUserID.Text : _User.UserID.ToString();

            _Mode = _Mode == enMode.Add && IsSaved ? enMode.Edit : _Mode;

            if (IsSaved)
            {
                MessageBox.Show("User Info Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(clsGlobal.ErrorMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!_IsValidInputs())
            {
                MessageBox.Show("Invalid Inputs", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Save();
        }

        private void _Raise(object sender, string NewUserPermmissions)
        {
            if(_User == null)
                _User = new clsUser();
            
             _User.Permission = NewUserPermmissions;

            _IsUserPermissionChanged = true;
           
        }
        private void rbCustom_Click(object sender, EventArgs e)
        {
            if (rbCustom.Checked)
            {
                string UserPermissions = _Mode == enMode.Add ? string.Empty : _User.Permission;
                
                frmUserPermissions Permissions = new frmUserPermissions(UserPermissions);

                Permissions.UserPermissionsChanged += _Raise;

                Permissions.Show();

            }
        }

        private void txtBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rbFullControl_Click(object sender, EventArgs e)
        {
            if (rbFullControl.Checked)
            {
                if (_User == null)
                    _User = new clsUser();
                _User.Permission = "Full Control";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

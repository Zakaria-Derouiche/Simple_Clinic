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
    public partial class ctrlUserInfoWithFilter : UserControl
    {
        private clsUser _User = new clsUser();

        public ctrlUserInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlUserInfoWithFilter_Load(object sender, EventArgs e)
        {
            comboBoxFilterBy.SelectedIndex = 0;

            btnFind.Enabled = false;
            

        }
        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilterBy.Text = string.Empty;
        }

        private void txtBoxFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(comboBoxFilterBy.SelectedIndex == 0 || comboBoxFilterBy.SelectedIndex == 2)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxFilterBy_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxFilterBy.Text.Length != 0)
                btnFind.Enabled = true;
            
        }



        private void _GetUserInfo()
        {
            if(comboBoxFilterBy.SelectedIndex == 0)
            {
                _User = clsUser.GetUserInfoByID(Convert.ToInt32(txtBoxFilterBy.Text), ref clsGlobal.ErrorMessage);
            }else if(comboBoxFilterBy.SelectedIndex == 1)
            {
                _User = clsUser.GetUserInfoByUserName(txtBoxFilterBy.Text.Trim(), ref clsGlobal.ErrorMessage);
            }else
            {
                _User = clsUser.GetUserInfoByEmployeeID(Convert.ToInt32(txtBoxFilterBy.Text), ref clsGlobal.ErrorMessage);
            }
        }

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.GetUserInfoByID(UserID, ref clsGlobal.ErrorMessage);

            _LoadUserInfo();

            btnFind.Enabled = _User == null || _User.UserID < 1;

            txtBoxFilterBy.Enabled = _User == null || _User.UserID < 1;

            comboBoxFilterBy.Enabled = _User == null || _User.UserID < 1;
        }

        private void _LoadUserInfo()
        {
            if(_User != null)
                ctrlUserInfo1.LoadUserInfo(_User);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            _GetUserInfo();

            _LoadUserInfo();
          
        }
    }
}

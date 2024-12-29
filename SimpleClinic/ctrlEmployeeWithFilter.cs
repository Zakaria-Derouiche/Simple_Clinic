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
    public partial class ctrlEmployeeWithFilter : UserControl
    {
        public clsEmployee Employee { get { return _Employee; } }

        private clsEmployee _Employee = new clsEmployee();

        public event EventHandler SelectedEmployee;

        public void _Raise(object sender, EventArgs e)
        {
            SelectedEmployee?.Invoke(sender, e);
        }
        public ctrlEmployeeWithFilter()
        {
            InitializeComponent();

            linkLblPersonInfo.Visible = _Employee != null && _Employee.ID > 0;

            btnFind.Enabled = false;
        }

        private void txtBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void _GetEmployee()
        {
            string EmployeeID = txtBoxFilter.Text.Trim();

            if (!string.IsNullOrEmpty(EmployeeID) && int.TryParse(EmployeeID, out int _EmployeeID) == true
                && _EmployeeID > 0 && clsEmployee.IsEmployeeExistByID(_EmployeeID, ref clsGlobal.ErrorMessage))
            {
                
                _Employee = clsEmployee.GetEmployeeInfoByID(_EmployeeID, ref clsGlobal.ErrorMessage);

            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            _GetEmployee();

            ctrlEmployeeInfo1.LoadEmployeeInfo(_Employee);
   

            if (_Employee != null && _Employee.EmployeeID != -1)
                _Raise(this, null);

            linkLblPersonInfo.Visible = _Employee != null && _Employee.ID > 0;
        }

        private void txtBoxFilter_TextChanged(object sender, EventArgs e)
        {
            btnFind.Enabled = txtBoxFilter.Text.Length > 0;
        }

        public void LoadEmployeeInfo(clsEmployee Employee)
        {
            _Employee = Employee;

            ctrlEmployeeInfo1.LoadEmployeeInfo(_Employee);
        }

        private void linkLblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfo Person = new frmPersonInfo((clsPerson)_Employee);

            Person.Show();
        }

       
    }
}

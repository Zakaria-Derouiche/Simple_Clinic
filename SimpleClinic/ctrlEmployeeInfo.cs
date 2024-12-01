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
    public partial class ctrlEmployeeInfo : UserControl
    {
        private clsEmployee _Employee;
        private string ErrorMessage = string.Empty;
        public ctrlEmployeeInfo()
        {
            InitializeComponent();
        }
       
        private void ctrlEmployeeInfo_Load(object sender, EventArgs e)
        {

        }
        private void _LoadInfo()
        {
            lblEmployeeID.Text = _Employee == null || _Employee.EmployeeID == -1 ? "[???]" : _Employee.EmployeeID.ToString();
            lblPersonID.Text = _Employee == null || _Employee.ID == -1 ? "[???]" : _Employee.ID.ToString();
            lblHireDate.Text = _Employee == null || _Employee.EmployeeID == -1 ? "[???]" : _Employee.HireDate.ToShortDateString();
            lblEndDate.Text = _Employee == null || _Employee.EmployeeID == -1 ? "[???]" : 
                _Employee.EndDate.Value == null? "N/A" : _Employee.EndDate.Value.ToShortDateString();
            lblTypeOfLeaving.Text = _Employee == null || _Employee.EmployeeID == -1 ? "[???]" :
                _Employee.TypeOfLeaving == null ? "N/A" : _Employee.TypeOfLeaving.ToString();
            lblReasonOfLeaving.Text = _Employee == null || _Employee.EmployeeID == -1 ? "[???]" :
                _Employee.ReasonOfLeaving == string.Empty ? "N/A" : _Employee.ReasonOfLeaving;
            picBoxEmployeeImage.ImageLocation = _Employee == null || _Employee.EmployeeID == -1 ||
                _Employee.ImagePath == string.Empty ? "" : _Employee.ImagePath; 
        }
        private bool _CheckEmployee()
        {
            return _Employee != null && _Employee.EmployeeID != -1;
        }
        public void LoadEmployeeInfo(int PersonID)
        {
            _Employee = clsEmployee.GetEmployeeInfoByID(PersonID, ref ErrorMessage);
            _LoadInfo();
        }

    }
}

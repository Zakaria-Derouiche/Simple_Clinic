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
    public partial class frmEmployeeInfo : Form
    {
        private clsEmployee _Employee = new clsEmployee();

        private Form _Sender;
        public frmEmployeeInfo(int EmployeeID, Form Sender = null)
        {
            InitializeComponent();

            _Employee = clsEmployee.GetEmployeeInfoByID(EmployeeID, ref clsGlobal.ErrorMessage);

            _Sender = Sender;

        }

        private void frmEmployeeInfo_Load(object sender, EventArgs e)
        {
            ctrlEmployeeInfo1.LoadEmployeeInfo(_Employee);

            linkLblPersonInfo.Visible = _Employee != null && _Employee.EmployeeID > 0;
        }

        private void linkLblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfo Person = new frmPersonInfo((clsPerson)_Employee, this);

            this.Hide();

            Person.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }
    }
}

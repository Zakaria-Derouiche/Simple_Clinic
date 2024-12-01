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
    public partial class frmAddEditEmployee : Form
    {
        private enum enMode { Add, Edit}
        private enMode _Mode;
        private int _EmployeeID = -1;
        private clsEmployee _Employee = new clsEmployee();
        private void Raise(object sender, bool IsFound)
        {
            lblPersonID.Text = ctrlPersonWithFilter1.Person.ID.ToString();
             _Employee = clsEmployee.GetEmployeeInfoByPersonID(ctrlPersonWithFilter1.Person.ID, ref clsGlobal.ErrorMessage);
            _LoadEmployeeInfo();
        }
        public frmAddEditEmployee(int EmployeeID)
        {
            InitializeComponent();
            _EmployeeID = EmployeeID;
            _Mode = _EmployeeID == -1 ? enMode.Add : enMode.Edit;
            ctrlPersonWithFilter1.PersonSelected += Raise; 
        }
        private void _GetEmployeeInfo()
        { 
            if(_Mode == enMode.Edit) 
                _Employee = clsEmployee.GetEmployeeInfoByID(_EmployeeID, ref clsGlobal.ErrorMessage);
        }
        private void _LoadInfo()
        {
            if (_Mode == enMode.Edit && _Employee == null)
                MessageBox.Show("No Employee Is Found With The Given Info");
        }
        
        private void _LoadEmployeeInfo()
        {
            gboxEmployeeInfo.Enabled = ctrlPersonWithFilter1.Person != null && ctrlPersonWithFilter1.Person.ID != -1;
            linkLblAddImage.Text = _Employee == null || _Employee.EmployeeID == -1 || _Employee.ImagePath == string.Empty ?
                "Add Image" : "Change Image";
            linkLblRemoveImage.Visible = _Employee != null && _Employee.EmployeeID != -1 && _Employee.ImagePath != string.Empty;
            lblEmployeeID.Text = _Employee == null || _Employee.EmployeeID == -1 ? "[???]" : _Employee.EmployeeID.ToString();
            lblPersonID.Text = ctrlPersonWithFilter1.Person == null || ctrlPersonWithFilter1.Person.ID == -1 ?"[???]" :
                ctrlPersonWithFilter1.Person.ID.ToString();

            dtpHireDate.Enabled = ctrlPersonWithFilter1.Person != null && ctrlPersonWithFilter1.Person.ID != -1;
            dtpEndDate.Enabled = _Employee != null && _Employee.EmployeeID != -1 && _Employee.EndDate.Value != null;
            rbResigned.Enabled = _Employee != null && _Employee.EmployeeID != -1 && _Employee.TypeOfLeaving != null;
            rbFired.Enabled = _Employee != null && _Employee.EmployeeID != -1 && _Employee.TypeOfLeaving != null;
            txtBoxReasonOfLeaving.Enabled = _Employee != null && _Employee.EmployeeID != -1 &&
                _Employee.ReasonOfLeaving != string.Empty;
            txtBoxReasonOfLeaving.Text = _Employee == null || _Employee.EmployeeID == -1 || 
                _Employee.ReasonOfLeaving == string.Empty  ? "" : _Employee.ReasonOfLeaving;
            picBoxEmployeeImage.ImageLocation = _Employee == null || _Employee.EmployeeID == -1 ||
                _Employee.ImagePath == string.Empty ? "" : _Employee.ImagePath;
        }
        private void frmAddEditEmployee_Load(object sender, EventArgs e)
        {
            _GetEmployeeInfo();
            _LoadInfo();
            _LoadEmployeeInfo();
            MessageBox.Show(Guid.NewGuid().ToString());
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpHireDate_EnabledChanged(object sender, EventArgs e)
        {
            if(dtpHireDate.Enabled)
            {
                dtpHireDate.Value = _Employee == null || _Employee.EmployeeID == -1 ? DateTime.Now : _Employee.HireDate;
                dtpHireDate.MaxDate = DateTime.Now; 
            }
                
           
        }

        private void dtpEndDate_EnabledChanged(object sender, EventArgs e)
        {
            if(dtpEndDate.Enabled)
            {
                dtpEndDate.Value = _Employee == null || _Employee.EmployeeID == -1 || _Employee.EndDate.Value == null ?
               DateTime.Now : _Employee.EndDate.Value;
                dtpEndDate.MaxDate = DateTime.Now;
            }
            
        }

        private void linkLblAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                string selectedFilePath = openFileDialog1.FileName;
                picBoxEmployeeImage.Load(selectedFilePath);
                linkLblRemoveImage.Visible = true;
                linkLblAddImage.Text = "Change Image";
            }
        }

        private void _SelectImage()
        {

        }



        private void linkLblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you Sure You Want To Remove This Image?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
            {
                picBoxEmployeeImage.ImageLocation = "";
                linkLblRemoveImage.Visible = false;
                linkLblAddImage.Text = "Add Image";
            }
        }
    }
}

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
    public partial class frmAddEditDoctor : Form
    {
        private enum enMode { Add, Edit}

        private enMode _Mode;

        private clsDoctor _Doctor;


        private void _Raise(object sender, EventArgs e)
        {

            if(ctrlEmployeeWithFilter1.Employee != null && ctrlEmployeeWithFilter1.Employee.EmployeeID > 0 &&
                clsDoctor.IsDoctorExistByEmployeeID(ctrlEmployeeWithFilter1.Employee.EmployeeID, ref clsGlobal.ErrorMessage))
            {
                _Mode = enMode.Edit;

                _Doctor = clsDoctor.GetDoctorInfoByEmployeeID(ctrlEmployeeWithFilter1.Employee.EmployeeID, ref clsGlobal.ErrorMessage);

                _LoadDoctorInfo();

                _PrepareFormInfo();

                
            }
           
            btnSave.Enabled = ctrlEmployeeWithFilter1.Employee != null && ctrlEmployeeWithFilter1.Employee.EmployeeID > 0;
        }


        public frmAddEditDoctor(int DoctorID)
        {

            InitializeComponent();

            _Doctor = clsDoctor.GetDoctorInfoByID(DoctorID, ref clsGlobal.ErrorMessage);

            _Mode = _Doctor == null || _Doctor.DoctorID == -1 ? enMode.Add : enMode.Edit;

            ctrlEmployeeWithFilter1.SelectedEmployee += _Raise;

        }

        private void frmAddEditDoctor_Load(object sender, EventArgs e)
        {
            _LoadInfo();
        }

        private void _PrepareFormInfo()
        {
            lblTitle.Text = _Mode == enMode.Add? "Add New Doctor" : "Update Doctor Informations";

            lblTitle.Location = new Point((this.Size.Width / 2) - (lblTitle.Size.Width / 2),10);

        }

        private void _LoadDoctorInfo()
        {
            lblDoctorID.Text = _Mode == enMode.Add ? "N/A" : _Doctor.DoctorID.ToString();

            txtBoxSpeciality.Text = _Mode == enMode.Add ? "" : _Doctor.Specialization;

            btnSave.Enabled = ctrlEmployeeWithFilter1.Employee != null && ctrlEmployeeWithFilter1.Employee.EmployeeID > 0;
        }

        private void _LoadInfo()
        {
            _PrepareFormInfo();

            _LoadDoctorInfo();

            ctrlEmployeeWithFilter1.LoadEmployeeInfo((clsEmployee) _Doctor);


        }

        private void txtBoxSpeciality_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      
        private void _LoadDoctorInfoFromForm()
        {
             _Doctor = _Mode == enMode.Add ? new clsDoctor(ctrlEmployeeWithFilter1.Employee) : _Doctor;
            
            _Doctor.Specialization = txtBoxSpeciality.Text.Trim();
        }

       private void _DisplayResult(bool IsSaved)
       {
            if (IsSaved)
            {
                lblDoctorID.Text = _Doctor.DoctorID.ToString();

                MessageBox.Show("Doctor Informations Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(clsGlobal.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void _Save()
        {
            _LoadDoctorInfoFromForm();

            bool IsSaved = _Doctor.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            _DisplayResult(IsSaved);

        }
       
        
        private bool _CheckInputs()
        {
            return  ctrlEmployeeWithFilter1.Employee != null &&  ctrlEmployeeWithFilter1.Employee.EmployeeID > 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_CheckInputs())
            {
                _Save();
            }
        }
        private void txtBoxSpeciality_Validating(object sender, CancelEventArgs e)
        {
            if (ctrlEmployeeWithFilter1.Employee != null && ctrlEmployeeWithFilter1.Employee.EmployeeID > 0 &&
                string.IsNullOrEmpty(txtBoxSpeciality.Text.Trim()))
            {
                errorProvider1.SetError(txtBoxSpeciality, "Cannot be Empty");
                txtBoxSpeciality.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

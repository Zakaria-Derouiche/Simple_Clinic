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
    public partial class ctrlDoctorInfo : UserControl
    {
        private clsDoctor _Doctor;

        public ctrlDoctorInfo()
        {
            InitializeComponent();

        }

        public void LoadDoctorInfo(clsDoctor Doctor)
        {
            _Doctor = Doctor;

            lblDoctorID.Text = _Doctor != null && _Doctor.DoctorID > 0 ? _Doctor.DoctorID.ToString() : "[???]";

            lblEmployeeID.Text = _Doctor != null && _Doctor.DoctorID > 0 ? _Doctor.EmployeeID.ToString() : "[???]";

            lblSpecialization.Text = _Doctor != null && _Doctor.DoctorID > 0 ? _Doctor.Specialization : "[???]";

            linkLblEmployeeInfo.Visible = _Doctor != null && _Doctor.DoctorID > 0;

           
        }

       

        private void linkLblEmployeeInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeeInfo Employee = new frmEmployeeInfo(_Doctor.EmployeeID, this.ParentForm);

            ParentForm.Hide();

            Employee.ShowDialog();
        }
    }
}

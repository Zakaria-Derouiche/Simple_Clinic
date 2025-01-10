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
    public partial class ctrlPatientInfo : UserControl
    {
        private clsPatient _Patient = new clsPatient();
        public ctrlPatientInfo()
        {
            InitializeComponent();
        }

        public void LoadPatientInfo(clsPatient Patient)
        {
            _Patient = Patient;

            _LoadInfo();    
        }

        private void _LoadInfo()
        {
            lblPatientID.Text = _Patient == null || _Patient.PatientID < 1 ? "[???]" : _Patient.PatientID.ToString();

            lblPersonID.Text = _Patient == null || _Patient.PatientID < 1 ? "[???]" : _Patient.ID.ToString();

            linkLblPersonInfo.Enabled = _Patient != null && _Patient.PatientID > 0;

            linkLblPatientAppointments.Enabled = _Patient != null && _Patient.PatientID > 0;
        }

        private void linkLblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfo Person = new frmPersonInfo((clsPerson)_Patient, ParentForm);

            ParentForm.Hide();

            Person.Show();
        }

        private void ctrlPatientInfo_Load(object sender, EventArgs e)
        {
           _LoadInfo();
        }

        private void linkLblPatientAppointments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Not Yet Implemented");
        }
    }
}

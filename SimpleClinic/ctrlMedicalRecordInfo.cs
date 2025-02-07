using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness;

namespace SimpleClinic
{
    public partial class ctrlMedicalRecordInfo : UserControl
    {
        private clsMedicalRecord _MedicalRecord = new clsMedicalRecord();
        public ctrlMedicalRecordInfo()
        {
            InitializeComponent();

            linkLblAppointmentInfo.Visible = false;
        }

        public void LoadMedicalRecordInfo(clsMedicalRecord MedicalRecord)
        {
            _MedicalRecord = MedicalRecord;
            lblID.Text = MedicalRecord == null || MedicalRecord.ID < 1 ? "[???]" : MedicalRecord.ID.ToString();
            lblAppointmentID.Text = MedicalRecord == null || MedicalRecord.ID < 1 ? "[???]" : MedicalRecord.AppointmentID.ToString();
            lblDate.Text = MedicalRecord == null || MedicalRecord.ID < 1 ? "[???]" : MedicalRecord.CreationDate.ToShortDateString();
            lblDescription.Text = MedicalRecord == null || MedicalRecord.ID < 1 ? "[???]" : MedicalRecord.Description;
            lblDiagnosis.Text = MedicalRecord == null || MedicalRecord.ID < 1 ? "[???]" : MedicalRecord.Diagnosis;
            lblNotes.Text = MedicalRecord == null || MedicalRecord.ID < 1 ? "[???]" : MedicalRecord.Notes == "" ? "N/A" : MedicalRecord.Notes;
            linkLblAppointmentInfo.Visible = MedicalRecord != null && MedicalRecord.ID > 0;
        }

        private void linkLblAppointmentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAppointmentInfo Appointment = new frmAppointmentInfo(_MedicalRecord.AppointmentID, ParentForm);

            ParentForm.Hide();

            Appointment.Show();
        }

        private void linkLblShowPrescriptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPrescriptions Show = new frmShowPrescriptions(ParentForm, _MedicalRecord.ID);

            ParentForm.Hide();

            Show.Show();
        }
    }
}

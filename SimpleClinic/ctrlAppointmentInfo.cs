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
    public partial class ctrlAppointmentInfo : UserControl
    {
        public ctrlAppointmentInfo()
        {
            InitializeComponent();

            
        }

        public void LoadAppointmentInfo(clsAppointment Appointment)
        {
            lblAppointmentID.Text = Appointment == null || Appointment.ID < 1? "[???]" : Appointment.ID.ToString();

            lblPatientID.Text = Appointment == null || Appointment.ID < 1 ? "[???]" : Appointment.PatientID.ToString();

            lblDoctorID.Text = Appointment == null || Appointment.ID < 1 ? "[???]" : Appointment.DoctorID.ToString();

            lblAppointmentDate.Text = Appointment == null || Appointment.ID < 1 ? "[???]" : 
                Appointment.AppointmentDate.ToShortDateString();

            lblAppointmentStatus.Text = Appointment == null || Appointment.ID < 1 ? "[???]" : Appointment.AppointmentStatus;

            linkLblDoctorInfo.Visible = Appointment != null && Appointment.ID > 0;

            linkLblPatientInfo.Visible = Appointment != null && Appointment.ID > 0;
        }

        private void linkLblPatientInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatientInfo PatientInfo = new frmPatientInfo(clsPatient.GetPatientInfoByID(Convert.ToInt32(lblPatientID.Text), 
                ref clsGlobal.ErrorMessage),
                ParentForm);
            ParentForm.Hide();

            PatientInfo.ShowDialog();
        }

        private void linkLblDoctorInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoctorInfo DoctorInfo = new frmDoctorInfo(Convert.ToInt32(lblDoctorID.Text), ParentForm);

            ParentForm.Hide();

            DoctorInfo.ShowDialog();
        }
    }
}

using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class frmAddUpdateAppointment : Form
    {
        private enum EnMode { Add, Edit}

        private EnMode _Mode;

        private Form _Sender;

        private clsAppointment _Appointment;

        private bool _IsAppointmentAddedOrUpdated;

        public frmAddUpdateAppointment(int AppointmentID, Form Sender)
        {
            InitializeComponent();

            _Sender = Sender;

            _Appointment = clsAppointment.GetAppointmentInfo(AppointmentID, ref clsGlobal.ErrorMessage);

            _Mode = _Appointment == null || _Appointment.ID < 1 ? EnMode.Add : EnMode.Edit;

            _IsAppointmentAddedOrUpdated = false;

        }

        public event EventHandler AppointmentAddedOrUpdated;
        
        private void _LoadFormInfo()
        {

            lblTitle.Text = _Mode == EnMode.Add ? "Add New Appointment" : "Update Appointment Informations";

            lblTitle.Location = new Point((this.Size.Width /2) - (lblTitle.Size.Width / 2), 10);

            lblDate.Text = _Mode == EnMode.Add ? "Set Date: " : "Change Date: ";

            dtpAppointmentDate.MinDate = _Mode == EnMode.Add ? DateTime.Now : _Appointment.AppointmentDate;

            

            
        }

        
        private void _LoadAppointmentInfo()
        {
            lblAppointmentID.Text = _Appointment == null || _Appointment.ID < 1 ? "N/A" : _Appointment.ID.ToString();

            dtpAppointmentDate.Value = _Appointment == null || _Appointment.ID < 1 ? DateTime.Now : _Appointment.AppointmentDate;

            comBoxAppointmentStatus.SelectedIndex = _Appointment == null || _Appointment.ID < 1 ? 0 :
                comBoxAppointmentStatus.Items.IndexOf(_Appointment.AppointmentStatus);

            linkLblMedicalRecordInfo.Visible = _Mode == EnMode.Edit && comBoxAppointmentStatus.SelectedIndex == 2;



            if (comBoxAppointmentStatus.SelectedIndex == 2)
            {
                comBoxAppointmentStatus.Enabled = false;

                dtpAppointmentDate.Enabled = false;

                btnSave.Enabled = false;
            }
        }
        private void _LoadPatientInfo()
        {
            if (_Mode == EnMode.Edit)
            {
                ctrlPatientInfoWithFilter1.LoadPatientInfo(_Appointment.PatientID);

                gBoxPatient.Enabled = false;
            }
        }
        private void _LoadDoctorInfo()
        {
            if (_Mode == EnMode.Edit)
            {
                ctrlDoctorInfoWithFilter1.LoadDoctorInfo(_Appointment.DoctorID);

                gBoxDoctor.Enabled = false;
            }

        }
        private void frmAddUpdateAppointment_Load(object sender, EventArgs e)
        {
            _LoadFormInfo();

            _LoadAppointmentInfo();

            _LoadPatientInfo();

            _LoadDoctorInfo();

        }

        private bool _CheckPatient()
        {
            return ctrlPatientInfoWithFilter1.Patient != null && ctrlPatientInfoWithFilter1.Patient.ID > 0;
        }

        private bool _CheckDoctor()
        {
            return ctrlDoctorInfoWithFilter1.Doctor != null && ctrlDoctorInfoWithFilter1.Doctor.ID > 0;
        }

        private bool _CheckInputValidations()
        {
            return _CheckPatient() && _CheckDoctor();
        }
       
        private void _FillAppointmentInfo()
        {
            _Appointment = _Mode == EnMode.Add? new clsAppointment() : _Appointment;

            _Appointment.AppointmentStatus = comBoxAppointmentStatus.Text;

            _Appointment.AppointmentDate = dtpAppointmentDate.Value;

            _Appointment.PatientID = _Mode == EnMode.Edit? _Appointment.PatientID : ctrlPatientInfoWithFilter1.Patient.PatientID;

            _Appointment.DoctorID = _Mode == EnMode.Edit ? _Appointment.DoctorID : ctrlDoctorInfoWithFilter1.Doctor.DoctorID;

            
        }

        private void _Raise(object sender, clsMedicalRecord MedicalRecord)
        {
            _Appointment.MedicalRecord = MedicalRecord;

            linkLblMedicalRecordInfo.Visible = true;
        }

        private void _CreateMedicalRecordForThisAppointment()
        {
            if (_Mode == EnMode.Edit && comBoxAppointmentStatus.SelectedIndex == 2) {

                frmAddMedicalRecord MedicalRecord = new frmAddMedicalRecord(this, _Appointment.ID);

                MedicalRecord.MedicalRecordAdded += _Raise;

                this.Hide();

                MedicalRecord.ShowDialog();
            }
        }
        private void _Save()
        {
           if(_Appointment.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage))
           {
                MessageBox.Show("Successfull Operation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _IsAppointmentAddedOrUpdated = true;

                _CreateMedicalRecordForThisAppointment();
           }
            else
           {
                MessageBox.Show("Failed Operation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckInputValidations())
                MessageBox.Show("Invalid Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            _FillAppointmentInfo();

            _Save();

            _UpdateFormInfo();
           

        }

        private void _UpdateFormInfo()
        {
            lblAppointmentID.Text= _Appointment == null || _Appointment.ID < 1 ? "N/A" : _Appointment.ID.ToString();

            _Mode = _Mode == EnMode.Add && _Appointment != null && _Appointment.ID > 0 ? EnMode.Edit : EnMode.Add;

            btnSave.Enabled = false;
        }

        private void linkLblMedicalRecordInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMedicalRecordInfo MedicalRecordInfo = new frmMedicalRecordInfo(this, _Appointment.MedicalRecord);

            this.Hide();

            MedicalRecordInfo.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            if (_IsAppointmentAddedOrUpdated)
                AppointmentAddedOrUpdated?.Invoke(this, EventArgs.Empty);
                    
            _Sender.Show();

            this.Close();
        }

       
    }
}

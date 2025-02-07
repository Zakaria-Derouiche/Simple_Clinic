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
    public partial class frmAppointmentsList : Form
    {
        private Form _Sender = null;

        private string _PatientName = string.Empty;

        private string _DoctorName = string.Empty;

        private string _PatientNationalNumber = string.Empty;

        private string _DoctorNationalNumber = string.Empty;

        string _Date = string.Empty;

        private DataTable _dtAppointments = new DataTable();

        private int _PageNumber = 1;

        private int _RowsPerPage = 5;

        private int _TotalPageNumber;

        private int _AppointmentsNumberPerPage;

        private int _TotalAppointmentsNumber;

        private enum enAppointmentsShowMode {All , PatientName, PatientNationaNo, DoctorName, DoctorNationalNo, Date}

        private enAppointmentsShowMode _AppointmentsShowMode;
        public frmAppointmentsList(Form Sender = null)
        {
            InitializeComponent();

            _Sender = Sender;

            _AppointmentsShowMode = enAppointmentsShowMode.All;

        }
        
        private void _LoadAppointments()
        {
           
            _LoadAppointmentsList();

            _TotalAppointmentsNumber = clsAppointment.GetTotalAppointmentsNumber(ref clsGlobal.ErrorMessage);

            _TotalPageNumber = _TotalAppointmentsNumber % _RowsPerPage == 0 ? _TotalAppointmentsNumber / _RowsPerPage :

                 (_TotalAppointmentsNumber / _RowsPerPage) + 1;

            _AppointmentsNumberPerPage = _dtAppointments.Rows.Count;

            dgvAppointments.DataSource = _dtAppointments;
        }
        private void _LoadAppointmentsList()
        {
            if (_AppointmentsShowMode == enAppointmentsShowMode.All)
            {
                _dtAppointments = clsAppointment.GetSetOfAppointments(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);
            }
            else if (_AppointmentsShowMode == enAppointmentsShowMode.PatientName)
            {
                _dtAppointments = clsAppointment.GetPersonAppointmentsByName(string.Join(" ", _PatientName.Split(' ').
                    Select(s => clsEncryptionDecryption.Encrypt(s))), _PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);
            }
            else if (_AppointmentsShowMode == enAppointmentsShowMode.PatientNationaNo)
            {
                _dtAppointments = clsAppointment.GetDoctorAppointments(clsEncryptionDecryption.Encrypt(_PatientNationalNumber),
                    _PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);
            }
            else if (_AppointmentsShowMode == enAppointmentsShowMode.DoctorName)
            {
                _dtAppointments = clsAppointment.GetDoctorAppointments(string.Join(" ", _DoctorName.Split(' ').
                    Select(s => clsEncryptionDecryption.Encrypt(s))), _PageNumber, _RowsPerPage,
                    ref clsGlobal.ErrorMessage);
                MessageBox.Show(clsGlobal.ErrorMessage);
            }
            else if (_AppointmentsShowMode == enAppointmentsShowMode.DoctorNationalNo)
            {
                _dtAppointments = clsAppointment.GetDoctorAppointmentsByNationalNumber(clsEncryptionDecryption.Encrypt(_DoctorNationalNumber),
                    _PageNumber, _RowsPerPage,ref clsGlobal.ErrorMessage);
            }
            else
            {
                _dtAppointments = clsAppointment.GetAppointmentsByDate(_Date, _PageNumber, _RowsPerPage,
                    ref clsGlobal.ErrorMessage);
            }
        }
        private void _LoadInfo()
        {
            
            lblPageNumber.Text = "Page No: " + _PageNumber.ToString();

            lblRecordsNumber.Text = "Appointments Number Per Page: " + _AppointmentsNumberPerPage.ToString();

            lblTotalPageNumber.Text = "Total Pages Number: " + _TotalPageNumber.ToString();

            lblTotalRecordNumber.Text = "Total Records Number: " + _TotalAppointmentsNumber.ToString();

            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;

            txtBoxFilterBy.Enabled = comBoxFilterBy.SelectedIndex != 0;

            btnDisplay.Enabled = false;

            _InitializeComboBox();

        }

        private void frmAppointmentsList_Load(object sender, EventArgs e)
        {
           _LoadAppointments();

            _LoadInfo();
          
        }

        private void _InitializeComboBox()
        {
            if (_AppointmentsShowMode == enAppointmentsShowMode.All)
            {
                comBoxFilterBy.SelectedIndex = 0;
            }
            else if (_AppointmentsShowMode == enAppointmentsShowMode.PatientName)
            {
                comBoxFilterBy.SelectedIndex = 1;
            }
            else if (_AppointmentsShowMode == enAppointmentsShowMode.PatientNationaNo)
            {
                comBoxFilterBy.SelectedIndex = 2;
            }
            else if (_AppointmentsShowMode == enAppointmentsShowMode.DoctorName)
            {
                comBoxFilterBy.SelectedIndex = 3;
            }
            else if (_AppointmentsShowMode == enAppointmentsShowMode.DoctorNationalNo)
            {
                comBoxFilterBy.SelectedIndex = 4;
            }
            else
            {
                comBoxFilterBy.SelectedIndex = 5;
            }
            
        }

        private void txtBoxPageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSearchPage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxPageNumber.Text) && int.TryParse(txtBoxPageNumber.Text, out int PageNumber)
                && PageNumber > 0 && PageNumber != _PageNumber && PageNumber <= _TotalPageNumber)
            {
                _PageNumber = PageNumber;

                frmAppointmentsList_Load(null, EventArgs.Empty);
            }
            else
            {
                txtBoxPageNumber.Text = _PageNumber.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PageNumber < _TotalPageNumber)
            {
                _PageNumber++;

                frmAppointmentsList_Load(null, EventArgs.Empty);
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_PageNumber > 0 && _PageNumber != 1)
            {
                _PageNumber--;

                frmAppointmentsList_Load(null, EventArgs.Empty);
            }

            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;
        }

        private void showAppointmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            frmAppointmentInfo Appointment = new frmAppointmentInfo(AppointmentID, this);

            this.Hide();

            Appointment.ShowDialog();

        }

       
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {

            frmAddUpdateAppointment Appointment = new frmAddUpdateAppointment(-1, this);

            Appointment.AppointmentAddedOrUpdated += frmAppointmentsList_Load;

            this.Hide();

            Appointment.ShowDialog();
        }

        private void updateAppointmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            frmAddUpdateAppointment Appointment = new frmAddUpdateAppointment(AppointmentID, this);


            Appointment.AppointmentAddedOrUpdated += frmAppointmentsList_Load;

            this.Hide();

            Appointment.ShowDialog();
        }

        private void _ShowResult(bool IsDeleted)
        {
            if (IsDeleted)
                MessageBox.Show("Appointment Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _DeleteAppointment()
        {
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            bool IsDeleted = clsAppointment.DeleteAppointment(AppointmentID, clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            if (IsDeleted)
            {
                frmAppointmentsList_Load(null, EventArgs.Empty);
            }

            _ShowResult(IsDeleted);
        }

        private void deleteAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Delete this Appointment", "Warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeleteAppointment();
            }
        }
        private void txtBoxFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comBoxFilterBy.SelectedIndex == 0)
                e.Handled = true;
            else if (comBoxFilterBy.SelectedIndex == 1 || comBoxFilterBy.SelectedIndex == 3)
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
            else if (comBoxFilterBy.SelectedIndex == 2 || comBoxFilterBy.SelectedIndex == 4)
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }
        
        private void comBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilterBy.Text = string.Empty;

            txtBoxFilterBy.Enabled = comBoxFilterBy.SelectedIndex != 0;
        }
      
        private void _DefineShowMode()
        {
            if (comBoxFilterBy.SelectedIndex == 0)
            {
                _AppointmentsShowMode = enAppointmentsShowMode.All;
            }
            else if (comBoxFilterBy.SelectedIndex == 1)
            {
                _AppointmentsShowMode = enAppointmentsShowMode.PatientName;
            }
            else if (comBoxFilterBy.SelectedIndex == 2)
            {
                _AppointmentsShowMode = enAppointmentsShowMode.PatientNationaNo;
            }
            else if (comBoxFilterBy.SelectedIndex == 3)
            {
                _AppointmentsShowMode = enAppointmentsShowMode.DoctorName;
            }
            else if (comBoxFilterBy.SelectedIndex == 4)
            {
                _AppointmentsShowMode = enAppointmentsShowMode.DoctorNationalNo;
            }
            else 
            {
                _AppointmentsShowMode = enAppointmentsShowMode.Date;
            }
        }

        private void _DefineSearchString()
        {
             if (comBoxFilterBy.SelectedIndex == 1)
            {
                _PatientName = txtBoxFilterBy.Text.Trim();
            }
            else if (comBoxFilterBy.SelectedIndex == 2)
            {
                _PatientNationalNumber = txtBoxFilterBy.Text;
            }
            else if (comBoxFilterBy.SelectedIndex == 3)
            {
                _DoctorName = txtBoxFilterBy.Text.Trim();
            }
            else if (comBoxFilterBy.SelectedIndex == 4)
            {
                _DoctorNationalNumber = txtBoxFilterBy.Text;
            }
            else
            {
                _Date = txtBoxFilterBy.Text;
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            _DefineShowMode();

            _DefineSearchString();
            
            frmAppointmentsList_Load(null, EventArgs.Empty);
            
        }
        private void showAppointmentMedicalRecordHToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string AppointmentStatus = (string)dgvAppointments.CurrentRow.Cells[4].Value;

            if((string)dgvAppointments.CurrentRow.Cells[4].Value != "Completed")
            {
                MessageBox.Show("Appointment Not Completed Yet","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            frmMedicalRecordInfo MedicalRcordInfo = new frmMedicalRecordInfo(this,
                clsMedicalRecord.GetMedicalRecordInfoByAppointmentID(AppointmentID, ref clsGlobal.ErrorMessage));

            
            this.Hide();

            MedicalRcordInfo.ShowDialog();
        }
        private void txtBoxFilterBy_Validating(object sender, CancelEventArgs e)
        {
            if(comBoxFilterBy.SelectedIndex == 5 && !clsValidation.ValidateDate(txtBoxFilterBy.Text))
            {
                errorProvider1.SetError(txtBoxFilterBy, "DateFormat Is 'mm-dd-yyyy'");
                txtBoxFilterBy.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtBoxFilterBy_TextChanged(object sender, EventArgs e)
        {
            btnDisplay.Enabled = txtBoxFilterBy.Text.Length > 0 && this.ValidateChildren();
        }

        private void cmsAppointments_Opened(object sender, EventArgs e)
        {
            string Status = (string)dgvAppointments.CurrentRow.Cells[4].Value;

            cmsAppointments.Items[3].Enabled = Status == "Completed";
        }

        private void payAppointmentFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            frmAddPayment Add = new frmAddPayment(this, AppointmentID);

            this.Hide();

            Add.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }

       
    }
}

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
    public partial class frmMedicalRecordsList : Form
    {

        private Form _Sender = null;

        private string _PatientName = string.Empty;

        private string _PatientNationalNumber = string.Empty;

        string _Date = string.Empty;

        private DataTable _dtMedicalRecords = new DataTable();

        private int _PageNumber = 1;

        private int _RowsPerPage = 5;

        private int _TotalPageNumber;

        private int _MedicalRecordsNumberPerPage;

        private int _TotalMedicalRecordsNumber;

        private enum enMedicalRecordsShowMode { All, PatientName, PatientNationaNo, Date }

        private enMedicalRecordsShowMode _MedicalRecordsShowMode;

        public frmMedicalRecordsList(Form Sender)
        {
            InitializeComponent();

            _MedicalRecordsShowMode = enMedicalRecordsShowMode.All;

            _Sender = Sender;
        }
        private void _LoadMedicalRecords()
        {

            _LoadMedicalRecordsList();

            _TotalMedicalRecordsNumber = clsMedicalRecord.GetTotalMedicalRecordsNumber(ref clsGlobal.ErrorMessage);

            _TotalPageNumber = _TotalMedicalRecordsNumber % _RowsPerPage == 0 ? _TotalMedicalRecordsNumber / _RowsPerPage :

                 (_TotalMedicalRecordsNumber / _RowsPerPage) + 1;

            _MedicalRecordsNumberPerPage = _dtMedicalRecords.Rows.Count;

            dgvMedicalRecords.DataSource = _dtMedicalRecords;
        }
        private void _LoadMedicalRecordsList()
        {
            if (_MedicalRecordsShowMode == enMedicalRecordsShowMode.All)
            {
                _dtMedicalRecords = clsMedicalRecord.GetSetOfMedicalRecords(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);
            }
            else if (_MedicalRecordsShowMode == enMedicalRecordsShowMode.PatientName)
            {
                _dtMedicalRecords = clsMedicalRecord.GetPersonMedicalRecordsByName(string.Join(" ", _PatientName.Split(' ').
                    Select(s => clsEncryptionDecryption.Encrypt(s))), _PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);
            }
            else if (_MedicalRecordsShowMode == enMedicalRecordsShowMode.PatientNationaNo)
            {
                _dtMedicalRecords = clsMedicalRecord.GetPersonMedicalRecords(clsEncryptionDecryption.Encrypt(_PatientNationalNumber),
                    _PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);
            }
            
            else
            {
                _dtMedicalRecords = clsMedicalRecord.GetPersonMedicalRecordsByDate(_Date, _PageNumber, _RowsPerPage,
                    ref clsGlobal.ErrorMessage);
            }
        }
        private void _LoadInfo()
        {

            lblPageNumber.Text = "Page No: " + _PageNumber.ToString();

            lblRecordsNumber.Text = "MedicalRecords Number Per Page: " + _MedicalRecordsNumberPerPage.ToString();

            lblTotalPageNumber.Text = "Total Pages Number: " + _TotalPageNumber.ToString();

            lblTotalRecordNumber.Text = "Total Records Number: " + _TotalMedicalRecordsNumber.ToString();

            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;

            txtBoxFilterBy.Enabled = comBoxFilterBy.SelectedIndex != 0;

            btnDisplay.Enabled = false;

            _InitializeComboBox();

        }

        private void frmMedicalRecordsList_Load(object sender, EventArgs e)
        {
            _LoadMedicalRecords();

            _LoadInfo();

        }

        private void _InitializeComboBox()
        {
            if (_MedicalRecordsShowMode == enMedicalRecordsShowMode.All)
            {
                comBoxFilterBy.SelectedIndex = 0;
            }
            else if (_MedicalRecordsShowMode == enMedicalRecordsShowMode.PatientName)
            {
                comBoxFilterBy.SelectedIndex = 1;
            }
            else if (_MedicalRecordsShowMode == enMedicalRecordsShowMode.PatientNationaNo)
            {
                comBoxFilterBy.SelectedIndex = 2;
            }
            else
            {
                comBoxFilterBy.SelectedIndex = 3;
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

                frmMedicalRecordsList_Load(null, EventArgs.Empty);
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

                frmMedicalRecordsList_Load(null, EventArgs.Empty);
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_PageNumber > 0 && _PageNumber != 1)
            {
                _PageNumber--;

                frmMedicalRecordsList_Load(null, EventArgs.Empty);
            }

            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;
        }

        private void showMedicalRecordInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MedicalRecordID = (int)dgvMedicalRecords.CurrentRow.Cells[0].Value;

            frmMedicalRecordInfo MedicalRecordInfo = new frmMedicalRecordInfo(this, MedicalRecordID);

            this.Hide();

            MedicalRecordInfo.ShowDialog();

        }

       
        private void _ShowResult(bool IsDeleted)
        {
            if (IsDeleted)
                MessageBox.Show("Appointment Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(clsGlobal.ErrorMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _DeleteMedicalRecord()
        {
            int AppointmentID = (int)dgvMedicalRecords.CurrentRow.Cells[0].Value;

            bool IsDeleted = clsAppointment.DeleteAppointment(AppointmentID, clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            if (IsDeleted)
            {
                frmMedicalRecordsList_Load(null, EventArgs.Empty);
            }

            _ShowResult(IsDeleted);
        }

        private void deleteMedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete this Appointment", "Warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeleteMedicalRecord();
            }
        }
        private void txtBoxFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comBoxFilterBy.SelectedIndex == 0)
                e.Handled = true;
            else if (comBoxFilterBy.SelectedIndex == 1)
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
            else if (comBoxFilterBy.SelectedIndex == 2)
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
                _MedicalRecordsShowMode = enMedicalRecordsShowMode.All;
            }
            else if (comBoxFilterBy.SelectedIndex == 1)
            {
                _MedicalRecordsShowMode = enMedicalRecordsShowMode.PatientName;
            }
            else if (comBoxFilterBy.SelectedIndex == 2)
            {
                _MedicalRecordsShowMode = enMedicalRecordsShowMode.PatientNationaNo;
            }
            else
            {
                _MedicalRecordsShowMode = enMedicalRecordsShowMode.Date;
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
            else
            {
                _Date = txtBoxFilterBy.Text;
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            _DefineShowMode();

            _DefineSearchString();

            frmMedicalRecordsList_Load(null, EventArgs.Empty);

        }
       
        private void txtBoxFilterBy_Validating(object sender, CancelEventArgs e)
        {
            if (comBoxFilterBy.SelectedIndex == 3 && !clsValidation.ValidateDate(txtBoxFilterBy.Text))
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }
    }
}

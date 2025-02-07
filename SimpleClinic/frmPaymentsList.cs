using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class frmPaymentsList : Form
    {
        private Form _Sender = null;

        private string _PatientName = string.Empty;

        private int _AppointmentID = -1;

        private string _PatientNationalNumber = string.Empty;

        string _Date = string.Empty;

        private DataTable _dtPayments = new DataTable();

        private int _PageNumber = 1;

        private int _RowsPerPage = 5;

        private int _TotalPageNumber;

        private int _PaymentsNumberPerPage;

        private int _TotalPaymentsNumber;

        private DataTable dtDecryptedPayments = new DataTable();
        private enum enPaymentsShowMode { All, PatientName, PatientNationaNo, Date }

        private enPaymentsShowMode _PaymentsShowMode;

        public frmPaymentsList(Form Sender)
        {
            InitializeComponent();

            _Sender = Sender;

            _PaymentsShowMode = enPaymentsShowMode.All;
        }

        private void _DecrypteDataTable()
        {
            dtDecryptedPayments.Columns.Add("ID", typeof(int));
            dtDecryptedPayments.Columns.Add("Appointment ID", typeof(int));
            dtDecryptedPayments.Columns.Add("Full Name", typeof(string));
            dtDecryptedPayments.Columns.Add("Date", typeof(DateTime));
            foreach (DataRow row in _dtPayments.Rows)
            {
                dtDecryptedPayments.Rows.Add((int)row["ID"], (int)row["Appointment ID"],
                    string.Join(" ", ((string)row["Full Name"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    (DateTime)row["Date"]
                );
            }

        }
        

        private void _LoadPayments()
        {

            _LoadPaymentsList();

            _DecrypteDataTable();

            _TotalPaymentsNumber = clsPayment.GetPaymentsTotalNumber(ref clsGlobal.ErrorMessage);

           

            _TotalPageNumber = _TotalPaymentsNumber % _RowsPerPage == 0 ? _TotalPaymentsNumber / _RowsPerPage :

                 (_TotalPaymentsNumber / _RowsPerPage) + 1;

            _PaymentsNumberPerPage = _dtPayments.Rows.Count;

            dgvPayments.DataSource = dtDecryptedPayments;
        }
        private void _LoadPaymentsList()
        {
            if (_PaymentsShowMode == enPaymentsShowMode.All)
            {
                _dtPayments = clsPayment.GetSetOfPayments(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);
            }
            else if (_PaymentsShowMode == enPaymentsShowMode.PatientName)
            {
                _dtPayments = clsPayment.GetSetOfPaymentsByName(string.Join(" ", _PatientName.Split(' ').
                    Select(s => clsEncryptionDecryption.Encrypt(s))), _PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);
            }
            else if (_PaymentsShowMode == enPaymentsShowMode.PatientNationaNo)
            {
                _dtPayments = clsPayment.GetSetOfPaymentsNationalNumber(clsEncryptionDecryption.Encrypt(_PatientNationalNumber),
                    _PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);
            }
            else
            {
                _dtPayments = clsPayment.GetSetOfPaymentsByDate(_Date, _PageNumber, _RowsPerPage,
                    ref clsGlobal.ErrorMessage);
            }
        }
        private void _LoadInfo()
        {

            lblPageNumber.Text = "Page No: " + _PageNumber.ToString();

            lblRecordsNumber.Text = "Payments Number Per Page: " + _PaymentsNumberPerPage.ToString();

            lblTotalPageNumber.Text = "Total Pages Number: " + _TotalPageNumber.ToString();

            lblTotalRecordNumber.Text = "Total Records Number: " + _TotalPaymentsNumber.ToString();

            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;

            txtBoxFilterBy.Enabled = comBoxFilterBy.SelectedIndex != 0;

            btnDisplay.Enabled = false;

            _InitializeComboBox();

        }

        private void frmPaymentsList_Load(object sender, EventArgs e)
        {
            _LoadPayments();

            _LoadInfo();

        }

        private void _InitializeComboBox()
        {
            if (_PaymentsShowMode == enPaymentsShowMode.All)
            {
                comBoxFilterBy.SelectedIndex = 0;
            }
            else if (_PaymentsShowMode == enPaymentsShowMode.PatientName)
            {
                comBoxFilterBy.SelectedIndex = 1;
            }
            else if (_PaymentsShowMode == enPaymentsShowMode.PatientNationaNo)
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

                frmPaymentsList_Load(null, EventArgs.Empty);
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

                frmPaymentsList_Load(null, EventArgs.Empty);
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_PageNumber > 0 && _PageNumber != 1)
            {
                _PageNumber--;

                frmPaymentsList_Load(null, EventArgs.Empty);
            }

            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;
        }

        private void showPaymentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PaymentID = (int)dgvPayments.CurrentRow.Cells[0].Value;

            frmPaymentInfo Info = new frmPaymentInfo(this, PaymentID);

            this.Hide();

            Info.ShowDialog();

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
                _PaymentsShowMode = enPaymentsShowMode.All;
            }
            else if (comBoxFilterBy.SelectedIndex == 1)
            {
                _PaymentsShowMode = enPaymentsShowMode.PatientName;
            }
            else if (comBoxFilterBy.SelectedIndex == 2)
            {
                _PaymentsShowMode = enPaymentsShowMode.PatientNationaNo;
            }
            else
            {
                _PaymentsShowMode = enPaymentsShowMode.Date;
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
            else if(comBoxFilterBy.SelectedIndex == 3)
            {
                _Date = txtBoxFilterBy.Text;
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            _DefineShowMode();

            _DefineSearchString();

            frmPaymentsList_Load(null, EventArgs.Empty);

            MessageBox.Show(clsGlobal.ErrorMessage);

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

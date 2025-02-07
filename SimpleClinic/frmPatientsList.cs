using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class frmPatientsList : Form
    {
        private Form _Sender = null;
        private DataTable _dtPatients = new DataTable();
        private int _PageNumber = 1;
        private int _RowsPerPage = 2;
        private int _TotalPageNumber;
        private int _PatientsNumberPerPage;
        private int _TotalPatientsNumber;
        public frmPatientsList(Form Sender = null)
        {
            InitializeComponent();

            _Sender = Sender;

        }
        
        private void _Raise(object sender, EventArgs e)
        {
            _dtPatients = clsPatient.GetSetOfPatientsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

            dgvPatients.DataSource = _dtPatients;
        }
        private void _LoadInfo()
        {

            dgvPatients.DataSource = _dtPatients;

            lblPageNumber.Text += _PageNumber.ToString();

            lblRecordsNumber.Text += _PatientsNumberPerPage.ToString();

            lblTotalPageNumber.Text += _TotalPageNumber.ToString();

            lblTotalRecordNumber.Text += _TotalPatientsNumber.ToString();

        }
        private void frmPatientsList_Load(object sender, EventArgs e)
        {
            _dtPatients = clsPatient.GetSetOfPatientsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

            _TotalPatientsNumber = clsPatient.GetTotalPatientsNumber(ref clsGlobal.ErrorMessage);

            _PatientsNumberPerPage = _dtPatients.Rows.Count;

            _TotalPageNumber = _TotalPatientsNumber % _RowsPerPage == 0 ? (_TotalPatientsNumber / _RowsPerPage) :
                ((_TotalPatientsNumber / _RowsPerPage) + 1);

            _LoadInfo();

            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
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

                _dtPatients = clsPatient.GetSetOfPatientsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvPatients.DataSource = _dtPatients;
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

                _dtPatients = clsPatient.GetSetOfPatientsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvPatients.DataSource = _dtPatients;
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_PageNumber > 0 && _PageNumber != 1)
            {
                _PageNumber--;

                _dtPatients = clsPatient.GetSetOfPatientsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvPatients.DataSource = _dtPatients;
            }

            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;
        }

        private void showPartientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;

            frmPatientInfo Patient = new frmPatientInfo(clsPatient.GetPatientInfoByID(PatientID, ref clsGlobal.ErrorMessage), this);

            this.Hide();

            Patient.ShowDialog();

        }

        private void addAPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddEditPatient Patient = new frmAddEditPatient(-1, this);

            Patient.PatientAdded += _Raise;

            this.Hide();

            Patient.ShowDialog();
        }

        private void updatePatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;

            frmAddEditPatient Patient = new frmAddEditPatient(PatientID, this);

            this.Hide();

            Patient.ShowDialog();
        }

        private void _ShowResult(bool IsDeleted)
        {
            if (IsDeleted)
                MessageBox.Show("Patient Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Deletion Is Failed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _DeletePatient()
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;

            bool IsDeleted = clsPatient.DeletePatient(PatientID, clsGlobal.CurrentUser.UserID,ref clsGlobal.ErrorMessage);

            if(IsDeleted)
            {
                _dtPatients = clsPatient.GetSetOfPatientsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvPatients.DataSource = _dtPatients;
            }

            _ShowResult(IsDeleted);
        }

        private void deleteAPatienttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete this Patient", "Warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeletePatient();
            }
        }

        private void showPatientHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Impleted Yet");
        }
    }
}

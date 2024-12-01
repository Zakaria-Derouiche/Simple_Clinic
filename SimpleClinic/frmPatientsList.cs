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
        private string ErrorMessage = string.Empty;
        private int _PageNumber = 1;
        private int _RowsPerPage = 2;
        private int _TotalPagesNumber;
        private int _TotalPatientsNumber;
        public frmPatientsList()
        {
            InitializeComponent();
        }
        private void dgvPatientsList_Load()
        {
            dgvPatients.DataSource = clsPatient.GetSetOfPatientsData(_PageNumber, _RowsPerPage, ref ErrorMessage);
            lblPageNumber.Text = "Page (" + _PageNumber.ToString() + ")";
            lblRecordsNumber.Text = "Patients Number Per Page: " + dgvPatients.Rows.Count.ToString();
        }

        private void _PrepareFormInfo()
        {
            _TotalPatientsNumber = clsPatient.GetTotalPatientsNumber(ref ErrorMessage);
            _TotalPagesNumber = _TotalPatientsNumber % 2 == 0 ? (int)_TotalPatientsNumber / _RowsPerPage :
                ((int)_TotalPatientsNumber / _RowsPerPage) + 1;
            dgvPatientsList_Load();
            lblTotalRecordNumber.Text = "Total Patients Number: " + _TotalPatientsNumber.ToString();
            lblTotalPageNumber.Text = "Total Pages Number: " + _TotalPagesNumber.ToString();
        }
        private void frmPatientsList_Load(object sender, EventArgs e)
        {
            _PrepareFormInfo();
        }
        private void txtBoxPageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(_PageNumber > 1)
            {
                _PageNumber--;
                dgvPatientsList_Load();
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PageNumber < _TotalPagesNumber)
            {
                _PageNumber++;
                dgvPatientsList_Load();
            }
        }

        private void btnSearchPage_Click(object sender, EventArgs e)
        {
            int PageNumber = Convert.ToInt32(txtBoxPageNumber.Text);
            if (PageNumber <= _TotalPagesNumber && PageNumber >= 1)
            {
                _PageNumber = PageNumber;
                dgvPatientsList_Load();
            }
        }

        private void showPatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string NationalNumber = (string)dgvPatients.CurrentRow.Cells[0].Value;
            //frmPersonInfo Patient = new frmPersonInfo(NationalNumber);
            //this.Hide();
            //Patient.ShowDialog();
            //this.Show();
        }

        private void addAPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson AddPatient = new frmAddEditPerson(-1);
            this.Hide();
            AddPatient.ShowDialog();
            this.Show();
            _PrepareFormInfo();
        }

        private void updatePatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNumber = (string)dgvPatients.CurrentRow.Cells[0].Value;
            frmAddEditPerson UpdatePatient = new frmAddEditPerson(NationalNumber);
            this.Hide();
            UpdatePatient.ShowDialog();
            this.Show();
            _PrepareFormInfo();
        }

        private void _DeletePatient(string NationalNumber, ref string ErrorMessage)
        {
            //bool IsDeleted = clsPatient.DeletePatient(NationalNumber, ref ErrorMessage);
            //if (IsDeleted)
            //    MessageBox.Show("Patient Is Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show(ErrorMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void deleteAPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNumber = clsEncryptionDecryption.Encrypt((string)dgvPatients.CurrentRow.Cells[0].Value);
            string ErrorMessage = string.Empty;
            if (MessageBox.Show("Are You Sure You Want To Delete This Patients", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                _DeletePatient(NationalNumber, ref ErrorMessage);
            _PrepareFormInfo();

        }

        private void showPatientHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNumber = (string)dgvPatients.CurrentRow.Cells[0].Value;
            MessageBox.Show("Later.......");
        }
    }
}

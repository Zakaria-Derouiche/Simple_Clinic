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
    public partial class frmDoctorList : Form
    {

        private Form _Sender = null;

        private DataTable _dtDoctors = new DataTable();

        private int _PageNumber = 1;

        private int _RowsPerPage = 2;

        private int _TotalPageNumber;

        private int _DoctorsNumberPerPage;

        private int _TotalDoctorsNumber;

        public frmDoctorList(Form Sender)
        {
            InitializeComponent();

            _Sender = Sender;
        }

       
       

        private void _LoadInfo()
        {
            dgvDoctors.DataSource = _dtDoctors;

            lblPageNumber.Text += _PageNumber.ToString();

            lblRecordsNumber.Text += _DoctorsNumberPerPage.ToString();

            lblTotalPageNumber.Text += _TotalPageNumber.ToString();

            lblTotalRecordNumber.Text += _TotalDoctorsNumber.ToString();


        }
        private void frmDoctorList_Load(object sender, EventArgs e)
        {
            _dtDoctors = clsDoctor.GetSetOfDoctorsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

            _TotalDoctorsNumber = clsDoctor.GetTotalDoctorsNumber(ref clsGlobal.ErrorMessage);

            _DoctorsNumberPerPage = _dtDoctors.Rows.Count;

            _TotalPageNumber = _TotalDoctorsNumber % _RowsPerPage == 0 ? (_TotalDoctorsNumber / _RowsPerPage) :
                ((_TotalDoctorsNumber / _RowsPerPage) + 1);

            _LoadInfo();

            btnNext.Enabled = _PageNumber != _TotalPageNumber;

            btnPrev.Enabled = _PageNumber != 1;

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

                _dtDoctors = clsDoctor.GetSetOfDoctorsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvDoctors.DataSource = _dtDoctors;
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

                _dtDoctors = clsDoctor.GetSetOfDoctorsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvDoctors.DataSource = _dtDoctors;
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;
            btnPrev.Enabled = _PageNumber != 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_PageNumber > 0 && _PageNumber != 1)
            {
                _PageNumber--;

                _dtDoctors = clsDoctor.GetSetOfDoctorsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvDoctors.DataSource = _dtDoctors;
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;
            btnPrev.Enabled = _PageNumber != 1;
        }

        private void showDoctorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DoctorID = (int)dgvDoctors.CurrentRow.Cells[0].Value;

            frmDoctorInfo Doctor = new frmDoctorInfo(DoctorID, this);

            this.Hide();

            Doctor.ShowDialog();

        }

        private void _Raise(object sender, EventArgs e)
        {
            _dtDoctors = clsDoctor.GetSetOfDoctorsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

            dgvDoctors.DataSource = _dtDoctors;
        }

        private void addADoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddEditDoctor Add = new frmAddEditDoctor(-1, this);

            Add.DoctorAddedOrUpdated += _Raise;

            this.Hide();

            Add.ShowDialog();
        }


        private void _ShowResult(bool IsDeleted)
        {
            if (IsDeleted)
                MessageBox.Show("Employee Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Deletion Is Failed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _DeleteDoctor()
        {
            int DoctorID = (int)dgvDoctors.CurrentRow.Cells[0].Value;

            bool IsDeleted = clsDoctor.DeleteDoctor(DoctorID, clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            if (IsDeleted)
            {
                _dtDoctors = clsDoctor.GetSetOfDoctorsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvDoctors.DataSource = _dtDoctors;
            }

            _ShowResult(IsDeleted);
        }

        private void deleteADoctortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete this Employee", "Warning", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeleteDoctor();
            }

        }

        private void UpdateADoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DoctorID = (int)dgvDoctors.CurrentRow.Cells[0].Value;

            frmAddEditDoctor Add = new frmAddEditDoctor(DoctorID, this);

            Add.DoctorAddedOrUpdated += _Raise;

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

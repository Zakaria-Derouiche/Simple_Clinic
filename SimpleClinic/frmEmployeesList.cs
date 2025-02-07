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
    public partial class frmEmployeesList : Form
    {

        private Form _Sender = null;

        private DataTable _dtEmployees = new DataTable();


        private int _PageNumber = 1;
        private int _RowsPerPage = 2;
        private int _TotalPageNumber;
        private int _EmployeesNumberPerPage;
        private int _TotalEmployeesNumber;
        public frmEmployeesList(Form Sender)
        {
            InitializeComponent();

            _Sender = Sender;


        }

        private void _LoadInfo()
        {
            dgvEmployees.DataSource = _dtEmployees;

            lblPageNumber.Text += _PageNumber.ToString();

            lblRecordsNumber.Text += _EmployeesNumberPerPage.ToString();

            lblTotalPageNumber.Text += _TotalPageNumber.ToString();

            lblTotalRecordNumber.Text += _TotalEmployeesNumber.ToString();


        }
        private void frmEmployeesList_Load(object sender, EventArgs e)
        {
            _dtEmployees = clsEmployee.GetSetOfEmployeesData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

            _TotalEmployeesNumber = clsEmployee.GetTotalEmployeesNumber(ref clsGlobal.ErrorMessage);

            _EmployeesNumberPerPage = _dtEmployees.Rows.Count;

            _TotalPageNumber = _TotalEmployeesNumber % _RowsPerPage == 0 ? (_TotalEmployeesNumber / _RowsPerPage) :
                ((_TotalEmployeesNumber / _RowsPerPage) + 1);

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

                _dtEmployees = clsEmployee.GetSetOfEmployeesData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvEmployees.DataSource = _dtEmployees;
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

                _dtEmployees = clsEmployee.GetSetOfEmployeesData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvEmployees.DataSource = _dtEmployees;
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;
            btnPrev.Enabled = _PageNumber != 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_PageNumber > 0 && _PageNumber != 1)
            {
                _PageNumber--;

                _dtEmployees = clsEmployee.GetSetOfEmployeesData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvEmployees.DataSource = _dtEmployees;
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;
            btnPrev.Enabled = _PageNumber != 1;
        }

        private void showEmployeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int EmployeeID = (int)dgvEmployees.CurrentRow.Cells[0].Value;

            frmEmployeeInfo Employee = new frmEmployeeInfo(EmployeeID, this);

            this.Hide();

            Employee.ShowDialog();

        }

        private void _Raise(object sender, clsEmployee Employee)
        {
            _dtEmployees = clsEmployee.GetSetOfEmployeesData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

            dgvEmployees.DataSource = _dtEmployees;
        }

        private void addAEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddEditEmployee Add = new frmAddEditEmployee(-1, this);

            Add.EmployeeAdded += _Raise;

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
        private void _DeleteEmployee()
        {
            int EmployeeID = (int)dgvEmployees.CurrentRow.Cells[0].Value;

            bool IsDeleted = clsEmployee.DeleteEmployee(EmployeeID, clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            if (IsDeleted)
            {
                _dtEmployees = clsEmployee.GetSetOfEmployeesData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvEmployees.DataSource = _dtEmployees;
            }

            _ShowResult(IsDeleted);
        }

        private void deleteAnEmployeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete this Employee", "Warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeleteEmployee();
            }
        }

       
    }
}

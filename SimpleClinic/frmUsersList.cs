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
    public partial class frmUsersList : Form
    {

        private Form _Sender = null;

        private DataTable _dtUsers = new DataTable();

        private int _PageNumber = 1;

        private int _RowsPerPage = 2;

        private int _TotalPageNumber;

        private int _UsersNumberPerPage;

        private int _TotalUsersNumber;

        public frmUsersList(Form Sender = null)
        {
            InitializeComponent();

            _Sender = Sender;
        }


        private void _LoadInfo()
        {
            dgvUsers.DataSource = _dtUsers;

            lblPageNumber.Text += _PageNumber.ToString();

            lblRecordsNumber.Text += _UsersNumberPerPage.ToString();

            lblTotalPageNumber.Text += _TotalPageNumber.ToString();

            lblTotalRecordNumber.Text += _TotalUsersNumber.ToString();


        }
        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _dtUsers = clsUser.GetSetOfUsers(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

            _TotalUsersNumber = clsUser.GetTotalUsersNumber(ref clsGlobal.ErrorMessage);

            _UsersNumberPerPage = _dtUsers.Rows.Count;

            _TotalPageNumber = _TotalUsersNumber % _RowsPerPage == 0 ? (_TotalUsersNumber / _RowsPerPage) :
                ((_TotalUsersNumber / _RowsPerPage) + 1);

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

                _dtUsers = clsDoctor.GetSetOfDoctorsData(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvUsers.DataSource = _dtUsers;
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

                _dtUsers = clsUser.GetSetOfUsers(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvUsers.DataSource = _dtUsers;
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;
            btnPrev.Enabled = _PageNumber != 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_PageNumber > 0 && _PageNumber != 1)
            {
                _PageNumber--;

                _dtUsers = clsUser.GetSetOfUsers(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvUsers.DataSource = _dtUsers;
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;
            btnPrev.Enabled = _PageNumber != 1;
        }

        private void showUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            frmUserInfo Doctor = new frmUserInfo(UserID, this);

            this.Hide();

            Doctor.ShowDialog();

        }

        private void _Raise(object sender, EventArgs e)
        {
            _dtUsers = clsUser.GetSetOfUsers(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

            dgvUsers.DataSource = _dtUsers;
        }

        private void addAUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddEditUser Add = new frmAddEditUser(-1, this);

            Add.UserAddedOrUpdated += _Raise;

            this.Hide();

            Add.ShowDialog();
        }


        private void _ShowResult(bool IsDeleted)
        {
            if (IsDeleted)
                MessageBox.Show("User Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Deletion Is Failed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void _DeleteUser()
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            bool IsDeleted = clsUser.DeleteUser(UserID, clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            if (IsDeleted)
            {
                _dtUsers = clsUser.GetSetOfUsers(_PageNumber, _RowsPerPage, ref clsGlobal.ErrorMessage);

                dgvUsers.DataSource = _dtUsers;
            }

            _ShowResult(IsDeleted);
        }

        private void deleteAUsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete this User", "Warning", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeleteUser();
            }

        }

        private void UpdateAUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            frmAddEditUser Add = new frmAddEditUser(UserID, this);

            Add.UserAddedOrUpdated += _Raise;

            this.Hide();

            Add.ShowDialog();
        }

       

        private void desactivateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.GetUserInfoByID((int)dgvUsers.CurrentRow.Cells[0].Value, ref clsGlobal.ErrorMessage);

            User.IsActive = false;

            if (User.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage))
                _Raise(null, EventArgs.Empty);
            
        }

        private void activateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            clsUser User = clsUser.GetUserInfoByID((int)dgvUsers.CurrentRow.Cells[0].Value, ref clsGlobal.ErrorMessage);

            User.IsActive = true;

            if (User.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage))
                _Raise(null, EventArgs.Empty);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();


            this.Close();
        }


    }
}

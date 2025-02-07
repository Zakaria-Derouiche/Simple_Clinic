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
    public partial class frmPeopleList : Form
    {
        private Form _Sender;

        private DataTable _dtPeople;

        private int _PeopleNumberPerPage;

        private int _PageNumber;

        private int _RowsNumberPerPage;

        private int _TotalPageNumber;

        private int _TotalPeopleNumber;

        private void _Raise(object sender, clsPerson Person)
        {
            _dtPeople = clsPerson.GetSetOfPeopleData(_PageNumber, _RowsNumberPerPage, ref clsGlobal.ErrorMessage);

            dgvPeople.DataSource = _dtPeople;

        }
        public frmPeopleList(Form Sender = null)
        {
            InitializeComponent();

            _Sender = Sender;

            _dtPeople = new DataTable();

            _PageNumber = 1;

            _RowsNumberPerPage = 3;

            btnPrev.Enabled = false;
        }

        private void _LoadInfo()
        {
            dgvPeople.DataSource = _dtPeople;

            lblPageNumber.Text +=_PageNumber.ToString();

            lblRecordsNumber.Text += _PeopleNumberPerPage.ToString();

            lblTotalPageNumber.Text += _TotalPageNumber.ToString();

            lblTotalRecordNumber.Text += _TotalPeopleNumber.ToString();

            
        }
        private void frmPeopleList_Load(object sender, EventArgs e)
        {
            _dtPeople = clsPerson.GetSetOfPeopleData(_PageNumber, _RowsNumberPerPage, ref clsGlobal.ErrorMessage);

            _TotalPeopleNumber = clsPerson.GetTotalPeopleNumber(ref clsGlobal.ErrorMessage);

            _PeopleNumberPerPage = _dtPeople.Rows.Count;

            _TotalPageNumber = _TotalPeopleNumber % _RowsNumberPerPage == 0 ? (_TotalPeopleNumber / _RowsNumberPerPage):
                ((_TotalPeopleNumber / _RowsNumberPerPage) + 1);

            _LoadInfo(); 

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

                _dtPeople = clsPerson.GetSetOfPeopleData(_PageNumber, _RowsNumberPerPage, ref clsGlobal.ErrorMessage);

                dgvPeople.DataSource = _dtPeople;
            }
            else
            {
                txtBoxPageNumber.Text = _PageNumber.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ( _PageNumber < _TotalPageNumber)
            {
                _PageNumber++;

                _dtPeople = clsPerson.GetSetOfPeopleData(_PageNumber, _RowsNumberPerPage, ref clsGlobal.ErrorMessage);

                dgvPeople.DataSource = _dtPeople;
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;
            btnPrev.Enabled = _PageNumber != 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_PageNumber > 0  && _PageNumber != 1)
            { 
                _PageNumber--;

                _dtPeople = clsPerson.GetSetOfPeopleData(_PageNumber, _RowsNumberPerPage, ref clsGlobal.ErrorMessage);

                dgvPeople.DataSource = _dtPeople;
            }
            btnNext.Enabled = _PageNumber != _TotalPageNumber;
            btnPrev.Enabled = _PageNumber != 1; 
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            frmPersonInfo Person = new frmPersonInfo(clsPerson.GetPersonInfoByID(PersonID, ref clsGlobal.ErrorMessage), this);

            this.Hide();

            Person.ShowDialog();

        }

        private void addAPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmAddEditPerson Person = new frmAddEditPerson(-1, this);

            Person.PersonAddedOrUpdated += _Raise;

            this.Hide();

            Person.ShowDialog();
        }


        private void updatePersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;


            frmAddEditPerson Person = new frmAddEditPerson(PersonID, this);

            Person.PersonAddedOrUpdated += _Raise;

            this.Hide();

            Person.ShowDialog();
        }

        private void _ShowResult(bool IsDeleted)
        {
            if(IsDeleted)
                MessageBox.Show("Person Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Deletion Is Failed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _DeletePerson()
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            bool IsDeleted = clsPerson.DeletePerson(PersonID, ref clsGlobal.ErrorMessage);

            if(IsDeleted)
            {
                _dtPeople = clsPerson.GetSetOfPeopleData(_PageNumber, _RowsNumberPerPage, ref clsGlobal.ErrorMessage);

                dgvPeople.DataSource = _dtPeople;
            }

            _ShowResult(IsDeleted);
        }

        private void deleteAPersontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete this Person", "Warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _DeletePerson();
            }
        }
    }
}

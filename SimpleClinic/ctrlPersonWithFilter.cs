using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class ctrlPersonWithFilter : UserControl
    {
        public event EventHandler PersonSelected;
        private void _Raise(object sender, EventArgs e)
        {
            PersonSelected?.Invoke(this, null);
        }
        private clsPerson _Person = new clsPerson();

        public clsPerson Person { get { return _Person; } }

        public ctrlPersonWithFilter()
        {
            InitializeComponent();
        }   
        private void comBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilterBy.Text = string.Empty;

            _Person = new clsPerson();

            ctrlPersonInfo1.LoadPersonInfo(_Person);
        }
        private void ctrlPersonWithFilter_Load(object sender, EventArgs e)
        {
            comBoxFilterBy.SelectedIndex = 0;

            btnFind.Enabled = false;
        }
        private void txtBoxFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(comBoxFilterBy.SelectedIndex == 0) 
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar);
            else
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void txtBoxFilterBy_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxFilterBy.Text == string.Empty)
                btnFind.Enabled = false;
            else 
                btnFind.Enabled = true;
        }
        public void LoadPersonInfo(clsPerson Person)
        {
            _Person = Person;

            ctrlPersonInfo1.LoadPersonInfo(Person);

            gBoxFilter.Enabled = false;
           
        }
        private void _GetPerson()
        {
            if (comBoxFilterBy.SelectedIndex == 0)
                _Person = clsPerson.GetPersonInfoByNationalNumber(clsEncryptionDecryption.Encrypt(txtBoxFilterBy.Text),
                    ref clsGlobal.ErrorMessage);
            else
                _Person = clsPerson.GetPersonInfoByFullName(string.Join(" ", txtBoxFilterBy.Text.Split(' ').
                Select(Val => clsEncryptionDecryption.Encrypt(Val))), ref clsGlobal.ErrorMessage);

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
           _GetPerson();

            ctrlPersonInfo1.LoadPersonInfo(_Person);

            _Raise(this, null);
        }

        private void _Raise1(object sender, clsPerson Person)
        {
           LoadPersonInfo(Person);

           _Raise(this, null);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmAddEditPerson Person = new frmAddEditPerson(-1, ParentForm);

            ParentForm.Hide();

            Person.PersonAddedOrUpdated += _Raise1;

            Person.ShowDialog();

        }
    }
}

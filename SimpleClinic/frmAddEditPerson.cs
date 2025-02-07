using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class frmAddEditPerson : Form
    {
        private Form _Sender;

        public event EventHandler<clsPerson> PersonAddedOrUpdated;
        private void _RaiseEvent()
        {
            PersonAddedOrUpdated?.Invoke(this, _Person);
        }

        private string _NationalNumber = string.Empty;

        private clsPerson _Person = new clsPerson();

        private Dictionary<string, string> dicCountries = new Dictionary<string, string>();

        private bool _IsChanged = false;

        private enum enMode { Add, Edit}

        private enMode _Mode;
        public frmAddEditPerson(int PersonID = -1, Form sender = null)
        {
            InitializeComponent();

            _Sender = sender;

            dicCountries = clsCountry.GetAllCountries();

            _Person = clsPerson.GetPersonInfoByID(PersonID, ref clsGlobal.ErrorMessage);

            _Mode = _Person == null || _Person.ID < 1 ? enMode.Add : enMode.Edit; 

            //if(_Mode == enMode.Edit)
            //    clsEncryptionDecryption.DecryptPersonInfo(ref _Person);

        }

        public frmAddEditPerson(clsPerson Person, Form sender = null)
        {
            InitializeComponent();

            _Sender = sender;

            dicCountries = clsCountry.GetAllCountries();

            _Person = Person;

            _Mode = _Person == null || _Person.ID < 1 ? enMode.Add : enMode.Edit;

            _LoadPersonInfo();

        }

        public frmAddEditPerson(string NationalNumber = "", Form sender = null)
        {
            InitializeComponent();

            _Sender = sender;

            dicCountries = clsCountry.GetAllCountries();

            _Person = clsPerson.GetPersonInfoByNationalNumber(NationalNumber, ref clsGlobal.ErrorMessage);

            _Mode = _Person == null || _Person.ID < 1 ? enMode.Add : enMode.Edit;
        }
        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _LoadPersonInfo();
        }      
        private void _LoadPersonInfo()
        {
            lblTitle.Text = _Person == null || _Person.ID == -1 ? "Add New Patient" : "Edit Patient Data";

            lblTitle.Location = new Point((this.Size.Width /2) - (lblTitle.Size.Width / 2), 21);

            comBoxNationality.Items.AddRange(dicCountries.Keys.ToArray());

            dtpDateOfBirth.MaxDate = DateTime.Now;

            lblPersonID.Text = _Mode == enMode.Add ? "" : _Person.ID.ToString();

            txtBoxNationalNumber.Text = _Mode == enMode.Add ? "" : _Person.NationalNumber;

            txtBoxFirstName.Text = _Mode == enMode.Add ? "" : _Person.FirstName;

            txtBoxMidlleName.Text = _Mode == enMode.Add  ? "" : _Person.MidlleName;

            txtBoxLastName.Text = _Mode == enMode.Add ? "" : _Person.LastName;

            dtpDateOfBirth.Text = _Mode == enMode.Add ? "" : _Person.BirthDate.ToShortDateString();

            rbMale.Checked = _Mode == enMode.Add ? true : _Person.Gender;

            rbFemale.Checked = _Mode == enMode.Add ? false : !_Person.Gender;

            txtBoxEmail.Text = _Mode == enMode.Add ? "" : _Person.Email;

            txtBoxPhone.Text = _Mode == enMode.Add ? "+" + dicCountries.ElementAt(2).Value.Trim() + " " :
                "+" + dicCountries.ElementAt(_Person.CountryID - 1).Value.Trim() + " " +  _Person.Phone;    

            comBoxNationality.SelectedIndex = _Person == null || _Person.ID == -1 ? 2 : _Person.CountryID - 1;

            txtBoxAddress.Text = _Person == null || _Person.ID == -1 ? "" : _Person.Address;

            btnSave.Enabled = _Person != null && _Person.ID != -1;
        }     
        private void TextBoxKey_Press(object sender, KeyPressEventArgs e)
        {
            sender = (TextBox)sender;
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
        private void txtBoxNationalNumnber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar); 
        }
        private void txtBoxNationalNumnber_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Add && 
                clsPerson.IsPersonExist(clsEncryptionDecryption.Encrypt(txtBoxNationalNumber.Text), ref clsGlobal.ErrorMessage)) 
            {
                errorProvider1.SetError(txtBoxNationalNumber, "This National No Is Linked With Another Person");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBoxNationalNumber, null);
                e.Cancel = false;
            }
        }
        private void txtBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBoxPhone.Text[txtBoxPhone.Text.Length - 1] == ' ')
                e.Handled = !char.IsDigit(e.KeyChar);
            else
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        private void txtBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@' ;
        }
        private void txtBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void comBoxNationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           txtBoxPhone.Text = _Mode == enMode.Add ? "+" + dicCountries.ElementAt(comBoxNationality.SelectedIndex).Value.Trim() + " ":
                "+" + dicCountries.ElementAt(comBoxNationality.SelectedIndex).Value.Trim() + " " + _Person.Phone;
            
        }
        private void txtBoxPhone_Validating(object sender, CancelEventArgs e)
        {
            string Phone = txtBoxPhone.Text.Split(' ')[1];
            if (!clsValidation.ValidateInteger(Phone))
            {
                errorProvider1.SetError(txtBoxPhone, "Invalid Phone Number");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBoxPhone, null);
                e.Cancel = false;
            } 
        }
        private void txtBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            string Email = txtBoxEmail.Text.Trim();
            if(!clsValidation.ValidateEmail(Email))
            {
                errorProvider1.SetError(txtBoxEmail, "Invalid Email");
                e.Cancel = true;
            }else
            {
                errorProvider1.SetError(txtBoxEmail, null);
                e.Cancel = false;
            }
        }
        private bool _CheckEmptyInputs()
        {
            return !string.IsNullOrEmpty(txtBoxFirstName.Text) && !string.IsNullOrEmpty(txtBoxLastName.Text) &&
                   !string.IsNullOrEmpty(txtBoxPhone.Text.Split(' ')[1]) && !string.IsNullOrEmpty(txtBoxEmail.Text) &&
                   !string.IsNullOrEmpty(txtBoxAddress.Text) && !string.IsNullOrEmpty(txtBoxNationalNumber.Text);
        }
        private bool _IsPersonInfoChanged()
        {

            return _Mode == enMode.Add || !(txtBoxNationalNumber.Text == _Person.NationalNumber &&
                txtBoxFirstName.Text == _Person.FirstName && txtBoxMidlleName.Text == _Person.MidlleName &&
                txtBoxLastName.Text == _Person.LastName && dtpDateOfBirth.Value == _Person.BirthDate
                && rbMale.Checked == _Person.Gender && txtBoxPhone.Text.Split(' ')[1] == _Person.Phone
                && txtBoxEmail.Text == _Person.Email && txtBoxAddress.Text == _Person.Address
                && comBoxNationality.SelectedIndex + 1 == _Person.CountryID);

        }
        private bool _CheckInputValidation()
        {
            bool IsValid = _CheckEmptyInputs();
            if (!IsValid)
                MessageBox.Show("Empty Fields Are Not Allowed Unless Middle Name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return IsValid;
        }
        private void _FillPersonData()
        {
            
            _Person.NationalNumber = clsEncryptionDecryption.Encrypt(txtBoxNationalNumber.Text);

            _Person.FirstName = clsEncryptionDecryption.Encrypt(txtBoxFirstName.Text);

            _Person.MidlleName = clsEncryptionDecryption.Encrypt(txtBoxMidlleName.Text);

            _Person.LastName = clsEncryptionDecryption.Encrypt(txtBoxLastName.Text);

            _Person.Gender = rbMale.Checked;

            _Person.BirthDate = dtpDateOfBirth.Value;

            _Person.Phone = clsEncryptionDecryption.Encrypt(txtBoxPhone.Text.Split(' ')[1]);

            _Person.Email = clsEncryptionDecryption.Encrypt(txtBoxEmail.Text);

            _Person.Address = clsEncryptionDecryption.Encrypt(txtBoxAddress.Text);

            _Person.CountryID = Convert.ToByte(comBoxNationality.SelectedIndex + 1);
        }
        private void _AddNewPerson()
        {
            _Person = new clsPerson();

            _FillPersonData();

            bool IsSaved = _Person.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            _IsChanged = IsSaved;

            lblPersonID.Text = IsSaved ? "N/A" : _Person.ID.ToString();

            _Mode = IsSaved ? enMode.Edit : enMode.Add;

            string Message = IsSaved ? "Successfull Save Operation" : "Failed Operation";

            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void _UpdatePersonInfo()
        {
            
            _FillPersonData();

            bool IsSaved = _Person.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            _IsChanged = IsSaved;

            string Message = IsSaved ? "Successfull Save Operation" : "Failed Operation";

            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }     
        private void _Save()
        {

            if(_Mode == enMode.Add)
            {
                _AddNewPerson();
            }
            else
            { 
                _UpdatePersonInfo();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if(!this.ValidateChildren()||!_CheckInputValidation() ||!_IsPersonInfoChanged())

                return;

            _Save();
        }   
        private void btnClose_Click(object sender, EventArgs e)
        {
            if(_IsChanged)
            {
                clsEncryptionDecryption.DecryptPersonInfo(ref _Person);

                _RaiseEvent();
            }
              
            if (_Sender != null)
                _Sender.Show();

            this.Close();
        }
    }
}

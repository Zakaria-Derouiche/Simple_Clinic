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
    public partial class ctrlPersonInfo : UserControl
    {
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }
        public void LoadPersonInfo(clsPerson Person)
        {  
            lblID.Text = Person == null || Person.ID == -1? "[???]" : Person.ID.ToString();
            lblNationalNumber.Text = Person == null || Person.ID == -1 ? "[???]" : Person.NationalNumber;
            lblFullName.Text = Person == null || Person.ID == -1 ? "[???]" : Person.FullName;
            lblGender.Text = Person == null || Person.ID == -1 ? "[???]" : Person.Gender? "Male" :"Female";
            lblDateOfBirth.Text = Person == null || Person.ID == -1 ? "[???]" : Person.BirthDate.ToShortDateString();
            lblPhone.Text = Person == null || Person.ID == -1 ? "[???]" : Person.Phone;
            lblEmail.Text = Person == null || Person.ID == -1 ? "[???]" : Person   .Email;
            lblAddress.Text = Person == null || Person.ID == -1 ? "[???]" : Person.Address;
            lblNationality.Text = Person == null || Person.ID == -1 ? "[???]" : Person.Country.CountryName;
        }  
    }
}

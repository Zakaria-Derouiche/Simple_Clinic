using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using ClinicBusiness;

namespace ClinicBusiness
{
    public class clsPerson
    {
        private enum enMode { Add = 1, Edit = 2 }
        private enMode _Mode;
        public int ID { set; get; }
        public string NationalNumber { set; get; }
        public string FirstName { set; get; }
        public string MidlleName { set; get; }
        public string LastName { set; get; }
        public DateTime BirthDate { set; get; }
        public bool Gender { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public byte CountryID { set; get; }
        public bool IsPersonDeleted { get; }
        public string FullName
        {
            get
            {
                return MidlleName != string.Empty ? FirstName + " " + MidlleName + " " + LastName : FirstName + " " + LastName;
            }
        }
        public clsCountry Country
        {
            get
            {
                return this.CountryID == 0 ? null : clsCountry.GetCountryByID(this.CountryID);
            }
        }
        public clsPerson()
        {
            ID = -1;
            NationalNumber = string.Empty;
            FirstName = string.Empty;
            MidlleName = string.Empty;
            LastName = string.Empty;
            BirthDate = DateTime.Now;
            Gender = true;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            CountryID = 3;
            _Mode = enMode.Add;
        }
        public clsPerson(int ID, string NationalNumber, string FirstName, string MidlleName, string LastName, DateTime BirthDate,
            bool Gender, string Phone, string Email, string Address, byte CountryID)
        {
            this.ID = ID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.MidlleName = MidlleName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.CountryID = CountryID;
            _Mode = enMode.Edit;
        }
        private static void DecryptPersonInfo(ref string nationalNumber, ref string firstName, ref string midlleName, ref string lastName,
        ref string phone, ref string email, ref string address)
        {
            nationalNumber = clsEncryptionDecryption.Decrypt(nationalNumber);
            firstName = clsEncryptionDecryption.Decrypt(firstName);
            midlleName = midlleName == string.Empty ? "" : clsEncryptionDecryption.Decrypt(midlleName);
            lastName = clsEncryptionDecryption.Decrypt(lastName);
            phone = clsEncryptionDecryption.Decrypt(phone);
            email = clsEncryptionDecryption.Decrypt(email);
            address = clsEncryptionDecryption.Decrypt(address);
        }
        public static clsPerson GetPersonInfoByID(int ID, ref string ErrorMessage)
        {
            string nationalNumber = string.Empty;
            string firstName = string.Empty;
            string midleName = string.Empty;
            string lastName = string.Empty;
            DateTime birthDate = new DateTime();
            bool gender = true;
            string phone = string.Empty;
            string email = string.Empty;
            string address = string.Empty;
            byte countryID = 213;
            if (clsPersonData.GetPersonInfoByID(ID, ref nationalNumber, ref firstName, ref midleName, ref lastName, ref birthDate, ref gender,
                ref phone, ref email, ref address, ref countryID, ref ErrorMessage))
            {
                DecryptPersonInfo(ref nationalNumber, ref firstName, ref midleName, ref lastName, ref phone, ref email, ref address);
                return new clsPerson(ID, nationalNumber, firstName, midleName, lastName, birthDate, gender, phone, email,
                    address, countryID);
            }
            else
            {
                return null;
            }
        }
        public static clsPerson GetPersonInfoByNationalNumber(string NationalNumber, ref string ErrorMessage)
        {
            int iD = -1;
            string firstName = string.Empty;
            string midleName = string.Empty;
            string lastName = string.Empty;
            DateTime birthDate = new DateTime();
            bool gender = true;
            string phone = string.Empty;
            string email = string.Empty;
            string address = string.Empty;
            byte countryID = 213;
            if (clsPersonData.GetPersonInfoByNationalNumber(NationalNumber, ref iD, ref firstName, ref midleName, ref lastName,
                ref birthDate, ref gender, ref phone, ref email, ref address, ref countryID, ref ErrorMessage))
            {
                DecryptPersonInfo(ref NationalNumber, ref firstName, ref midleName, ref lastName, ref phone, ref email, ref address);
                return new clsPerson(iD, NationalNumber, firstName, midleName, lastName, birthDate, gender, phone, email,
                    address, countryID);
            }
            else
            {
                return null;
            }
        }
        public static clsPerson GetPersonInfoByFullName(string FullName, ref string ErrorMessage)
        {
            int iD = -1;
            string nationalNumber = string.Empty;
            string firstName = string.Empty;
            string midleName = string.Empty;
            string lastName = string.Empty;
            DateTime birthDate = new DateTime();
            bool gender = true;
            string phone = string.Empty;
            string email = string.Empty;
            string address = string.Empty;
            byte countryID = 213;
            if (clsPersonData.GetPersonInfoByFullName(FullName, ref iD, ref nationalNumber, ref firstName, ref midleName,
                ref lastName, ref birthDate, ref gender, ref phone, ref email, ref address, ref countryID, ref ErrorMessage))
            {
                DecryptPersonInfo(ref nationalNumber, ref firstName, ref midleName, ref lastName, ref phone, ref email, ref address);
                return new clsPerson(iD, nationalNumber, firstName, midleName, lastName, birthDate, gender, phone, email,
                    address, countryID);
            }
            else
            {
                return null;
            }
        }
        public virtual bool Save(int UserID, ref string ErrorMessage)
        {
            bool IsSaved = false;
            switch (_Mode)
            {
                case enMode.Add:
                    int NewID = -1;
                    IsSaved = clsPersonData.AddNewPerson(ref NewID, NationalNumber, FirstName, MidlleName, LastName, BirthDate,
                        Gender, Phone, Email, Address, CountryID, UserID, ref ErrorMessage);
                    ID = NewID;
                    _Mode = enMode.Edit;
                    break;
                case enMode.Edit:
                    IsSaved = clsPersonData.UpdatePersonInfo(ID, NationalNumber, FirstName, MidlleName, LastName, BirthDate,
                       Gender, Phone, Email, Address, CountryID, UserID, ref ErrorMessage);
                    break;
            }
            return IsSaved;
        }
        public static bool DeletePerson(int PatientID, ref string ErrorMessage)
        {
            return clsPersonData.DeletePerson(PatientID, ref ErrorMessage);
        }
        public static bool DeletePerson(string NationalNumber, ref string ErrorMessage)
        {
            return clsPersonData.DeletePerson(NationalNumber, ref ErrorMessage);
        }
        public static bool IsPersonExist(int PersonID, ref string ErrorMessage)
        {
            return clsPersonData.IsPersonExist(PersonID, ref ErrorMessage);
        }
        public static bool IsPersonExist(string NationalNumber, ref string ErrroMessage)
        {
            return clsPersonData.IsPersonExist(NationalNumber, ref ErrroMessage);
        }
        public static bool IsPersonExistByName(string FullName, ref string ErrroMessage)
        {
            return clsPersonData.IsPersonExistByFullName(FullName, ref ErrroMessage);
        }
        public static DataTable GetSetOfPeopleData(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtDecryptedPeople = new DataTable();
            dtDecryptedPeople.Columns.Add("ID", typeof(int));
            dtDecryptedPeople.Columns.Add("National Number", typeof(string));
            dtDecryptedPeople.Columns.Add("Full Name", typeof(string));
            dtDecryptedPeople.Columns.Add("Date Of Birth", typeof(DateTime));
            dtDecryptedPeople.Columns.Add("Gender", typeof(string));
            dtDecryptedPeople.Columns.Add("Phone", typeof(string));
            DataTable dtEncryptedPeople = clsPersonData.GetSetOfPeoplePerPage(PageNumber, RowsPerPage, ref ErrorMessage);
            foreach (DataRow row in dtEncryptedPeople.Rows)
            {
                dtDecryptedPeople.Rows.Add((int)row["ID"],
                    clsEncryptionDecryption.Decrypt((string)row["NationalNumber"]),
                    string.Join(" ", ((string)row["Full Name"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    (DateTime)row["Date Of birth"],
                    (string)row["Gender"],
                    clsEncryptionDecryption.Decrypt((string)row["Phone"])
                );
            }
            return dtDecryptedPeople;
        }
        public static int GetTotalPeopleNumber(ref string ErrorMessage)
        {
            return clsPersonData.GetPeopleTotalNumber(ref ErrorMessage);
        }
        ~clsPerson() { }
    }
}

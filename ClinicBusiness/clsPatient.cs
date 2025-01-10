using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using ClinicBusiness;

namespace ClinicBusiness
{
    public class clsPatient : clsPerson
    {
        private enum enMode { Add = 1, Edit = 2}

        private enMode _Mode;
        public int PatientID { set; get; }
        public clsPatient() : base() 
        {
            PatientID = -1;
            _Mode = enMode.Add;
        }

        public clsPatient(clsPerson Person)
        {
            ID = Person.ID;
            NationalNumber = Person.NationalNumber;
            FirstName = Person.FirstName;
            MidlleName = Person.MidlleName;
            LastName = Person.LastName;
            BirthDate = Person.BirthDate;
            Gender = Person.Gender;
            Phone = Person.Phone;
            Email = Person.Email;
            Address = Person.Address;
            CountryID = Person.CountryID;

            this.PatientID = -1;
            _Mode = enMode.Add;
        }

        private clsPatient(clsPerson Person, int PatientID) 
        {
            ID = Person.ID;
            NationalNumber = Person.NationalNumber;
            FirstName = Person.FirstName;
            MidlleName = Person.MidlleName;
            LastName = Person.LastName;
            BirthDate = Person.BirthDate;
            Gender = Person.Gender;
            Phone = Person.Phone;
            Email = Person.Email;
            Address = Person.Address;
            CountryID = Person.CountryID;

            this.PatientID = PatientID;
            _Mode = enMode.Edit;
        }

        public static clsPatient GetPatientInfoByID (int PatientID, ref string ErrorMessage)
        {
            int personID = -1;
            if(clsPatientData.GetPatientInfo(PatientID, ref personID, ref ErrorMessage))
            {
                return new clsPatient(clsPerson.GetPersonInfoByID(personID, ref ErrorMessage), PatientID);
            }else
            {
                return null;
            }
        }

        public static clsPatient GetPatientInfoByPersonID(int PersonID, ref string ErrorMessage)
        {
            int PatientID = -1;
            if (clsPatientData.GetPatientInfoByPersonID(PersonID, ref PatientID, ref ErrorMessage))
            {
                return new clsPatient(clsPerson.GetPersonInfoByID(PersonID, ref ErrorMessage), PatientID);
            }
            else
            {
                return null;
            }
        }
        public override bool Save (int UserID, ref string ErrorMessage)
        {
            bool IsSaved = false;
            switch(_Mode)
            {
                case enMode.Add:
                    int NewID = -1;
                    IsSaved = clsPatientData.AddNewPatient(ref NewID, ID, 1, ref ErrorMessage);
                    PatientID= NewID;
                    _Mode = enMode.Edit;
                    break;
                case enMode.Edit:
                    IsSaved = clsPatientData.UpdatePatientInfo(PatientID, ID, 1, ref ErrorMessage);
                    break;
            }
            return IsSaved;
        }
        public static bool DeletePatient(int PatientID, int UserID, ref string ErrorMessage)
        {
            return clsPatientData.DeletePatient(PatientID, UserID,ref ErrorMessage);
        }
        public static bool IsPatientExistByPersonID(int PersonID, ref string ErrorMessage)
        {
            return clsPatientData.IsPatientExistByPersonID(PersonID, ref ErrorMessage);
        }
        public static bool IsPatientExistByPersonNationalNumber(string NationalNumber, ref string ErrroMessage)
        {
            return clsPatientData.IsPatientExistByNationalNumber(NationalNumber, ref ErrroMessage);
        }

        
        public static DataTable GetSetOfPatientsData(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtEncryptedPatients = clsPatientData.GetPatientsPerPage(PageNumber, RowsPerPage, ref ErrorMessage);
            DataTable dtDecryptedPatients = new DataTable();
            dtDecryptedPatients.Columns.Add("Patient ID", typeof(int));
            dtDecryptedPatients.Columns.Add("Person ID", typeof(int));
            dtDecryptedPatients.Columns.Add("Full Name", typeof(string));
            dtDecryptedPatients.Columns.Add("Is Deleted", typeof(bool));
            dtDecryptedPatients.Columns.Add("Number Of Appointments", typeof(int));
            foreach (DataRow row in dtEncryptedPatients.Rows)
            {
                dtDecryptedPatients.Rows.Add(
                    (int)row["ID"],
                    (int)row["PersonID"],
                        string.Join(" ", ((string)row["Full Name"]).Split(' ').
                        Select(s => clsEncryptionDecryption.Decrypt(s))),
                    (bool)row["IsDeleted"],
                    (int)row["Appointments Number"]
                );
            }
            return dtDecryptedPatients;
        }
        public static int GetTotalPatientsNumber(ref string ErrorMessage)
        {
            return clsPatientData.GetPatientsTotalNumber(ref ErrorMessage);
        }
        ~clsPatient() { }
        
    }
}

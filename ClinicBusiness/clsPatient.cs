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
        private clsPatient(int ID, string NationalNumber, string FirstName , string MidlleName, string LastName, DateTime BirthDate,
            bool Gender, string Phone, string Email, string Address, byte CountryID, int PatientID, bool IsDeleted) :
            base (ID, NationalNumber,FirstName , MidlleName, LastName, BirthDate, Gender, Phone, Email, Address, CountryID)
        {
            this.PatientID = PatientID;
            _Mode = enMode.Edit;
        }
        public static clsPatient GetPatientInfoByID (int PatientID, ref string ErrorMessage)
        {
            int personID = -1;
            if(clsPatientData.GetPatientInfo(PatientID, ref personID, ref ErrorMessage))
            {
                clsPatient Patient = (clsPatient)clsPatient.GetPersonInfoByID(personID, ref ErrorMessage);
                Patient.PatientID = PatientID;
                return Patient;
            }else
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

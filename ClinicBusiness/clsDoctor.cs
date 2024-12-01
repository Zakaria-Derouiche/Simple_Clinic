using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using ClinicBusiness;
using System.Xml.Linq;

namespace ClinicBusiness
{
    public class clsDoctor : clsEmployee
    {
        private enum enMode { Add, Edit }
        private enMode _Mode;
        public int DoctorID { get; set; }
        public string Specialization { get; set; }
        public clsDoctor() : base() 
        {
            DoctorID = -1;
            Specialization = string.Empty;
        }
        private clsDoctor(int ID, string NationalNumber, string FirstName, string MidlleName, string LastName, DateTime BirthDate,
            bool Gender, string Phone, string Email, string Address, byte CountryID, int EmployeeID, string ImagePath,
            DateTime HireDtae, DateTime EndDate, bool TypeOfLeaving, string ReasonOfLeaving, int DoctorID, 
            string Specialization) :
            base(ID, NationalNumber, FirstName, MidlleName, LastName, BirthDate,Gender,  Phone, Email, Address, CountryID,
                EmployeeID, ImagePath, HireDtae, EndDate, TypeOfLeaving, ReasonOfLeaving)
        {
            this.DoctorID = DoctorID;
            this.Specialization = Specialization;
        }

        public static clsDoctor GetDoctorInfoByID(int DoctorID, ref string ErrorMessage)
        {
            int employeeID = -1;
            string specilaization = string.Empty;
            if (clsDoctorData.GetDoctorInfo(DoctorID, ref employeeID, ref specilaization, ref ErrorMessage))
            {
                clsDoctor Doctor = (clsDoctor)clsDoctor.GetEmployeeInfoByID(employeeID, ref ErrorMessage);
                Doctor.DoctorID = DoctorID;
                Doctor.Specialization = specilaization;
                return Doctor;
            }
            else
            {
                return null;
            }
        }
        public override bool  Save(int UserID, ref string ErrorMessage)
        {
            bool IsSaved = false;
            switch (_Mode)
            {
                case enMode.Add:
                    int NewID = -1;
                    IsSaved = clsDoctorData.AddNewDoctor(ref NewID, EmployeeID, Specialization, 1, ref ErrorMessage);
                    DoctorID = NewID;
                    _Mode = enMode.Edit;
                    break;
                case enMode.Edit:
                    IsSaved = clsDoctorData.UpdateDoctorInfo(DoctorID, EmployeeID, Specialization, 1, ref ErrorMessage);
                    break;
            }
            return IsSaved;
        }
        public static bool DeleteDoctor(int DoctorID, int UserID, ref string ErrorMessage)
        {
            return clsDoctorData.DeleteDoctor(DoctorID, UserID, ref ErrorMessage);
        }
        public static bool IsDoctorExistByID(int ID, ref string ErrorMessage)
        {
            return clsDoctorData.IsDoctorExistByID(ID, ref ErrorMessage);
        }
        public static bool IsDoctorExistByEmployeeID(int EmployeeID, ref string ErrorMessage)
        {
            return clsDoctorData.IsDoctorExistByEmployeeID(EmployeeID, ref ErrorMessage);
        }
       
        public static DataTable GetSetOfDoctorsData(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtEncryptedDoctors = clsDoctorData.GetSetOfDoctors(PageNumber, RowsPerPage, ref ErrorMessage);
            DataTable dtDecryptedDoctors = new DataTable();
            dtDecryptedDoctors.Columns.Add("Doctor ID", typeof(int));
            dtDecryptedDoctors.Columns.Add("Employee ID", typeof(int));
            dtDecryptedDoctors.Columns.Add("Full Name", typeof(string));
            dtDecryptedDoctors.Columns.Add("Specialization", typeof(string));
            dtDecryptedDoctors.Columns.Add("Hire Date", typeof(DateTime));
            dtDecryptedDoctors.Columns.Add("End Date", typeof(DateTime));
            
            foreach (DataRow row in dtEncryptedDoctors.Rows)
            {
                dtDecryptedDoctors.Rows.Add(
                    (int)row["ID"],
                    (int)row["EmployeeID"],
                        string.Join(" ", ((string)row["Full Name"]).Split(' ').
                        Select(s => clsEncryptionDecryption.Decrypt(s))),

                    (string)row["Specialization"],
                    (DateTime)row["HireDate"],
                    (DateTime)row["EndDate"]
                );
            }
            return dtDecryptedDoctors;
        }
        public static int GetTotalDoctorsNumber(ref string ErrorMessage)
        {
            return clsDoctorData.GetTotalDoctorsNumber(ref ErrorMessage);
        }
        ~clsDoctor() { }
    }
}

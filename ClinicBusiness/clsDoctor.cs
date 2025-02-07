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

        public clsDoctor(clsEmployee Employee)
        {
            ID = Employee.ID;
            NationalNumber = Employee.NationalNumber;
            FirstName = Employee.FirstName;
            MidlleName = Employee.MidlleName;
            LastName = Employee.LastName;
            BirthDate = Employee.BirthDate;
            Gender = Employee.Gender;
            Phone = Employee.Phone;
            Email = Employee.Email;
            Address = Employee.Address;
            CountryID = Employee.CountryID;
            EmployeeID = Employee.EmployeeID;
            ImagePath = Employee.ImagePath;
            HireDate = Employee.HireDate;
            EndDate = Employee.EndDate;
            TypeOfLeaving = Employee.TypeOfLeaving;
            ReasonOfLeaving = Employee.ReasonOfLeaving;

            DoctorID = -1;
            Specialization = "";
            _Mode = enMode.Add;
        }
        private clsDoctor(clsEmployee Employee, int DoctorID,  string Specialization) 
        {
            ID = Employee.ID;
            NationalNumber = Employee.NationalNumber;
            FirstName = Employee.FirstName;
            MidlleName = Employee.MidlleName;
            LastName = Employee.LastName;
            BirthDate = Employee.BirthDate;
            Gender = Employee.Gender;
            Phone = Employee.Phone;
            Email = Employee.Email;
            Address = Employee.Address;
            CountryID = Employee.CountryID;
            EmployeeID = Employee.EmployeeID;
            ImagePath = Employee.ImagePath;
            HireDate = Employee.HireDate;
            EndDate = Employee.EndDate; 
            TypeOfLeaving = Employee.TypeOfLeaving;
            ReasonOfLeaving = Employee.ReasonOfLeaving;

            this.DoctorID = DoctorID;
            this.Specialization = Specialization;
            _Mode = enMode.Edit;
        }

        public static clsDoctor GetDoctorInfoByID(int DoctorID, ref string ErrorMessage)
        {
            int employeeID = -1;
            string specilaization = string.Empty;
            if (clsDoctorData.GetDoctorInfo(DoctorID, ref employeeID, ref specilaization, ref ErrorMessage))
            {
                return new clsDoctor(clsEmployee.GetEmployeeInfoByID(employeeID, ref ErrorMessage), DoctorID, specilaization);
            }
            else
            {
                return null;
            }
        }

        public static clsDoctor GetDoctorInfoByEmployeeID(int EmployeeID, ref string ErrorMessage)
        {
            int DoctorID = -1;

            string specilaization = string.Empty;

            if (clsDoctorData.GetDoctorInfoByEmployeeID(EmployeeID, ref DoctorID, ref specilaization, ref ErrorMessage))
            {
                return new clsDoctor(clsEmployee.GetEmployeeInfoByID(EmployeeID, ref ErrorMessage), DoctorID, specilaization);
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
            dtDecryptedDoctors.Columns.Add("Hire Date", typeof(string));
            dtDecryptedDoctors.Columns.Add("End Date", typeof(string));
            
            foreach (DataRow row in dtEncryptedDoctors.Rows)
            {
                dtDecryptedDoctors.Rows.Add(
                    (int)row["ID"],
                    (int)row["EmployeeID"],
                        string.Join(" ", ((string)row["Full Name"]).Split(' ').
                        Select(s => clsEncryptionDecryption.Decrypt(s))),

                     (string)row["Specialization"],
                    row["HireDate"].ToString(),
                    row["EndDate"] == System.DBNull.Value ? "" : (string)row["EndDate"]
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

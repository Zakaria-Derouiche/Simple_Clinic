using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ClinicBusiness;

namespace ClinicBusiness
{
    public class clsEmployee : clsPerson
    {
        private enum enMode { Add = 1, Edit = 2 }

        private enMode _Mode;
        public int EmployeeID { set; get; }
        public string ImagePath { set; get; }
        public DateTime HireDate { set; get; }
        public Nullable<DateTime> EndDate { set; get; }
        public Nullable<bool> TypeOfLeaving { set; get; }
        public string ReasonOfLeaving { set; get; }

        public clsEmployee() : base()
        {
            EmployeeID = -1;
            ImagePath  = string.Empty;
            HireDate = DateTime.Now;
            EndDate = null;
            TypeOfLeaving = null;
            ReasonOfLeaving = string.Empty;
            _Mode = enMode.Add;
        }


        public clsEmployee(clsPerson Person)
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

            EmployeeID = -1;
            ImagePath = string.Empty;
            HireDate = DateTime.Now;
            EndDate = null;
            TypeOfLeaving = null;
            ReasonOfLeaving = string.Empty;
            _Mode = enMode.Add;

        }

        private clsEmployee(clsPerson Person, int EmployeeID,   string ImagePath,  DateTime HireDate, Nullable<DateTime> EndDate,
                Nullable<bool>TypeOfLeaving, string  ReasonOfLeaving)
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

            this.EmployeeID = EmployeeID;
            this.ImagePath = ImagePath;
            this.HireDate = HireDate;
            this.EndDate = EndDate;
            this.TypeOfLeaving = TypeOfLeaving;
            this.ReasonOfLeaving = ReasonOfLeaving;
            _Mode = enMode.Edit;

        }
        public static clsEmployee GetEmployeeInfoByID(int EmployeeID, ref string ErrorMessage)
        {

            int personID = -1;

            string imagePath = string.Empty;

            DateTime hireDate = DateTime.MinValue;

            Nullable<DateTime> endDate = null;

            Nullable<bool> typeOfLeaving = null;

            string reasonOfLeaving = string.Empty;

            if (clsEmployeeData.GetEmployeeInfo(EmployeeID, ref personID, ref  imagePath, ref hireDate, ref endDate,
                ref typeOfLeaving, ref reasonOfLeaving, ref ErrorMessage))
            {
                return new clsEmployee(GetPersonInfoByID(personID, ref ErrorMessage), EmployeeID,  imagePath,
                    hireDate, endDate, typeOfLeaving, reasonOfLeaving);
            }
            else
            {
                return null;
            }
        }
        
        public static clsEmployee GetEmployeeInfoByPersonID(int PersonID, ref string ErrorMessage)
        {
            int employeeID = -1;
            string imagePath = string.Empty;
            DateTime hireDate = DateTime.MinValue;
            Nullable<DateTime> endDate = null;
            Nullable<bool> typeOfLeaving = null;
            string reasonOfLeaving = string.Empty;
            if (clsEmployeeData.GetEmployeeInfoByPersonID(PersonID, ref employeeID, ref imagePath, ref hireDate, ref endDate,
                ref typeOfLeaving, ref reasonOfLeaving, ref ErrorMessage))
            {

                return new clsEmployee(clsPerson.GetPersonInfoByID(PersonID, ref ErrorMessage), employeeID, imagePath, hireDate,
                    endDate, typeOfLeaving,reasonOfLeaving);
            }
            else
            {
                return null;
            }
        }
        public override bool Save( int UserID, ref string ErrorMessage)
        {
            bool IsSaved = false;
            switch (_Mode)
            {
                case enMode.Add:
                    int NewID = -1;
                    IsSaved = clsEmployeeData.AddNewEmployee(ref NewID, ID, ImagePath, HireDate,1, ref ErrorMessage);
                    EmployeeID = NewID;
                    _Mode = enMode.Edit;
                    break;
                case enMode.Edit:
                    IsSaved = clsEmployeeData.UpdateEmployeeInfo(EmployeeID, ID, ImagePath, HireDate, EndDate, TypeOfLeaving,
                        ReasonOfLeaving, 1, ref ErrorMessage);
                    break;
            }
            return IsSaved;
        }
        public static bool DeleteEmployee(int EmployeeID, int UserID, ref string ErrorMessage)
        {
            return clsEmployeeData.DeleteEmployee(EmployeeID, UserID, ref ErrorMessage);
        }
        public static bool IsEmployeeExistByID(int ID, ref string ErrorMessage)
        {
            return clsEmployeeData.IsEmployeeExistByID(ID, ref ErrorMessage);
        }
        public static bool IsEmployeeExistByPersonID(int PersonID, ref string ErrorMessage)
        {
            return clsEmployeeData.IsEmployeeExistByPersonID(PersonID, ref ErrorMessage);
        }
        public static bool IsEmployeeExistByPersonNationalNumber(string NationalNumber, ref string ErrroMessage)
        {
            return clsEmployeeData.IsEmployeeExistByPersonNationalNumber(NationalNumber, ref ErrroMessage);
        }
        public static DataTable GetSetOfEmployeesData(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtEncryptedEmployees = clsEmployeeData.GetSetOfEmployees(PageNumber, RowsPerPage, ref ErrorMessage);
            DataTable dtDecryptedEmployees = new DataTable();
            dtDecryptedEmployees.Columns.Add("Employee ID", typeof(int));
            dtDecryptedEmployees.Columns.Add("Person ID", typeof(int));
            dtDecryptedEmployees.Columns.Add("Full Name", typeof(string));
            dtDecryptedEmployees.Columns.Add("Hire Date", typeof(string));
            dtDecryptedEmployees.Columns.Add("End Date", typeof(string));
            dtDecryptedEmployees.Columns.Add("Type Of Leaving", typeof(string));
            dtDecryptedEmployees.Columns.Add("Reason Of Leaving", typeof(string));
            foreach (DataRow row in dtEncryptedEmployees.Rows)
            {
                dtDecryptedEmployees.Rows.Add(
                    (int)row["ID"],
                    (int)row["PersonID"],
                        string.Join(" ", ((string)row["Full Name"]).Split(' ').
                        Select(s => clsEncryptionDecryption.Decrypt(s))),
                    row["HireDate"].ToString(),
                    row["EndDate"] == System.DBNull.Value ? "" : row["EndDate"].ToString(),
                    row["Type Of Leaving"] == System.DBNull.Value ? "" : (string)row["Type Of Leaving"],
                    row["ReasonOfLeaving"] == System.DBNull.Value ? "" : (string)row["ReasonOfLeaving"]
                );
            }
            return dtDecryptedEmployees;
        }
        public static int GetTotalEmployeesNumber(ref string ErrorMessage)
        {
            return clsEmployeeData.GetTotalEmployeesNumber(ref ErrorMessage);
        }
        ~clsEmployee() { }
    }
}

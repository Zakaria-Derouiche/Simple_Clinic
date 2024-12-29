using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ClinicBusiness;

namespace ClinicBusiness
{
    public class clsUser : clsEmployee
    {
        private enum enMode { Add, Edit }
        private enMode _Mode;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }
        public clsUser() : base()
        {
            UserID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            Permission = string.Empty;
        }
        private clsUser(int ID, string NationalNumber, string FirstName, string MidlleName, string LastName, DateTime BirthDate,
            bool Gender, string Phone, string Email, string Address, byte CountryID, int EmployeeID, string ImagePath,
            DateTime HireDtae, DateTime EndDate, bool TypeOfLeaving, string ReasonOfLeaving, int UserID,
            string UserName, string Password, string Permission) :
            base(ID, NationalNumber, FirstName, MidlleName, LastName, BirthDate, Gender, Phone, Email, Address, CountryID,
                EmployeeID, ImagePath, HireDtae, EndDate, TypeOfLeaving, ReasonOfLeaving)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;
        }

        private clsUser(clsEmployee Employee, int UserID, string UserName, string Password, string Permission) 
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
            TypeOfLeaving = Employee.TypeOfLeaving;
            ReasonOfLeaving = Employee.ReasonOfLeaving;
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;
        }

        public static clsUser GetUserInfoByID(int UserID, ref string ErrorMessage)
        {
            int employeeID = -1;
            string userName= string.Empty;
            string password = string.Empty;
            string permission = string.Empty;
            if (clsUserData.GetUserInfoByID(UserID, ref employeeID, ref userName, ref password, ref permission, ref ErrorMessage))
            {
                clsEmployee employee = clsEmployee.GetEmployeeInfoByID(employeeID, ref ErrorMessage);

                clsUser User = new clsUser(employee, UserID, userName, password, permission);
              
                return User;
            }
            else
            {
                return null;
            }
        }

        public static clsUser GetUserInfoByEmployeeID(int EmployeeID, ref string ErrorMessage)
        {
            int userID = -1;
            string userName = string.Empty;
            string password = string.Empty;
            string permission = string.Empty;
            if (clsUserData.GetUserInfoByEmployeeID(EmployeeID, ref userID, ref userName, ref password, ref permission, ref ErrorMessage))
            {
                clsEmployee employee = clsEmployee.GetEmployeeInfoByID(EmployeeID, ref ErrorMessage);

                clsUser User = new clsUser(employee, userID, userName, password, permission);

                return User;
            }
            else
            {
                return null;
            }
        }

        public static clsUser GetUserInfoByUserName(string userName, ref string ErrorMessage)
        {
            int iD = -1;
            int employeeID = -1;
            string password = string.Empty;
            string permission = string.Empty;
            if (clsUserData.GetUserInfoByUserName(userName, ref iD, ref employeeID, ref password, ref permission, ref ErrorMessage))
            {
                clsUser User = (clsUser)clsUser.GetEmployeeInfoByID(employeeID, ref ErrorMessage);
                User.UserID = iD;
                User.UserName = userName;
                User.Password = password;
                User.Permission = permission;
                return User;
            }
            else
            {
                return null;
            }
        }
        public override bool Save(int UserID, ref string ErrorMessage)
        {
            bool IsSaved = false;
            switch (_Mode)
            {
                case enMode.Add:
                    int NewID = -1;
                    IsSaved = clsUserData.AddNewUser(ref NewID, EmployeeID, UserName, Password, Permission, 1, ref ErrorMessage);
                    UserID = NewID;
                    _Mode = enMode.Edit;
                    break;
                case enMode.Edit:
                    IsSaved = clsUserData.UpdateUserInfo(UserID, EmployeeID, UserName, Password, Permission, 1, ref ErrorMessage);
                    break;
            }
            return IsSaved;
        }
        public static bool DeleteUser(int ID, int UserID, ref string ErrorMessage)
        {
            return clsUserData.DeleteUser(ID, UserID, ref ErrorMessage);
        }
        public static bool IsUserExistByID(int ID, ref string ErrorMessage)
        {
            return clsUserData.IsUserExistByID(ID, ref ErrorMessage);
        }
        public static bool IsUserExistByEmployeeID(int EmployeeID, ref string ErrorMessage)
        {
            return clsUserData.IsUserExistByEmployeeID(EmployeeID, ref ErrorMessage);
        }
        public static bool IsUserExistByUserName(string UserName, ref string ErrorMessage)
        {
            return clsUserData.IsUserExistByUserName(UserName, ref ErrorMessage);
        }
        public static DataTable GetSetOfUser(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtEncryptedUsers = clsUserData.GetSetOfUsers(PageNumber, RowsPerPage, ref ErrorMessage);
            DataTable dtDecryptedUsers = new DataTable();
            dtDecryptedUsers.Columns.Add("User ID", typeof(int));
            dtDecryptedUsers.Columns.Add("Employee ID", typeof(int));
            dtDecryptedUsers.Columns.Add("Full Name", typeof(string));
            dtDecryptedUsers.Columns.Add("User Name", typeof(string));
            dtDecryptedUsers.Columns.Add("Is Active", typeof(bool));

            foreach (DataRow row in dtEncryptedUsers.Rows)
            {
                dtDecryptedUsers.Rows.Add(
                    (int)row["ID"],
                    (int)row["EmployeeID"],
                        string.Join(" ", ((string)row["Full Name"]).Split(' ').
                        Select(s => clsEncryptionDecryption.Decrypt(s))),

                    (string)row["UserName"],
                    (DateTime)row["IsDeleted"]
                );
            }
            return dtDecryptedUsers;
        }
        public static int GetTotalUsersNumber(ref string ErrorMessage)
        {
            return clsUserData.GetTotalUsersNumber(ref ErrorMessage);
        }
        ~clsUser() { }
    }
}

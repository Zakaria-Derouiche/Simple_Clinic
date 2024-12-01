using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public static  class clsUserData
    {
        public static bool IsUserExistByID(int ID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsUserExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);

                        SqlParameter IsFoundOutputParameter = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsFoundOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsFound = (bool)Command.Parameters["@IsFound"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return IsFound;
        }
        public static bool IsUserExistByEmployeeID(int EmployeeID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsUserExistByEmployeeID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                        SqlParameter IsFoundOutputParameter = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsFoundOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsFound = (bool)Command.Parameters["@IsFound"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return IsFound;
        }
        public static bool IsUserExistByUserName(string UserName, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsUserExistByUserName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@UserName", UserName);

                        SqlParameter IsFoundOutputParameter = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsFoundOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsFound = (bool)Command.Parameters["@IsFound"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return IsFound;
        }
        public static bool GetUserInfoByID(int ID, ref int EmployeeID, ref string UserName, ref string Password,
            ref string Permission, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetUserInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        SqlParameter EmployeeIDOutputParameter = new SqlParameter("@EmployeeID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(EmployeeIDOutputParameter);
                        SqlParameter UserNameOutputParameter = new SqlParameter("@UserName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(UserNameOutputParameter);
                        SqlParameter PasswordOutputParameter = new SqlParameter("@Password", SqlDbType.NVarChar, 200)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(PasswordOutputParameter);
                        SqlParameter PermissionOutputParameter = new SqlParameter("@Permission", SqlDbType.NVarChar, 1000)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(PermissionOutputParameter);
                        SqlParameter IsFoundOutputParameter = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsFoundOutputParameter);
                        
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsFound = (bool)Command.Parameters["@IsFound"].Value;
                        if (IsFound)
                        {
                            EmployeeID = (int)Command.Parameters["@PersonID"].Value;
                            UserName = (string)Command.Parameters["@UserName"].Value;
                            Password = (string)Command.Parameters["@Password"].Value;
                            Permission = (string)Command.Parameters["@Permission"].Value;
                        }
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return IsFound;
        }
        public static bool GetUserInfoByUserName(string UserName, ref int ID, ref int EmployeeID, ref string Password,
           ref string Permission, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetUserInfoByUserName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@UserName", UserName);
                        SqlParameter EmployeeIDOutputParameter = new SqlParameter("@EmployeeID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(EmployeeIDOutputParameter);
                        SqlParameter IDOutputParameter = new SqlParameter("@ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IDOutputParameter);
                        SqlParameter PasswordOutputParameter = new SqlParameter("@Password", SqlDbType.NVarChar, 200)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(PasswordOutputParameter);
                        SqlParameter PermissionOutputParameter = new SqlParameter("@Permission", SqlDbType.NVarChar, 1000)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(PermissionOutputParameter);
                        SqlParameter IsFoundOutputParameter = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsFoundOutputParameter);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsFound = (bool)Command.Parameters["@IsFound"].Value;
                        if (IsFound)
                        {
                            ID = (int)Command.Parameters["@ID"].Value;
                            EmployeeID = (int)Command.Parameters["@PersonID"].Value;
                            Password = (string)Command.Parameters["@Password"].Value;
                            Permission = (string)Command.Parameters["@Permission"].Value;
                        }
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return IsFound;
        }
        public static bool AddNewUser(ref int ID, int EmployeeID, string UserName, string Password, string Permission,
            int CreationByUserID, ref string ErrorMessage)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        Command.Parameters.AddWithValue("@UserIName", UserName);
                        Command.Parameters.AddWithValue("@Password", Password);
                        Command.Parameters.AddWithValue("@Permission", Permission);
                        Command.Parameters.AddWithValue("@OperationUserID", CreationByUserID);
                        SqlParameter IDOutputParameter = new SqlParameter("@NewID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IDOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        ID = (int)IDOutputParameter.Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return ID != -1;
        }

        public static bool UpdateUserInfo(int ID, int EmployeeID, string UserName, string Password, string Permission,
            int UpdateUserID, ref string ErrorMessage)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdateUserInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        Command.Parameters.AddWithValue("@UserIName", UserName);
                        Command.Parameters.AddWithValue("@Password", Password);
                        Command.Parameters.AddWithValue("@Permission", Permission);
                        Command.Parameters.AddWithValue("@OperationUserID", UpdateUserID);
                        SqlParameter IsUpdatedParameter = new SqlParameter("@IsUpdated", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsUpdatedParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsUpdated = (bool)Command.Parameters["@IsUpdated"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return IsUpdated;
        }
        public static bool DeleteUser(int ID, int OperationUserID, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeletedUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@OpeartionUserID", OperationUserID);
                        SqlParameter IsDeletedOutputParameter = new SqlParameter("@IsDeleted", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsDeletedOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsDeleted = (bool)Command.Parameters["@IsDeleted"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return IsDeleted;
        }     
        public static DataTable GetSetOfUsers(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtUsers  = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetSetOfUsers", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtUsers.Load(Reader);
                            Reader.Close();
                        }
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return dtUsers;
        }
        public static int GetTotalUsersNumber(ref string ErrorMessage)
        {
            int TotalUsersNumber = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_TotalUsersNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        SqlParameter TotalUsersOutputParameter = new SqlParameter("@TotalUsersNumber", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TotalUsersOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        TotalUsersNumber = (int)Command.Parameters["@TotalPatientsNumber"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return TotalUsersNumber;
        }
    }
}

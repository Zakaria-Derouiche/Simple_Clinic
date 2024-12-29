using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public static class clsEmployeeData
    {
        public static bool IsEmployeeExistByID(int ID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsEmployeeExistByID", Connection))
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
        public static bool IsEmployeeExistByPersonID(int PersonID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsEmployeeExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static bool IsEmployeeExistByPersonNationalNumber(string NationalNumber, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsEmployeeExistByNationalNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@EmployeeNationalNumber",  NationalNumber);
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
        public static bool GetEmployeeInfo(int ID, ref int PersonID, ref string ImagePath, ref DateTime HireDate,
            ref Nullable<DateTime> EndDate, ref Nullable<bool> TypeOfLeaving, ref string ReasonOfLeaving,ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetEmployeeInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        SqlParameter PersonIDOutputParameter = new SqlParameter("@PersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(PersonIDOutputParameter);
                        SqlParameter ImagePathOutputParameter = new SqlParameter("@ImagePath", SqlDbType.NVarChar, 250)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(ImagePathOutputParameter);
                        SqlParameter HireDateOutputParameter = new SqlParameter("@HireDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(HireDateOutputParameter);
                        SqlParameter EndDateOutputParameter = new SqlParameter("@EndDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(EndDateOutputParameter);
                        SqlParameter TypeOfLeavingOutputParameter = new SqlParameter("@TypeOfLeaving", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TypeOfLeavingOutputParameter);
                        SqlParameter ReasonOfLeavingOutputParameter = new SqlParameter("@ReasonOfLeaving", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(ReasonOfLeavingOutputParameter);
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
                            PersonID = (int)Command.Parameters["@PersonID"].Value;
                            ImagePath = (string)Command.Parameters["@ImagePath"].Value;
                            HireDate = (DateTime)Command.Parameters["@HireDate"].Value;
                            if (Command.Parameters["@EndDate"].Value == System.DBNull.Value)
                                EndDate = (null);
                            else
                                EndDate = (Nullable<DateTime>)Command.Parameters["@EndDate"].Value;
                            if (Command.Parameters["@TypeOfLeaving"].Value == System.DBNull.Value)
                                TypeOfLeaving = null;
                            else
                                TypeOfLeaving = (Nullable<bool>)Command.Parameters["@TypeOfLeaving"].Value;
                            if (Command.Parameters["@ReasonOfLeaving"].Value == System.DBNull.Value)
                                ReasonOfLeaving = string.Empty;
                            else
                                ReasonOfLeaving = (string)Command.Parameters["@ReasonOfLeaving"].Value;
                        }
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.StackTrace;
            }
            return IsFound;
        }

        public static bool GetEmployeeInfoByPersonID(int PersonID, ref int ID, ref string ImagePath, ref DateTime HireDate,
           ref Nullable<DateTime> EndDate, ref Nullable<bool> TypeOfLeaving, ref string ReasonOfLeaving, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetEmployeeInfoByPersonID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        SqlParameter IDOutputParameter = new SqlParameter("@ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IDOutputParameter);
                        SqlParameter ImagePathOutputParameter = new SqlParameter("@ImagePath", SqlDbType.NVarChar, 250)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(ImagePathOutputParameter);
                        SqlParameter HireDateOutputParameter = new SqlParameter("@HireDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(HireDateOutputParameter);
                        SqlParameter EndDateOutputParameter = new SqlParameter("@EndDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(EndDateOutputParameter);
                        SqlParameter TypeOfLeavingOutputParameter = new SqlParameter("@TypeOfLeaving", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TypeOfLeavingOutputParameter);
                        SqlParameter ReasonOfLeavingOutputParameter = new SqlParameter("@ReasonOfLeaving", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(ReasonOfLeavingOutputParameter);
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
                            ImagePath = (string)Command.Parameters["@ImagePath"].Value;
                            HireDate = (DateTime)Command.Parameters["@HireDate"].Value;
                            if (Command.Parameters["@EndDate"].Value == System.DBNull.Value)
                                EndDate = null ;
                            else
                                EndDate = (DateTime)Command.Parameters["@EndDate"].Value;
                            if (Command.Parameters["@TypeOfLeaving"].Value == System.DBNull.Value)
                                TypeOfLeaving = null;
                            else
                                TypeOfLeaving = (bool)Command.Parameters["@TypeOfLeaving"].Value;
                            if (Command.Parameters["@ReasonOfLeaving"].Value == System.DBNull.Value)
                                ReasonOfLeaving = string.Empty;
                            else                         
                                ReasonOfLeaving = (string)Command.Parameters["@ReasonOfLeaving"].Value;
                        }
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.StackTrace;
            }
            return IsFound;
        }
        public static bool AddNewEmployee(ref int ID, int PersonID, string ImagePath, DateTime HireDate,
            int CreationByUserID, ref string ErrorMessage)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewEmployee", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        Command.Parameters.AddWithValue("@HireDate", HireDate);
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
        public static bool UpdateEmployeeInfo(int ID, int PersonID, string ImagePath, DateTime HireDate, Nullable<DateTime> EndDate,
            Nullable<bool> TypeOfLeaving, string ReasonOfLeaving,  int UpdateUserID, ref string ErrorMessage)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdateEmployeeInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        Command.Parameters.AddWithValue("@HireDate", HireDate);
                        Command.Parameters.AddWithValue("@EndDate", EndDate);
                        Command.Parameters.AddWithValue("@TypeOfLeaving", TypeOfLeaving);
                        Command.Parameters.AddWithValue("@ReasonOfLeaving", ReasonOfLeaving);
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
        public static bool DeleteEmployee(int ID, int OperationUserID, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeleteEmployee", Connection))
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
        public static DataTable GetSetOfEmployees(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtEmployees = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetSetOfEmployees", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtEmployees.Load(Reader);
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
            return dtEmployees;
        }
        public static int GetTotalEmployeesNumber(ref string ErrorMessage)
        {
            int TotalEmployeesNumber = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_TotalEmployeesNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        SqlParameter TotalEmployeesOutputParameter = new SqlParameter("@TotalEmployeesNumber", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TotalEmployeesOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        TotalEmployeesNumber = (int)Command.Parameters["@TotalEmployeesNumber"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return TotalEmployeesNumber;
        }
    }
}

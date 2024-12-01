using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public static class clsDoctorData
    {
        public static bool IsDoctorExistByID(int ID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsDoctorExistByID", Connection))
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
        public static bool IsDoctorExistByEmployeeID(int EmployeeID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsDoctorExistByEmployeeID", Connection))
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
        public static bool GetDoctorInfo(int ID, ref int EmployeeID, ref string Specialization,  ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetDoctorInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        SqlParameter EmployeeIDOutputParameter = new SqlParameter("@EmployeeID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(EmployeeIDOutputParameter);
                        SqlParameter SpecializationOutputParameter = new SqlParameter("@Specialization", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(SpecializationOutputParameter);
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
                            EmployeeID = (int)Command.Parameters["@EmployeeID"].Value;
                            Specialization = (string)Command.Parameters["@Specialization"].Value;
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
        public static bool AddNewDoctor(ref int ID, int EmployeeID, string Specialization,int CreationByUserID,
            ref string ErrorMessage)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewDoctor", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        Command.Parameters.AddWithValue("@Specialization", Specialization);
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
        public static bool UpdateDoctorInfo(int ID, int EmployeeID, string Specialization, int UpdateUserID,
            ref string ErrorMessage)
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
                        Command.Parameters.AddWithValue("@Specilaization", Specialization);
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
        public static bool DeleteDoctor(int ID, int OperationUserID, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeleteDoctor", Connection))
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

        public static DataTable GetSetOfDoctors(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtDoctors = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetSetOfDoctors", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtDoctors.Load(Reader);
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
            return dtDoctors;
        }
        public static int GetTotalDoctorsNumber(ref string ErrorMessage)
        {
            int TotalDoctorsNumber = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_TotalDoctorsNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        SqlParameter TotalDoctorsOutputParameter = new SqlParameter("@TotalDoctorsNumber", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TotalDoctorsOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        TotalDoctorsNumber = (int)Command.Parameters["@TotalDoctorsNumber"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return TotalDoctorsNumber;
        }
    }
}

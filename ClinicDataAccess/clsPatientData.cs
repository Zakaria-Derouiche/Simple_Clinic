using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Security.Policy;

namespace ClinicDataAccess
{
    public static class clsPatientData
    {
        public static bool IsPatientExistByPersonID(int PersonID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsPatientExistByPersonID", Connection))
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
        public static bool IsPatientExistByNationalNumber(string NationalNumber, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsPatientExistByNationalNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonNationalNumber", NationalNumber);
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
        public static bool AddNewPatient(ref int  ID, int PersonID, int CreatedByUserID, ref string ErrorMessage)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewPatient", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@OperationUserID", CreatedByUserID);
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
        public static bool UpdatePatientInfo(int ID, int PersonID, int UserID, ref string ErrorMessage)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdatePatientInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        Command.Parameters.AddWithValue("@OperationUserID", UserID);  
                        SqlParameter IsFoundOutputParameter = new SqlParameter("@IsUpdated", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsFoundOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsUpdated = (bool)IsFoundOutputParameter.Value;
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
        public static bool DeletePatient(int ID, int UserID, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeletePatient", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@OperationUserID", UserID);
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
        public static bool GetPatientInfo(int PatientID, ref int PersonID,  ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPatientInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                        SqlParameter PersonIDOutputParameter = new SqlParameter("@PersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(PersonIDOutputParameter);
                        SqlParameter IsFoundOutputParameter = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsFoundOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsFound = (bool)Command.Parameters["@IsFound"].Value;
                        if(IsFound)
                        {
                            PersonID = (int)Command.Parameters["@PersonID"].Value;
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
        public static bool GetPatientInfoByPersonID(int PersonID, ref int PatientID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPatientInfoByPersonID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID);
                        SqlParameter PatientIDOutputParameter = new SqlParameter("@PatientID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(PatientIDOutputParameter);
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
                            PatientID = (int)Command.Parameters["@PatientID"].Value;
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
        public static DataTable GetPatientsPerPage(int PageNumber,int NumberOfPatiensPerPage, ref string ErrorMessage)
        {
            DataTable dtPatients = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetSetOfPatients", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", NumberOfPatiensPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtPatients.Load(Reader);
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
            return dtPatients;
        }
        public static int GetPatientsTotalNumber(ref string ErrorMessage)
        {
            int TotalPatientsNumber = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_TotalPatientsNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        SqlParameter TotalPatientsOutputParameter = new SqlParameter("@TotalPatientsNumber", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TotalPatientsOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        TotalPatientsNumber = (int)Command.Parameters["@TotalPatientsNumber"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return TotalPatientsNumber;
        }

    }
}

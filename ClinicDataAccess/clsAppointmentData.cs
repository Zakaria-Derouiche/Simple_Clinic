using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace ClinicDataAccess
{
    public static class clsAppointmentData
    {
        public static bool IsAppointmentExist(int AppointmentID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsAppointmentExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", AppointmentID);

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
        public static bool GetAppointmentInfoByID(int ID, ref int PatientID, ref int DoctorID, ref DateTime AppointmentDate,
            ref string AppointmentStatus,  ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAppointmentInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AppointmentID", ID);
                        SqlParameter PatientIDOutPutParameter = new SqlParameter("@PatientID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PatientIDOutPutParameter);

                        SqlParameter DoctorIDOutPutParameter = new SqlParameter("@DoctorID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(DoctorIDOutPutParameter);

                        SqlParameter AppointmentDateOutPutParameter = new SqlParameter("@AppointmentDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(AppointmentDateOutPutParameter);
                        
                       
                        SqlParameter AppointmentStatusOutPutParameter = new SqlParameter("@AppointmentStatus", SqlDbType.NVarChar, 20)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(AppointmentStatusOutPutParameter);

                       
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
                            DoctorID = (int)Command.Parameters["@DoctorID"].Value;
                            AppointmentDate = (DateTime)Command.Parameters["@AppointmentDate"].Value;
                            AppointmentStatus = (string)Command.Parameters["@AppointmentStatus"].Value;
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
       
        public static bool AddNewAppointment(ref int ID, int PatientID, int DoctorID, DateTime AppointmentDate,
            string AppointmentStatus, int UserID, ref string ErrorMessage)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewAppointment", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                      
                      
                        Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        
                        Command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                        Command.Parameters.AddWithValue("@OperationUserID", UserID);
                        SqlParameter IDOutputParameter = new SqlParameter("@NewAppointmentID", SqlDbType.Int)
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
        public static bool UpdateAppointmentInfo (int ID, int PatientID, int DoctorID, DateTime AppointmentDate,
            string AppointmentStatus, int UserID, ref string ErrorMessage)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdateAppointmentInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AppointmentID", ID);
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PatientID", PatientID);
                        Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        Command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                        Command.Parameters.AddWithValue("@OperationUserID", UserID);

                        SqlParameter IsUpdatedOutputParameter = new SqlParameter("@IsUpdated", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsUpdatedOutputParameter);                     
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsUpdated = (bool) IsUpdatedOutputParameter.Value;
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
        public static bool DeleteAppointment(int ID, int OperationUserID, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeleteAppointment", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AppointmentID", ID);
                        Command.Parameters.AddWithValue("@OperationUserID", OperationUserID);
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
        public static DataTable GetSetOfAppointmentPerPage(int PageNumber, int NumberOfPatiensPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetSetOfAppointments", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", NumberOfPatiensPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtAppointments.Load(Reader);
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
            return dtAppointments;
        }

        public static DataTable GetPersonAppointments(string NationalNumber, int PageNumber, int NumberOfPatiensPerPage,
            ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonAppointments", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", NumberOfPatiensPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtAppointments.Load(Reader);
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
            return dtAppointments;
        }

        public static DataTable GetPersonAppointmentsByName(string FullName, int PageNumber, int NumberOfPatiensPerPage,
           ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPatientAppointmentsByName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PatientName", FullName);
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", NumberOfPatiensPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtAppointments.Load(Reader);
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
            return dtAppointments;
        }
        public static DataTable GetDoctorAppointments(string DoctorName, int PageNumber, int NumberOfPatiensPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetDoctorAppointmentsByName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@DoctorName", DoctorName);
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", NumberOfPatiensPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtAppointments.Load(Reader);
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
            return dtAppointments;
        }
        public static DataTable GetDoctorAppointmentsByNationalNumber(string DoctorNationalNo, int PageNumber, int NumberOfPatiensPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetDoctorAppointmentsByNationalNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@DoctorNationalNumber", DoctorNationalNo);
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", NumberOfPatiensPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtAppointments.Load(Reader);
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
            return dtAppointments;
        }
        public static DataTable GetAppointmentsByDate(string Date, int PageNumber, int NumberOfPatiensPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAppointmentsByDate", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", NumberOfPatiensPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtAppointments.Load(Reader);
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
            return dtAppointments;
        }
        public static int GetAppointmentsTotalNumber(ref string ErrorMessage)
        {
            int TotalPeopleNumber = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_TotalAppointmentsNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        SqlParameter TotalAppointmentsOutputParameter = new SqlParameter("@TotalAppointmentsNumber", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TotalAppointmentsOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        TotalPeopleNumber = (int)Command.Parameters["@TotalAppointmentsNumber"].Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return TotalPeopleNumber;
        }
    }
}

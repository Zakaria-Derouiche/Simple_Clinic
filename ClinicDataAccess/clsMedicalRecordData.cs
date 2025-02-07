using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public static class clsMedicalRecordData
    {
        public static bool IsMedicalRecordExist(int MedicalRecordID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsAppointmentExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", MedicalRecordID);

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

        public static bool IsMedicalRecordExistByAppointmentID(int AppointmentID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsAppointmentExistByAppointmentID", Connection))
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

        public static bool GetMedicalRecordInfoByID(int ID, ref int AppointmentID, ref string Description,
            ref string Diagnosis, ref string Notes, ref DateTime CreationDate, ref int CreatedByUserID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetMedicalRecordInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        SqlParameter AppointmentIDOutPutParameter = new SqlParameter("@AppointmentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(AppointmentIDOutPutParameter);           

                        SqlParameter DescriptionOutPutParameter = new SqlParameter("@Description", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(DescriptionOutPutParameter);

                        SqlParameter DiagnosisOutPutParameter = new SqlParameter("@Diagnosis", SqlDbType.NVarChar, 250)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(DiagnosisOutPutParameter);

                        SqlParameter NotesOutPutParameter = new SqlParameter("@Notes", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(NotesOutPutParameter);
                        SqlParameter CreationDateOutPutParameter = new SqlParameter("@CreationDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(CreationDateOutPutParameter);

                        SqlParameter CreatedByUserIDOutPutParameter = new SqlParameter("@CreatedByUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(CreatedByUserIDOutPutParameter);

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
                            AppointmentID = (int)Command.Parameters["@AppointmentID"].Value;
                            Description = (string)Command.Parameters["@Description"].Value;
                            Diagnosis = (string)Command.Parameters["@Diagnosis"].Value;
                            Notes = (string)Command.Parameters["@Notes"].Value;
                            CreationDate = (DateTime)Command.Parameters["@CreationDate"].Value;
                            CreatedByUserID = (int)Command.Parameters["@CreatedByUserID"].Value;
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

        public static bool GetMedicalRecordInfoByAppointmentID(int AppointmentID, ref int ID, ref string Description,
            ref string Diagnosis, ref string Notes, ref DateTime CreationDate, ref int CreatedByUserID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetMedicalRecordInfoByAppointmentID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        SqlParameter IDOutPutParameter = new SqlParameter("@ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(IDOutPutParameter);

                        SqlParameter DescriptionOutPutParameter = new SqlParameter("@Description", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(DescriptionOutPutParameter);

                        SqlParameter DiagnosisOutPutParameter = new SqlParameter("@Diagnosis", SqlDbType.NVarChar, 250)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(DiagnosisOutPutParameter);

                        SqlParameter NotesOutPutParameter = new SqlParameter("@Notes", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(NotesOutPutParameter);
                        SqlParameter CreationDateOutPutParameter = new SqlParameter("@CreationDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(CreationDateOutPutParameter);

                        SqlParameter CreatedByUserIDOutPutParameter = new SqlParameter("@CreatedByUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(CreatedByUserIDOutPutParameter);

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
                            Description = (string)Command.Parameters["@Description"].Value;
                            Diagnosis = (string)Command.Parameters["@Diagnosis"].Value;
                            Notes = (string)Command.Parameters["@Notes"].Value;
                            CreationDate = (DateTime)Command.Parameters["@CreationDate"].Value;
                            CreatedByUserID = (int)Command.Parameters["@CreatedByUserID"].Value;
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
           
        public static bool AddNewMedicalRecord(ref int ID, int AppointmentID, string Description,
            string Diagnosis, string Notes, int CreatedByUserID, ref string ErrorMessage)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewMedicalRecord", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        Command.Parameters.AddWithValue("@Description", Description);
                        Command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                        Command.Parameters.AddWithValue("@Notes", Notes);
                        Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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
                clsDataAccessSettings.AddEventLog(ex.Message);
            }
            return ID != -1;
        }
        public static bool UpdateMedicalRecordInfo(int ID, int AppointmentID, string Description,
            string Diagnosis, string Notes, int CreatedByUserID, ref string ErrorMessage)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdateMedicalRecordInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@PatientID", AppointmentID);
                        Command.Parameters.AddWithValue("@Description", Description);
                        Command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                        Command.Parameters.AddWithValue("@Notes", Notes);
                       
                        SqlParameter IsUpdatedOutputParameter = new SqlParameter("@IsUpdated", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(IsUpdatedOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsUpdated = (bool)IsUpdatedOutputParameter.Value;
                        Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                clsDataAccessSettings.AddEventLog(ex.Message);
            }
            return IsUpdated;
        }
        public static bool DeleteMedicalRecord(int ID, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeleteMedicalRecord", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MedicalRecordID", ID);

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
        public static DataTable GetSetOfMedicalRecords(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetSetOfMedicalRecords", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
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

        public static DataTable GetPersonMedicalRecords(string NationalNumber, int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetMedicalRecordsByPersonNationalNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
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
        public static DataTable GetPersonMedicalRecordsByName(string FullName, int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetMedicalRecordsByPersonName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@FullName", FullName);
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
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
        public static DataTable GetPersonMedicalRecordsByDate(string Date, int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetMedicalRecordsByDate", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);
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
        public static int GetMedicalRecordsTotalNumber(ref string ErrorMessage)
        {
            int TotalPeopleNumber = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_TotalMedicalRecordsNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        SqlParameter TotalPatientsOutputParameter = new SqlParameter("@TotalMedicalRecordsNumber", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TotalPatientsOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        TotalPeopleNumber = (int)Command.Parameters["@TotalMedicalRecordsNumber"].Value;
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

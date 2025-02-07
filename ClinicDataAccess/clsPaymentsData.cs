using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public static class clsPaymentsData
    {
       
        public static bool GetPaymentInfoByID(int ID, ref int AppointmentID, ref DateTime PaymentDateTime, 
            ref string PaymentMethod,
            ref Decimal PaidAmount, ref string Notes, ref int ScheduledByUserID , ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPaymentInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        SqlParameter AppointmentIDOutPutParameter = new SqlParameter("@AppointmentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(AppointmentIDOutPutParameter);

                        SqlParameter PaymentDateTimeOutPutParameter = new SqlParameter("@PaymentDateTime", SqlDbType.DateTime)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PaymentDateTimeOutPutParameter);

                        SqlParameter PaymentMethodOutPutParameter = new SqlParameter("@PaymentMethod", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PaymentMethodOutPutParameter);


                        SqlParameter PaidAmountOutPutParameter = new SqlParameter("@PaidAmount", SqlDbType.Decimal, 2)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PaidAmountOutPutParameter);

                        SqlParameter NotesOutPutParameter = new SqlParameter("@Notes", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(NotesOutPutParameter);

                        SqlParameter ScheduledByUserIDOutPutParameter = new SqlParameter("@ScheduledByUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(ScheduledByUserIDOutPutParameter);

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
                            PaymentDateTime = (DateTime)Command.Parameters["@PaymentDateTime"].Value;
                            PaymentMethod = (string)Command.Parameters["@PaymentMethod"].Value;
                            PaidAmount = (Decimal)Command.Parameters["@PaidAmount"].Value;
                            Notes = (string)Command.Parameters["@Notes"].Value;
                            ScheduledByUserID = (int)Command.Parameters["@ScheduledByUserID"].Value;
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

        public static bool GetPaymentInfoByAppointmentID(int AppointmentID, ref int ID, ref DateTime PaymentDateTime, ref string PaymentMethod,
            ref Decimal PaidAmount, ref string Notes, ref int ScheduledByUserID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPaymentInfoByAppointmentID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        SqlParameter IDOutPutParameter = new SqlParameter("@ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(IDOutPutParameter);

                        SqlParameter PaymentDateTimeOutPutParameter = new SqlParameter("@PaymentDateTime", SqlDbType.DateTime)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PaymentDateTimeOutPutParameter);

                        SqlParameter PaymentMethodOutPutParameter = new SqlParameter("@PaymentMethod", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PaymentMethodOutPutParameter);


                        SqlParameter PaidAmountOutPutParameter = new SqlParameter("@PaidAmount", SqlDbType.Decimal, 2)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PaidAmountOutPutParameter);

                        SqlParameter NotesOutPutParameter = new SqlParameter("@Notes", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(NotesOutPutParameter);

                        SqlParameter ScheduledByUserIDOutPutParameter = new SqlParameter("@ScheduledByUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(ScheduledByUserIDOutPutParameter);

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
                            PaymentDateTime = (DateTime)Command.Parameters["@PaymentDateTime"].Value;
                            PaymentMethod = (string)Command.Parameters["@PaymentMethod"].Value;
                            PaidAmount = (Decimal)Command.Parameters["@PaidAmount"].Value;
                            Notes = (string)Command.Parameters["@Notes"].Value;
                            ScheduledByUserID = (int)Command.Parameters["@ScheduledByUserID"].Value;
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

        public static bool AddNewPayment(ref int ID, int AppointmentID, string PaymentMethod, Decimal PaidAmount, string Notes,
            int ScheduledByUserID, ref string ErrorMessage)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewPayment", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        Command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        Command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
                        Command.Parameters.AddWithValue("@Notes", Notes);
                        Command.Parameters.AddWithValue("@ScheduledByUserID", ScheduledByUserID);
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
            return ID > 0;
        }
        public static bool UpdatePaymentInfo(int ID, int AppointmentID, string PaymentMethod, Decimal PaidAmount, 
            string Notes, int ScheduledByUserID, ref string ErrorMessage)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdatePaymentInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@PatientID", AppointmentID);
                        Command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        Command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
                        Command.Parameters.AddWithValue("@Notes", Notes);
                        Command.Parameters.AddWithValue("@ScheduledByUserID", ScheduledByUserID);
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
                ErrorMessage = ex.Message;
            }
            return IsUpdated;
        }
        public static bool DeletePayment(int ID, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeletePayment", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PaymentID", ID);

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
        public static DataTable GetSetOfPayments(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetAllPayments", Connection))
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

        public static DataTable GetPersonPayments(string NationalNumber, int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonPayments", Connection))
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

        public static DataTable GetPersonPaymentsByName(string FullName, int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonPaymentsByName", Connection))
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
        public static DataTable GetPersonPaymentsByDate(string Date, int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonPaymentsByDate", Connection))
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
        public static int GetPaymentsTotalNumber(ref string ErrorMessage)
        {
            int TotalPeopleNumber = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_TotalPaymentsNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        SqlParameter TotalPatientsOutputParameter = new SqlParameter("@TotalPaymentsNumber", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TotalPatientsOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        TotalPeopleNumber = (int)Command.Parameters["@TotalPaymentsNumber"].Value;
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

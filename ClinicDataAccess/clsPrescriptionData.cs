using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace ClinicDataAccess
{
    public static class clsPrescriptionData
    {
        public static bool IsPrescriptionExistByID(int PrescriptionID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsPrescriptionExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", PrescriptionID);

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
        public static bool IsPrescriptionExistByMedicalRecordID(int MedicalRecordID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsPrescriptionExitByMedicalRecordID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

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

        public static bool GetPrescriptionByID(int ID, ref int MedicalRecordID, ref string MedicationName, ref string Dosage,
            ref string Frequency, ref DateTime StartDate, ref DateTime EndDate, ref string SpecialInstructions, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPrescriptionInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);

                        SqlParameter MedicalRecordIDOutPutParameter = new SqlParameter("@MedicalRecordID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(MedicalRecordIDOutPutParameter);

                        SqlParameter MedicationNameOutPutParameter = new SqlParameter("@Description", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(MedicationNameOutPutParameter);

                        SqlParameter DosageOutPutParameter = new SqlParameter("@Dosage", SqlDbType.NVarChar, 20)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(DosageOutPutParameter);

                        SqlParameter FrequencyOutPutParameter = new SqlParameter("@Frequency", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(FrequencyOutPutParameter);

                        SqlParameter StartDateOutPutParameter = new SqlParameter("@StartDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(StartDateOutPutParameter);

                        SqlParameter EndDateOutPutParameter = new SqlParameter("@EndDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(EndDateOutPutParameter);

                        SqlParameter SpecialInstructionsOutPutParameter = new SqlParameter("@SpecialInstructions", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(SpecialInstructionsOutPutParameter);

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
                            MedicalRecordID = (int)Command.Parameters["@MedicalRecordID"].Value;
                            MedicationName = (string)Command.Parameters["@MedicationName"].Value;
                            Dosage = (string)Command.Parameters["@Dosage"].Value;
                            Frequency = (string)Command.Parameters["@Frequency"].Value;
                            StartDate = (DateTime)Command.Parameters["@StartDate"].Value;
                            EndDate = (DateTime)Command.Parameters["@EndDate"].Value;
                            SpecialInstructions = (string)Command.Parameters["@SpecialInstructions"].Value;
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

        public static bool AddNewPrescription(ref int ID, int MedicalRecordID, string MedicationName, string Dosage, string Frequency,
            DateTime StartDate, DateTime EndDate, string SpecialInstructions, ref string ErrorMessage)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewPrescription", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                        Command.Parameters.AddWithValue("@MedicationName", MedicationName);
                        Command.Parameters.AddWithValue("@Dosage", Dosage);
                        Command.Parameters.AddWithValue("@Frequency", Frequency);
                        Command.Parameters.AddWithValue("@StartDate", StartDate);
                        Command.Parameters.AddWithValue("@EndDate", EndDate);
                        Command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);

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
        public static bool UpdatePrescriptionInfo(int ID, int MedicalRecordID, string MedicationName, string Dosage,
            string Frequency, DateTime StartDate, DateTime EndDate, string SpecialInstructions, ref string ErrorMessage)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdatePrescriptionInfo", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@MediaclRecordID", MedicalRecordID);
                        Command.Parameters.AddWithValue("@MedicationName", MedicationName);
                        Command.Parameters.AddWithValue("@Dosage", Dosage);
                        Command.Parameters.AddWithValue("@Frequency", Frequency);
                        Command.Parameters.AddWithValue("@StartDate", StartDate);
                        Command.Parameters.AddWithValue("@EndDate", EndDate);
                        Command.Parameters.AddWithValue("@SpecialInstruction", SpecialInstructions);

                        SqlParameter IsUpdatedOutputParameter = new SqlParameter("@IsUpdated", SqlDbType.Bit)
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
        public static bool DeletePerscription(int ID, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeletePrescription", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PrescriptionID", ID);

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

        public static DataTable GetPrescriptionsByMedicalRecordID(int MedicalRecordID, ref string ErrorMessage)
        {
            DataTable dtPrescriptions = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPrescriptionsByMedicalRecordID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtPrescriptions.Load(Reader);
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
            return dtPrescriptions;
        }

    }

}

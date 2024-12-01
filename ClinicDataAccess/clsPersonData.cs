using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public static class clsPersonData
    {
        public static bool IsPersonExist(int PersonID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsPersonExistByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", PersonID);

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
        public static bool IsPersonExist(string NationalNumber, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsPersonExistByNationalNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
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
        public static bool IsPersonExistByFullName(string FullName, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_IsPersonExistByName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@FullName", FullName);
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
        public static bool GetPersonInfoByID(int ID, ref string NationalNumber, ref string FirstName, ref string MidleName,
            ref string LastName, ref DateTime BirthDate, ref bool Gender, ref string Phone, ref string Email, ref string Address,
            ref byte CountryID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        SqlParameter NationalNumberOutPutParameter = new SqlParameter("@NationalNumber", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(NationalNumberOutPutParameter);
                        SqlParameter FirstNameOutPutParameter = new SqlParameter("@FirstName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(FirstNameOutPutParameter);
                        SqlParameter MidleNameOutPutParameter = new SqlParameter("@MidleName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(MidleNameOutPutParameter);
                        SqlParameter LastNameOutPutParameter = new SqlParameter("@LastName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(LastNameOutPutParameter);
                        SqlParameter BirthDateOutPutParameter = new SqlParameter("@BirthDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(BirthDateOutPutParameter);
                        SqlParameter GenderOutPutParameter = new SqlParameter("@Gender", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(GenderOutPutParameter);
                        SqlParameter PhoneOutPutParameter = new SqlParameter("@Phone", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PhoneOutPutParameter);
                        SqlParameter EmailOutPutParameter = new SqlParameter("@Email", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(EmailOutPutParameter);
                        SqlParameter AddressOutPutParameter = new SqlParameter("@Address", SqlDbType.NVarChar, 250)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(AddressOutPutParameter);
                        SqlParameter CountryIDOutPutParameter = new SqlParameter("@CountryID", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(CountryIDOutPutParameter);
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
                            NationalNumber = (string)Command.Parameters["@NationalNumber"].Value;
                            FirstName = (string)Command.Parameters["@FirstName"].Value;
                            MidleName = Command.Parameters["@MidleName"].Value == DBNull.Value ? "" :
                                        (string)Command.Parameters["@MidleName"].Value;
                            LastName = (string)Command.Parameters["@LastName"].Value;
                            BirthDate = (DateTime)Command.Parameters["@BirthDate"].Value;
                            Gender = (bool)Command.Parameters["@Gender"].Value;
                            Email = (string)Command.Parameters["@Email"].Value;
                            Phone = (string)Command.Parameters["@Phone"].Value;
                            Address = (string)Command.Parameters["@Address"].Value;
                            CountryID = (byte)Command.Parameters["@CountryID"].Value;
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
        public static bool GetPersonInfoByNationalNumber(string NationalNumber, ref int ID, ref string FirstName,
            ref string MidleName, ref string LastName, ref DateTime BirthDate, ref bool Gender, ref string Phone, ref string Email,
            ref string Address, ref byte CountryID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonInfoByNationalNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                        SqlParameter IDOutPutParameter = new SqlParameter("@ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(IDOutPutParameter);
                        SqlParameter FirstNameOutPutParameter = new SqlParameter("@FirstName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(FirstNameOutPutParameter);
                        SqlParameter MidleNameOutPutParameter = new SqlParameter("@MidleName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(MidleNameOutPutParameter);
                        SqlParameter LastNameOutPutParameter = new SqlParameter("@LastName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(LastNameOutPutParameter);
                        SqlParameter BirthDateOutPutParameter = new SqlParameter("@BirthDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(BirthDateOutPutParameter);
                        SqlParameter GenderOutPutParameter = new SqlParameter("@Gender", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(GenderOutPutParameter);
                        SqlParameter PhoneOutPutParameter = new SqlParameter("@Phone", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PhoneOutPutParameter);
                        SqlParameter EmailOutPutParameter = new SqlParameter("@Email", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(EmailOutPutParameter);
                        SqlParameter AddressOutPutParameter = new SqlParameter("@Address", SqlDbType.NVarChar, 250)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(AddressOutPutParameter);
                        SqlParameter CountryIDOutPutParameter = new SqlParameter("@CountryID", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(CountryIDOutPutParameter);
                        SqlParameter IsFoundOutputParameter = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(IsFoundOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsFound = (bool)Command.Parameters["@IsFound"].Value;
                        if (IsFound)
                        {
                            ID = (int)Command.Parameters["@ID"].Value;
                            FirstName = (string)Command.Parameters["@FirstName"].Value;
                            MidleName = Command.Parameters["@MidleName"].Value == DBNull.Value ? "" :
                                        (string)Command.Parameters["@MidleName"].Value;
                            LastName = (string)Command.Parameters["@LastName"].Value;
                            BirthDate = (DateTime)Command.Parameters["@BirthDate"].Value;
                            Gender = (bool)Command.Parameters["@Gender"].Value;
                            Email = (string)Command.Parameters["@Email"].Value;
                            Phone = (string)Command.Parameters["@Phone"].Value;
                            Address = (string)Command.Parameters["@Address"].Value;
                            CountryID = (byte)Command.Parameters["@CountryID"].Value;
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
        public static bool GetPersonInfoByFullName(string FullName, ref int ID, ref string NationalNumber, ref string FirstName,
            ref string MidleName, ref string LastName, ref DateTime BirthDate, ref bool Gender, ref string Phone, ref string Email,
            ref string Address, ref byte CountryID, ref string ErrorMessage)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetPersonInfoByName", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@FullName", FullName);
                        SqlParameter IDOutPutParameter = new SqlParameter("@ID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(IDOutPutParameter);
                        SqlParameter NationalNumberOutPutParameter = new SqlParameter("@NationalNumber", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(NationalNumberOutPutParameter);
                        SqlParameter FirstNameOutPutParameter = new SqlParameter("@FirstName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(FirstNameOutPutParameter);
                        SqlParameter MidleNameOutPutParameter = new SqlParameter("@MidleName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(MidleNameOutPutParameter);
                        SqlParameter LastNameOutPutParameter = new SqlParameter("@LastName", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(LastNameOutPutParameter);
                        SqlParameter BirthDateOutPutParameter = new SqlParameter("@BirthDate", SqlDbType.Date)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(BirthDateOutPutParameter);
                        SqlParameter GenderOutPutParameter = new SqlParameter("@Gender", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(GenderOutPutParameter);
                        SqlParameter PhoneOutPutParameter = new SqlParameter("@Phone", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(PhoneOutPutParameter);
                        SqlParameter EmailOutPutParameter = new SqlParameter("@Email", SqlDbType.NVarChar, 150)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(EmailOutPutParameter);
                        SqlParameter AddressOutPutParameter = new SqlParameter("@Address", SqlDbType.NVarChar, 250)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(AddressOutPutParameter);
                        SqlParameter CountryIDOutPutParameter = new SqlParameter("@CountryID", SqlDbType.TinyInt)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(CountryIDOutPutParameter);
                        SqlParameter IsFoundOutputParameter = new SqlParameter("@IsFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        Command.Parameters.Add(IsFoundOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsFound = (bool)Command.Parameters["@IsFound"].Value;
                        if (IsFound)
                        {
                            ID = (int)Command.Parameters["@ID"].Value;
                            NationalNumber = (string)Command.Parameters["@NationalNumber"].Value;
                            FirstName = (string)Command.Parameters["@FirstName"].Value;
                            MidleName = Command.Parameters["@MidleName"].Value == DBNull.Value ? "" :
                                        (string)Command.Parameters["@MidleName"].Value;
                            LastName = (string)Command.Parameters["@LastName"].Value;
                            BirthDate = (DateTime)Command.Parameters["@BirthDate"].Value;
                            Gender = (bool)Command.Parameters["@Gender"].Value;
                            Email = (string)Command.Parameters["@Email"].Value;
                            Phone = (string)Command.Parameters["@Phone"].Value;
                            Address = (string)Command.Parameters["@Address"].Value;
                            CountryID = (byte)Command.Parameters["@CountryID"].Value;
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
        public static bool AddNewPerson(ref int ID, string NationalNumber, string FirstName, string MidleName, string LastName,
             DateTime BirthDate, bool Gender, string Phone, string Email, string Address, byte CountryID, int UserID, 
             ref string ErrorMessage)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_AddNewPerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                        Command.Parameters.AddWithValue("@FirstName", FirstName);
                        if (MidleName != string.Empty)
                            Command.Parameters.AddWithValue("@MidleName", MidleName);
                        else
                            Command.Parameters.AddWithValue("@NationalNumber", DBNull.Value);
                        Command.Parameters.AddWithValue("@LastName", LastName);
                        Command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        Command.Parameters.AddWithValue("@Gender", Gender);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Address", Address);
                        Command.Parameters.AddWithValue("@CountryID", CountryID);
                        Command.Parameters.AddWithValue("@OperationUserID", UserID);
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
        public static bool UpdatePersonInfo(int ID, string NationalNumber, string FirstName, string MidleName, string LastName,
             DateTime BirthDate, bool Gender, string Phone, string Email, string Address, byte CountryID, int UserID,
             ref string ErrorMessage)
        {
            bool IsUpdated = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_UpdatePersonInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);
                        Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                        Command.Parameters.AddWithValue("@FirstName", FirstName);
                        if (MidleName != string.Empty)
                            Command.Parameters.AddWithValue("@MidleName", MidleName);
                        else
                            Command.Parameters.AddWithValue("@NationalNumber", DBNull.Value);
                        Command.Parameters.AddWithValue("@LastName", LastName);
                        Command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        Command.Parameters.AddWithValue("@Gender", Gender);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Address", Address);
                        Command.Parameters.AddWithValue("@CountryID", CountryID);
                        Command.Parameters.AddWithValue("@OperationUserID", UserID);
                        SqlParameter ReturnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(ReturnParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        IsUpdated = (int)ReturnParameter.Value > 0;
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
        public static bool DeletePerson(int ID, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeletePersonInfoByID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ID", ID);

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
        public static bool DeletePerson(string NationalNumber, ref string ErrorMessage)
        {
            bool IsDeleted = false;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_DeletePersonByNationalNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

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
        public static DataTable GetSetOfPeoplePerPage(int PageNumber, int NumberOfPatiensPerPage, ref string ErrorMessage)
        {
            DataTable dtPeople = new DataTable();
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_GetSetOfPeople", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        Command.Parameters.AddWithValue("@RowsPerPage", NumberOfPatiensPerPage);
                        Connection.Open();
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dtPeople.Load(Reader);
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
            return dtPeople;
        }
        public static int GetPeopleTotalNumber(ref string ErrorMessage)
        {
            int TotalPeopleNumber = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
                {
                    using (SqlCommand Command = new SqlCommand("SP_TotalPeopleNumber", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        SqlParameter TotalPatientsOutputParameter = new SqlParameter("@TotalPeopleNumber", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(TotalPatientsOutputParameter);
                        Connection.Open();
                        Command.ExecuteNonQuery();
                        TotalPeopleNumber = (int)Command.Parameters["@TotalPeopleNumber"].Value;
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

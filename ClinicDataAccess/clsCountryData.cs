using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccess
{
    public static class clsCountryData
    {
        public static Dictionary<string, string> GetAllCountries()
        {
            Dictionary<string, string> dicCountries= new Dictionary<string, string>();
            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
            {
                using (SqlCommand Command = new SqlCommand("SP_GetAllCountries", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            dicCountries.Add((string)Reader["CountryName"], (string)Reader["CountryCode"]);
                            
                        }
                        Reader.Close();
                    }
                    Connection.Close();
                }
            }
            return dicCountries;
        }
        public static bool GetCountryByID(byte CountryID, ref string CountryName, ref string CountryCode)
        {
            bool IsFound = false;
            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionsString))
            {
                using (SqlCommand Command = new SqlCommand("SP_GetCountryByID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@CountryID", CountryID);
                    SqlParameter OutputCountryNameParameter = new SqlParameter("@CountryName", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Output,
                    };
                    Command.Parameters.Add(OutputCountryNameParameter);
                    SqlParameter OutputCountryCodeParameter = new SqlParameter("@CountryCode", SqlDbType.NVarChar, 10)
                    {
                        Direction= ParameterDirection.Output,
                    };
                    Command.Parameters.Add(OutputCountryCodeParameter);
                    SqlParameter OutputIsFoundParameter = new SqlParameter("@IsFound", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output,
                    };
                    Command.Parameters.Add(OutputIsFoundParameter);
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    IsFound = (bool)Command.Parameters["@IsFound"].Value;
                    if (IsFound)
                    {
                        CountryName = (string)Command.Parameters["@CountryName"].Value;
                        CountryCode = (string)Command.Parameters["@CountryCode"].Value;
                    }
                    Connection.Close();
                }
            }
            return IsFound;
        }
    }
}

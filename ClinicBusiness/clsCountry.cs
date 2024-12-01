using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicDataAccess;
namespace ClinicBusiness
{
    public class clsCountry
    {
        public byte CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public static Dictionary<string, string> GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
        public clsCountry()
        {
            CountryID = 0;
            CountryName = string.Empty;
            CountryCode = string.Empty;
        }
        private clsCountry(byte CountryID, string CountryName, string CountryCode)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.CountryCode = CountryCode;
        }
        public static clsCountry GetCountryByID(byte CountryID)
        {
            string countryName = string.Empty;
            string countryCode = string.Empty;
            if (clsCountryData.GetCountryByID(CountryID, ref countryName, ref countryCode))
            {
                return new clsCountry(CountryID, countryName, countryCode);
            }
            else
                return null;
        }
    }
}

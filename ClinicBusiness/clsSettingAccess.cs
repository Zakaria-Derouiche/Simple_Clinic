using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness
{
    public class clsSettingAccess
    {
        public static void CreateEventLog()
        {
            clsDataAccessSettings.CreateEventLog();
        }
        public static void AddEventLog(string Message)
        {
            clsDataAccessSettings.AddEventLog(Message);
        }
        public static void AddUserLoginEventLog(string Message)
        {
            clsDataAccessSettings.AddUserLoginEventLog(Message);
        }
    }
}

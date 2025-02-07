using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClinicDataAccess
{
    public static  class clsDataAccessSettings
    {
        public static string ConnectionsString = "Server=.;Database=Simple_Clinic;User Id=sa;Password=123456;";

        public static string SourceApp = "SimpleClinic";
        public static void CreateEventLog()
        {
            EventLog.CreateEventSource(SourceApp, "Application");
        }
        public static void AddEventLog(string Message)
        {
            if (!EventLog.SourceExists(SourceApp))
            {
                CreateEventLog();
            }
            EventLog.WriteEntry(SourceApp, Message, EventLogEntryType.Error);
        }
        public static void AddUserLoginEventLog(string Message)
        {
            if (!EventLog.SourceExists(SourceApp))
            {
                CreateEventLog();
            }
            EventLog.WriteEntry(SourceApp, Message, EventLogEntryType.Information);
        }
    }
}

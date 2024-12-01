using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicBusiness;

namespace SimpleClinic
{
    public class clsGlobal
    {
        public static clsUser CurrentUser = new clsUser();
        public static string ErrorMessage = string.Empty;
    }
}

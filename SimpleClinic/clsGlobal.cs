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
        
   
        public static string PeopleImagesFolder = @"C:\Users\THINK15-G4\source\repos\SimpleClinicProject\SimpleClinic\EmployeeImages\";
        public static string DesplayedImageFolder = @"C:\Users\THINK15-G4\source\repos\SimpleClinicProject\SimpleClinic\ImageToDisplay\";
    }
}

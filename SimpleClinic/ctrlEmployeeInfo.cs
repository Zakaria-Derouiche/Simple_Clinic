using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class ctrlEmployeeInfo : UserControl
    {
        
        public ctrlEmployeeInfo()
        {
            InitializeComponent();
        }
       
        private void ctrlEmployeeInfo_Load(object sender, EventArgs e)
        {
            LoadEmployeeInfo(null);
        }
      
        
        public void LoadEmployeeInfo(clsEmployee Employee)
        {
            lblEmployeeID.Text = Employee == null || Employee.EmployeeID == -1 ? "[???]" : Employee.EmployeeID.ToString();

            lblPersonID.Text = Employee == null || Employee.ID == -1 ? "[???]" : Employee.ID.ToString();

            lblHireDate.Text = Employee == null || Employee.EmployeeID == -1 ? "[???]" : Employee.HireDate.ToShortDateString();

            lblEndDate.Text = Employee == null || Employee.EmployeeID == -1 ? "[???]" :
                !Employee.EndDate.HasValue ? "N/A" : Employee.EndDate.Value.ToShortDateString();

            lblTypeOfLeaving.Text = Employee == null || Employee.EmployeeID == -1 ? "[???]" :
                !Employee.TypeOfLeaving.HasValue ? "N/A" : Employee.TypeOfLeaving.ToString();

            lblReasonOfLeaving.Text = Employee == null || Employee.EmployeeID == -1 ? "[???]" :
                Employee.ReasonOfLeaving == string.Empty ? "N/A" : Employee.ReasonOfLeaving;

            picBoxEmployeeImage.ImageLocation = Employee == null || Employee.EmployeeID == -1 ||
                Employee.ImagePath == string.Empty ? "" : _GetDecryptedImage(Employee.ImagePath);
 
        }

        private string _GetDecryptedImage(string ImagePath)
        {
            string NewImagePath = clsEncryptionDecryption.Decrypt(ImagePath);

            string DispalyedImagePath = clsGlobal.DesplayedImageFolder + clsUtil.GetFileName(NewImagePath);

            clsEncryptionDecryption.DecryptFile(NewImagePath, DispalyedImagePath);

            return DispalyedImagePath;
        }

    }
}

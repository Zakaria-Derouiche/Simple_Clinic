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
    public partial class frmUserPermissions : Form
    {
        private string _UserPermissions = string.Empty;
        public frmUserPermissions(ref string UserPermissions)
        {
            InitializeComponent();

            _UserPermissions = UserPermissions;
        }

        string[] Tables = {"People", "Patients", "Employees", "Doctors", "Users", "Appointments", "MedicalRecords",
            "Prescriptions", "Payments", "Operations", "AppointmentsOperations"};

        private string _GetPermissionOnTable(string TabbleName)
        {
            int StartIndex = _UserPermissions.IndexOf(TabbleName);
            int LastIndex =  _UserPermissions.LastIndexOf(TabbleName);
            string Permisssions = _UserPermissions.Substring(StartIndex, LastIndex - StartIndex);
            return Permisssions;
        }
        private void _DisplayUserPermissions()
        {
            if(_UserPermissions.Contains("People"))
            {

            }


        }



        private bool _CheckTypeOfPermission()
        {
            return false;
        }
        private bool _CheckPermissionOnTable(string TableName)
        {
            return _UserPermissions.Contains(TableName); 
            
        }



        private void frmUserPermissions_Load(object sender, EventArgs e)
        {
            if(_UserPermissions != string.Empty)
            {

            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

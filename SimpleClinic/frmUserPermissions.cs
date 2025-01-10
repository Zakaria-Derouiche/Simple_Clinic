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

        bool _Mode;

        Form _Sender;

        private string _UserPermissions = string.Empty;

        private bool _IsPermmissionChanged = false;

        public event EventHandler<string> UserPermissionsChanged;

        public frmUserPermissions(string UserPermissions, bool ShowMode = false, Form Sender = null)
        {
            InitializeComponent();

            _UserPermissions = UserPermissions;
           
            _Mode = ShowMode;

            btnSave.Enabled = !_Mode;

            _Sender = Sender;
        }

        private string _GetPermissionOnTable(string TabbleName)
        {
            int StartIndex = _UserPermissions.IndexOf(TabbleName);
            int LastIndex = _UserPermissions.LastIndexOf(TabbleName);
            string Permisssions = _UserPermissions.Substring(StartIndex, LastIndex - StartIndex);
            return Permisssions;
        }

        private void _DisableAllCheckBoxes()
        {
            checkBoxPeopleCreate.Enabled = false;
            checkBoxPeopleUpdate.Enabled = false;
            checkBoxPeopleRead.Enabled = false;
            checkBoxPeopleDelete.Enabled = false;

            checkBoxPatientsCreate.Enabled = false;
            checkBoxPatientsUpdate.Enabled = false;
            checkBoxPatientsRead.Enabled = false;
            checkBoxPatientsDelete.Enabled = false;

            checkBoxEmployeesCreate.Enabled = false;
            checkBoxEmployeesUpdate.Enabled = false;
            checkBoxEmployeesRead.Enabled = false;
            checkBoxEmployeesDelete.Enabled = false;

            checkBoxDoctorsCreate.Enabled = false;
            checkBoxDoctorsUpdate.Enabled = false;
            checkBoxDoctorsRead.Enabled = false;
            checkBoxDoctorsDelete.Enabled = false;

            checkBoxUsersCreate.Enabled = false;
            checkBoxUsersUpdate.Enabled = false;
            checkBoxUsersRead.Enabled = false;
            checkBoxUsersDelete.Enabled = false;

            checkBoxAppointmentsCreate.Enabled = false;
            checkBoxAppointmentsUpdate.Enabled = false;
            checkBoxAppointmentsRead.Enabled = false;
            checkBoxAppointmentsDelete.Enabled = false;

            checkBoxMedicalRecordsCreate.Enabled = false;
            checkBoxMedicalRecordsUpdate.Enabled = false;
            checkBoxMedicalRecordsRead.Enabled = false;
            checkBoxMedicalRecordsDelete.Enabled = false;

            checkBoxPaymentsCreate.Enabled = false;
            checkBoxPaymentsUpdate.Enabled = false;
            checkBoxPaymentsRead.Enabled = false;
            checkBoxPaymentsDelete.Enabled = false;

            checkBoxPrescriptionsCreate.Enabled = false;
            checkBoxPrescriptionsUpdate.Enabled = false;
            checkBoxPrescriptionsRead.Enabled = false;
            checkBoxPrescriptionsDelete.Enabled = false;

            checkBoxOperationsRead.Enabled = false;

            checkBoxAppointmentsOperationsRead.Enabled = false;
        }

        private void _SelectAllCheckBoxes()
        {
            checkBoxPeopleCreate.Checked = true;
            checkBoxPeopleUpdate.Checked = true;
            checkBoxPeopleRead.Checked = true;
            checkBoxPeopleDelete.Checked = true;

            checkBoxPatientsCreate.Checked = true;
            checkBoxPatientsUpdate.Checked = true;
            checkBoxPatientsRead.Checked = true;
            checkBoxPatientsDelete.Checked = true;

            checkBoxEmployeesCreate.Checked = true;
            checkBoxEmployeesUpdate.Checked = true;
            checkBoxEmployeesRead.Checked = true;
            checkBoxEmployeesDelete.Checked = true;

            checkBoxDoctorsCreate.Checked = true;
            checkBoxDoctorsUpdate.Checked = true;
            checkBoxDoctorsRead.Checked = true;
            checkBoxDoctorsDelete.Checked = true;

            checkBoxUsersCreate.Checked = true;
            checkBoxUsersUpdate.Checked = true;
            checkBoxUsersRead.Checked = true;
            checkBoxUsersDelete.Checked = true;

            checkBoxAppointmentsCreate.Checked = true;
            checkBoxAppointmentsUpdate.Checked = true;
            checkBoxAppointmentsRead.Checked = true;
            checkBoxAppointmentsDelete.Checked = true;

            checkBoxMedicalRecordsCreate.Checked = true;
            checkBoxMedicalRecordsUpdate.Checked = true;
            checkBoxMedicalRecordsRead.Checked = true;
            checkBoxMedicalRecordsDelete.Checked = true;

            checkBoxPaymentsCreate.Checked = true;
            checkBoxPaymentsUpdate.Checked = true;
            checkBoxPaymentsRead.Checked = true;
            checkBoxPaymentsDelete.Checked = true;

            checkBoxPrescriptionsCreate.Checked = true;
            checkBoxPrescriptionsUpdate.Checked = true;
            checkBoxPrescriptionsRead.Checked = true;
            checkBoxPrescriptionsDelete.Checked = true;

            checkBoxOperationsRead.Checked = true;

            checkBoxAppointmentsOperationsRead.Checked = true;

        }
        private void _DisplayUserPermissions()
        {
            if (_Mode)
                _DisableAllCheckBoxes();
            if(_UserPermissions == "Full Control")
                _SelectAllCheckBoxes();
            if (_UserPermissions.Contains("People"))
            {
                string Permissions = _GetPermissionOnTable("People");
                checkBoxPeopleCreate.Checked = Permissions.Contains("Create");
                checkBoxPeopleUpdate.Checked = Permissions.Contains("Update");
                checkBoxPeopleRead.Checked = Permissions.Contains("Read");
                checkBoxPeopleDelete.Checked = Permissions.Contains("Delete");
            }
            if (_UserPermissions.Contains("Patients"))
            {
                string Permissions = _GetPermissionOnTable("Patients");
                checkBoxPatientsCreate.Checked = Permissions.Contains("Create");
                checkBoxPatientsUpdate.Checked = Permissions.Contains("Update");
                checkBoxPatientsRead.Checked = Permissions.Contains("Read");
                checkBoxPatientsDelete.Checked = Permissions.Contains("Delete");
            }
            if (_UserPermissions.Contains("Employees"))
            {
                string Permissions = _GetPermissionOnTable("Employee");
                checkBoxEmployeesCreate.Checked = Permissions.Contains("Create");
                checkBoxEmployeesUpdate.Checked = Permissions.Contains("Update");
                checkBoxEmployeesRead.Checked = Permissions.Contains("Read");
                checkBoxEmployeesDelete.Checked = Permissions.Contains("Delete");
            }
            if (_UserPermissions.Contains("Doctors"))
            {
                string Permissions = _GetPermissionOnTable("Doctors");
                checkBoxDoctorsCreate.Checked = Permissions.Contains("Create");
                checkBoxDoctorsUpdate.Checked = Permissions.Contains("Update");
                checkBoxDoctorsRead.Checked = Permissions.Contains("Read");
                checkBoxDoctorsDelete.Checked = Permissions.Contains("Delete");
            }

            if (_UserPermissions.Contains("Users"))
            {
                string Permissions = _GetPermissionOnTable("Users");
                checkBoxUsersCreate.Checked = Permissions.Contains("Create");
                checkBoxUsersUpdate.Checked = Permissions.Contains("Update");
                checkBoxUsersRead.Checked = Permissions.Contains("Read");
                checkBoxUsersDelete.Checked = Permissions.Contains("Delete");
            }
            if (_UserPermissions.Contains("Appointments"))
            {
                string Permissions = _GetPermissionOnTable("Appointments");
                checkBoxAppointmentsCreate.Checked = Permissions.Contains("Create");
                checkBoxAppointmentsUpdate.Checked = Permissions.Contains("Update");
                checkBoxAppointmentsRead.Checked = Permissions.Contains("Read");
                checkBoxAppointmentsDelete.Checked = Permissions.Contains("Delete");
            }
            if (_UserPermissions.Contains("MedicalRecords"))
            {
                string Permissions = _GetPermissionOnTable("MedicalRecords");
                checkBoxMedicalRecordsCreate.Checked = Permissions.Contains("Create");
                checkBoxMedicalRecordsUpdate.Checked = Permissions.Contains("Update");
                checkBoxMedicalRecordsRead.Checked = Permissions.Contains("Read");
                checkBoxMedicalRecordsDelete.Checked = Permissions.Contains("Delete");
            }
            if (_UserPermissions.Contains("Payments"))
            {
                string Permissions = _GetPermissionOnTable("Payments");
                checkBoxPaymentsCreate.Checked = Permissions.Contains("Create");
                checkBoxPaymentsUpdate.Checked = Permissions.Contains("Update");
                checkBoxPaymentsRead.Checked = Permissions.Contains("Read");
                checkBoxPaymentsDelete.Checked = Permissions.Contains("Delete");
            }

            if (_UserPermissions.Contains("Prescriptions"))
            {
                string Permissions = _GetPermissionOnTable("Prescriptions");
                checkBoxPrescriptionsCreate.Checked = Permissions.Contains("Create");
                checkBoxPrescriptionsUpdate.Checked = Permissions.Contains("Update");
                checkBoxPrescriptionsRead.Checked = Permissions.Contains("Read");
                checkBoxPrescriptionsDelete.Checked = Permissions.Contains("Delete");
            }
            if (_UserPermissions.Contains("Operations"))
            {
                string Permissions = _GetPermissionOnTable("Operations");

                checkBoxOperationsRead.Checked = Permissions.Contains("Read");

            }
            if (_UserPermissions.Contains("AppointmentsOperations"))
            {
                string Permissions = _GetPermissionOnTable("AppointmentsOperations");

                checkBoxAppointmentsOperationsRead.Checked = Permissions.Contains("Read");

            }

        }

        private string _GetUserPermissions()
        {
            string NewUserPermissions = string.Empty;

            if (checkBoxPeopleCreate.Checked || checkBoxPeopleUpdate.Checked || checkBoxPeopleRead.Checked 
                || checkBoxPeopleDelete.Checked)
            {
                NewUserPermissions +=  "#People";

                NewUserPermissions += checkBoxPeopleCreate.Checked ? "Create" : "";

                NewUserPermissions += checkBoxPeopleUpdate.Checked ? "Update" : "";

                NewUserPermissions += checkBoxPeopleRead.Checked ?  "Read" : "";

                NewUserPermissions += checkBoxPeopleDelete.Checked ? "Delete" : "";

                NewUserPermissions +=  "People#";

            }
          
            if (checkBoxPatientsCreate.Checked ||checkBoxPatientsUpdate.Checked ||checkBoxPatientsRead.Checked 
                || checkBoxPatientsDelete.Checked)
            {
                NewUserPermissions += "#Patients";

                NewUserPermissions += checkBoxPatientsCreate.Checked ? "Create" : "";

                NewUserPermissions += checkBoxPatientsUpdate.Checked ? "Update" : "";

                NewUserPermissions += checkBoxPatientsRead.Checked ? "Read" : "";

                NewUserPermissions += checkBoxPatientsDelete.Checked ? "Delete" : "";

                NewUserPermissions += "Patients#";
            }


            if (checkBoxEmployeesCreate.Checked || checkBoxEmployeesUpdate.Checked ||checkBoxEmployeesRead.Checked
                ||checkBoxEmployeesDelete.Checked)
            {
                NewUserPermissions += "#Employees";

                NewUserPermissions += checkBoxEmployeesCreate.Checked ? "Create" : "";

                NewUserPermissions += checkBoxEmployeesUpdate.Checked ? "Update" : "";

                NewUserPermissions += checkBoxEmployeesRead.Checked ? "Read" : "";

                NewUserPermissions += checkBoxEmployeesDelete.Checked ? "Delete" : "";

                NewUserPermissions += "Employees#";
            }

            if (checkBoxDoctorsCreate.Checked  || checkBoxDoctorsUpdate.Checked || checkBoxDoctorsRead.Checked 
                || checkBoxDoctorsDelete.Checked)
            {
                NewUserPermissions += "#Doctors";

                NewUserPermissions += checkBoxDoctorsCreate.Checked ? "Create" : "";

                NewUserPermissions += checkBoxDoctorsUpdate.Checked ? "Update" : "";

                NewUserPermissions += checkBoxDoctorsRead.Checked ? "Read" : "";

                NewUserPermissions += checkBoxDoctorsDelete.Checked ? "Delete" : "";

                NewUserPermissions += "Doctors#";

            }



            if (checkBoxUsersCreate.Checked || checkBoxUsersUpdate.Checked || checkBoxUsersRead.Checked 
                || checkBoxUsersDelete.Checked)
            {
                NewUserPermissions += "#Users";

                NewUserPermissions += checkBoxUsersCreate.Checked ? "Create" : "";

                NewUserPermissions += checkBoxUsersUpdate.Checked ? "Update" : "";

                NewUserPermissions += checkBoxUsersRead.Checked ? "Read" : "";

                NewUserPermissions += checkBoxUsersDelete.Checked ? "Delete" : "";

                NewUserPermissions += "Users#";
            }


            if (checkBoxAppointmentsCreate.Checked || checkBoxAppointmentsUpdate.Checked || checkBoxAppointmentsRead.Checked
                || checkBoxAppointmentsDelete.Checked)
            {
                NewUserPermissions += "#Appointments";

                NewUserPermissions += checkBoxAppointmentsCreate.Checked ? "Create" : "";

                NewUserPermissions += checkBoxAppointmentsUpdate.Checked ? "Update" : "";

                NewUserPermissions += checkBoxAppointmentsRead.Checked ? "Read" : "";

                NewUserPermissions += checkBoxAppointmentsDelete.Checked ? "Delete" : "";

                NewUserPermissions += "Appointments#";
            }
            if (checkBoxMedicalRecordsCreate.Checked || checkBoxMedicalRecordsUpdate.Checked || checkBoxMedicalRecordsRead.Checked
                || checkBoxMedicalRecordsDelete.Checked)
            {
                NewUserPermissions += "#MedicalRecords";

                NewUserPermissions += checkBoxMedicalRecordsCreate.Checked ? "Create" : "";

                NewUserPermissions += checkBoxMedicalRecordsUpdate.Checked ? "Update" : "";

                NewUserPermissions += checkBoxMedicalRecordsRead.Checked ? "Read" : "";

                NewUserPermissions += checkBoxMedicalRecordsDelete.Checked ? "Delete" : "";

                NewUserPermissions += "MedicalRecords#";
            }
            
            if (checkBoxPaymentsCreate.Checked || checkBoxPaymentsUpdate.Checked || checkBoxPaymentsRead.Checked 
                ||checkBoxPaymentsDelete.Checked)
            {
                NewUserPermissions += "#Payments";

                NewUserPermissions += checkBoxPaymentsCreate.Checked ? "Create" : "";

                NewUserPermissions += checkBoxPaymentsUpdate.Checked ? "Update" : "";

                NewUserPermissions += checkBoxPaymentsRead.Checked ? "Read" : "";

                NewUserPermissions += checkBoxPaymentsDelete.Checked ? "Delete" : "";

                NewUserPermissions += "Payments#";
            }


            if (checkBoxPrescriptionsCreate.Checked || checkBoxPrescriptionsUpdate.Checked || checkBoxPrescriptionsRead.Checked
                || checkBoxPrescriptionsDelete.Checked)
            {
                NewUserPermissions += "#Prescriptions";

                NewUserPermissions += checkBoxPrescriptionsCreate.Checked ? "Create" : "";

                NewUserPermissions += checkBoxPrescriptionsUpdate.Checked ? "Update" : "";

                NewUserPermissions += checkBoxPrescriptionsRead.Checked ? "Read" : "";

                NewUserPermissions += checkBoxPrescriptionsDelete.Checked ? "Delete" : "";

                NewUserPermissions += "Prescriptions#";
            }
            
            if (checkBoxOperationsRead.Checked )
            {
                NewUserPermissions += "#Operations";

              

                NewUserPermissions += checkBoxOperationsRead.Checked ? "Read" : "";

              
                NewUserPermissions += "Operations#";
            }
            if (checkBoxAppointmentsOperationsRead.Checked)
            {
                NewUserPermissions += "#AppointmentsOperations";



                NewUserPermissions += checkBoxAppointmentsOperationsRead.Checked ? "Read" : "";


                NewUserPermissions += "AppointmentsOperations#";
            }

            
            return NewUserPermissions;

            
        }

        private void frmUserPermissions_Load(object sender, EventArgs e)
        {
            if(_UserPermissions != string.Empty)
            {
                _DisplayUserPermissions();
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string NewUserPermissions = _GetUserPermissions();

            if(_UserPermissions != NewUserPermissions)
            {
                _UserPermissions = NewUserPermissions;

                _IsPermmissionChanged = true;
            }
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_IsPermmissionChanged)
            {
                UserPermissionsChanged?.Invoke(this, _UserPermissions);
            }

            _Sender.Show();

            this.Close();
        }
    }
}

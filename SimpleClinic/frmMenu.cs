using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness;
namespace SimpleClinic
{
    public partial class frmMenu : Form
    {
        Form _Sender;
        public frmMenu(Form sender)
        {
            InitializeComponent();
            _Sender = sender;
        }
        
        private bool _CheckAuthorisation(string Item, string Type)
        {
            string _UserPermissions = clsEncryptionDecryption.Decrypt(clsGlobal.CurrentUser.Permission);
            
            if(_UserPermissions == "Full Control")
                return true;

            int StartIndex = _UserPermissions.IndexOf(Item);

            int LastIndex = _UserPermissions.LastIndexOf(Item);

            if (StartIndex == -1)
                return false;
            
            if(LastIndex == -1)
                LastIndex = _UserPermissions.Length - 1;

            string Permisssion = _UserPermissions.Substring(StartIndex, LastIndex - StartIndex);

            return Permisssion.Contains(Type);
            
        }
        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!_CheckAuthorisation("People", "Create"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            frmAddEditPerson Person = new frmAddEditPerson(-1, this);

            this.Hide();

            Person.ShowDialog();
        }
        private void peopleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("People", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmPeopleList People = new frmPeopleList(this);

            People.ShowDialog();
        }

        private void findPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("People", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            frmFindPerson Find = new frmFindPerson(this);

            this.Hide();

            Find.ShowDialog();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Patients", "Create"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmAddEditPatient Add = new frmAddEditPatient(-1, this);

            this.Hide();

            Add.ShowDialog();
        }

        private void patientsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Patients", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmFindPatient Find = new frmFindPatient(this);

            this.Hide();

            Find.ShowDialog();
        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Patients", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmPatientsList List = new frmPatientsList(this);

            this.Hide();

            List.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Employees", "Create"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmAddEditEmployee Add = new frmAddEditEmployee(-1, this);

            this.Hide();

            Add.ShowDialog();
        }

        private void findAnEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Employees", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmFindEmployee Find = new frmFindEmployee(this);

            this.Hide();

            Find.ShowDialog();
        }

        private void employeesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Employees", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmEmployeesList List = new frmEmployeesList(this);

            this.Hide();

            List.ShowDialog();
        }

        private void addADoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Doctors", "Create"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmAddEditDoctor Add = new frmAddEditDoctor(-1, this);

            this.Hide();

            Add.ShowDialog();
        }
        private void findADoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Doctors", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmFindDoctor Doctor = new frmFindDoctor(this);

            this.Hide();

            Doctor.ShowDialog();
        }
        private void doctorsListToolStripMenuItem_Click(object sender, EventArgs e)

        {
            if (!_CheckAuthorisation("Doctors", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmDoctorList list = new frmDoctorList(this);

            this.Hide();

            list.ShowDialog();
        }
       
        private void addAnAppontmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Appointments", "Create"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmAddUpdateAppointment Appointment = new frmAddUpdateAppointment(-1, this);

            this.Hide();

            Appointment.ShowDialog();
        }
        private void appointmentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Appointments", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmAppointmentsList Appointments = new frmAppointmentsList(this);

            this.Hide();

            Appointments.ShowDialog();
        }
        
        private void medicalRecordsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("MedicalRecords", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmMedicalRecordsList list = new frmMedicalRecordsList(this);

            this.Hide();

            list.ShowDialog();
        }

       
        private void addAPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Payments", "Create"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAppointmentsList appointmentsList = new frmAppointmentsList(this);

            this.Hide();

            appointmentsList.ShowDialog();
        }
        private void paymentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Payments", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmPaymentsList list  = new frmPaymentsList(this);

            this.Hide(); 
            
            list.ShowDialog();
        }
       
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Users", "Create"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmAddEditUser Add = new frmAddEditUser(-1, this);

            this.Hide();

            Add.ShowDialog();
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Users", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmFindUser Find = new frmFindUser(this);

            this.Hide();

            Find.ShowDialog();

        }

        private void usersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_CheckAuthorisation("Users", "Read"))
            {
                MessageBox.Show("You Don't have this Permission", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            frmUsersList list = new frmUsersList(this);

            this.Hide();

            list.ShowDialog();
        }

        private void currntUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo UserInfo = new frmUserInfo(this);

            this.Hide();

            UserInfo.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            clsGlobal.CurrentUser = new clsUser();

            this.Close();
        }

       
    }
}

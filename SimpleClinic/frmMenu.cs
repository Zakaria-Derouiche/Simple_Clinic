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
       
        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson Person = new frmAddEditPerson(-1, this);

            this.Hide();

            Person.ShowDialog();
        }
        private void peopleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeopleList People = new frmPeopleList(this);

            People.ShowDialog();
        }

        private void findPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindPerson Find = new frmFindPerson(this);

            this.Hide();

            Find.ShowDialog();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPatient Add = new frmAddEditPatient(-1, this);

            this.Hide();

            Add.ShowDialog();
        }

        private void patientsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindPatient Find = new frmFindPatient(this);

            this.Hide();

            Find.ShowDialog();
        }

        private void patientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientsList List = new frmPatientsList(this);

            this.Hide();

            List.ShowDialog();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findAnEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeesListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addADoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findADoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findAnAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAnAppontmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appointmentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAMedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicalRecordPerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicalRecordsListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAPrescriptioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findPrescriptionByPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            clsGlobal.CurrentUser = new clsUser();

            this.Close();
        }

       
    }
}

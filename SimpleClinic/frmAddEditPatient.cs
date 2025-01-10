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
    public partial class frmAddEditPatient : Form
    {
        private Form _Sender = null;
        private enum enMode { Add, Show}

        private enMode _Mode;

        private clsPatient _Patient = new clsPatient();

        private void _Raise(object sender, EventArgs e)
        {
            if(clsPatient.IsPatientExistByPersonID(ctrlPersonWithFilter1.Person.ID, ref clsGlobal.ErrorMessage))
            {
                _Patient = clsPatient.GetPatientInfoByPersonID(ctrlPersonWithFilter1.Person.ID, ref clsGlobal.ErrorMessage);

                _Mode = _Patient == null || _Patient.PatientID == -1 ? enMode.Add : enMode.Show;
               
            }
            _PrepareFormInfo();

        }

        public frmAddEditPatient(int PatientID, Form sender = null)
        {
            InitializeComponent();

            _Patient = clsPatient.GetPatientInfoByID(PatientID, ref clsGlobal.ErrorMessage);

            _Mode = _Patient == null || _Patient.PatientID == -1 ? enMode.Add : enMode.Show;

            ctrlPersonWithFilter1.PersonSelected += _Raise;

            _Sender = sender;
        }

        private void _PrepareFormInfo()
        {
            lblTitle.Text = _Mode == enMode.Add ? "Add New Patient" : "Patient Informations";

            lblTitle.Location = new Point((this.Size.Width / 2) - (lblTitle.Size.Width / 2), 10);

            lblPatientID.Text =  _Mode == enMode.Add ? "Person ID: N/A" : "Person ID: " + _Patient.PatientID.ToString();

            btnSave.Enabled = _Mode == enMode.Add && ctrlPersonWithFilter1.Person != null

                && ctrlPersonWithFilter1.Person.ID != -1;

        }

        private void frmAddEditPatient_Load(object sender, EventArgs e)
        {

            ctrlPersonWithFilter1.LoadPersonInfo((clsPerson)_Patient);

            _PrepareFormInfo();
        }

        private bool _Check()
        {
            return ctrlPersonWithFilter1.Person != null && ctrlPersonWithFilter1.Person.ID != -1;
        }

        private bool _Save()
        {

            _Patient = new clsPatient();

            _Patient.ID = ctrlPersonWithFilter1.Person.ID;

            return _Patient.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Save())
            {
                lblPatientID.Text = "Patient ID: " + _Patient.PatientID.ToString();

                btnSave.Enabled = false;

                MessageBox.Show("Patient Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               

            else
            
                MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            _Sender.Show();

            this.Close();
        }
    }
}

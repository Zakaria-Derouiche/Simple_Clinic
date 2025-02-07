using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpleClinic
{
    public partial class frmAddMedicalRecord : Form
    {
       
        
        private Form _Sender;

        private clsMedicalRecord _MedicalRecord = new clsMedicalRecord();

        public event EventHandler<clsMedicalRecord> MedicalRecordAdded;

        private bool _ArePrescriptionsAdded = false;

        public frmAddMedicalRecord(Form Sender , int AppointmentID)
        {
            InitializeComponent();

            _MedicalRecord.AppointmentID = AppointmentID;

            _Sender = Sender;
        }

        private void frmAddEditMedicalRecord_Load(object sender, EventArgs e)
        {
            lblAppointmentID.Text = _MedicalRecord.AppointmentID.ToString();

            linkLblShowPrescriptions.Visible = false;

        }

        private bool _CheckInputs()
        {
            return !string.IsNullOrEmpty(txtBoxDescription.Text) && !string.IsNullOrEmpty(txtBoxDiagnosis.Text);
        }

        private void _FillMedicalRecordClass()
        {
            _MedicalRecord.Description = txtBoxDescription.Text;

            _MedicalRecord.Diagnosis = txtBoxDiagnosis.Text;

            _MedicalRecord.Notes = txtBoxNotes.Text;

            _MedicalRecord.CreationDate = DateTime.Now;
        }

        private void _Save()
        {
            if (_MedicalRecord.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage))
            {
                MessageBox.Show("Seccsessful Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MedicalRecordAdded?.Invoke(this, _MedicalRecord);

                linkLblShowPrescriptions.Visible = true;
            }
            else
            {
                MessageBox.Show("Failed Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox ob = (TextBox)sender;

            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void _UpdateInfo()
        {
            lblID.Text = _MedicalRecord.ID.ToString();

            btnSave.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckInputs())
            {
                MessageBox.Show("Fill The Description and Diagnosis Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _FillMedicalRecordClass();

            _Save();

            _ShowAddPrescriptionsDialogue();

            _UpdateInfo();


        }

        private void _Raise(object sender, bool IsAdded)
        {
            linkLblShowPrescriptions.Visible = IsAdded;
        }
        private void _AddPrescriptions()
        {
            frmAddPrescription Add = new frmAddPrescription(this, _MedicalRecord.ID);

            Add.IsAdded += _Raise;

            this.Hide();

            Add.ShowDialog();
        }
      
        private void _ShowAddPrescriptionsDialogue()
        {
           while(MessageBox.Show("Do You Want To Add Prescription To This Medical record?", "Question", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _AddPrescriptions();
            }
          
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            _Sender.Show();

            this.Close();
        }

        private void linkLblShowPrescriptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPrescriptions Show = new frmShowPrescriptions(this, _MedicalRecord.ID);


            this.Hide();

            Show.Show();
        }
    }
}

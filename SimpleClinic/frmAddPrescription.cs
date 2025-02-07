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
    public partial class frmAddPrescription : Form
    {

        Form _sender;

        private int _MedicalRecordId = -1;

        clsPrescription _Perescription = new clsPrescription();

        public event EventHandler<bool> IsAdded;
        public frmAddPrescription(Form Sender, int MedicalRecordID)
        {
            InitializeComponent();

            _sender = Sender;

            _MedicalRecordId= MedicalRecordID;
        }

        private void frmAddPrescription_Load(object sender, EventArgs e)
        {
            dtpStartDate.MinDate = DateTime.Now;
            dtpEndDate.MinDate = DateTime.Now;
        }

        private void txtBoxDosage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxStartDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }

        private void txtBoxEndDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }

        private void txtBoxSpecialInstructions_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void txtBoxMedicationName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        

     

        private void _FillDataToPrescriptionClass()
        {
            string MedicationName = txtBoxMedicationName.Text;
            string Dosage = txtBoxDosage.Text;
            string Frequency = txtBoxFrequency.Text;
            DateTime StartDate = dtpStartDate.Value;
            DateTime EndDate = dtpEndDate.Value;
            string SpecialInstructions = txtBoxSpecialInstructions.Text;
            _Perescription = new clsPrescription(_MedicalRecordId, MedicationName, Dosage, Frequency, StartDate,
                EndDate, SpecialInstructions);
        }

        private void _Save()
        {
            _FillDataToPrescriptionClass();

            bool IsSaved = _Perescription.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);

            IsAdded?.Invoke(this, IsSaved);


        }


        
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _sender.Show();

            this.Close();
        }

     
    }
}

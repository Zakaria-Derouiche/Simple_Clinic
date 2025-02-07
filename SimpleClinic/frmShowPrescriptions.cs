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
    public partial class frmShowPrescriptions : Form
    {
        private Form _Sender;


        DataTable dtPrescriptions = new DataTable();

        public frmShowPrescriptions(Form Sender, int MedicalRecordID)
        {
            InitializeComponent();

            _Sender = Sender;

            dtPrescriptions = clsPrescription.GetPrescriptionsByMedicalRecordID(MedicalRecordID, ref clsGlobal.ErrorMessage);

            MessageBox.Show(clsGlobal.ErrorMessage);

        }


        private void frmAddPrescriptions_Load(object sender, EventArgs e)
        {


            dgvPrescriptions.DataSource = dtPrescriptions;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }
    }
}

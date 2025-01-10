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
    public partial class frmPatientInfo : Form
    {
        Form _Sender = null;
        private clsPatient _Patient = new clsPatient();

        public frmPatientInfo(clsPatient Patient, Form Sender = null)
        {
            InitializeComponent();

            _Sender = Sender;

            _Patient = Patient;
        }

        private void frmPatientInfo_Load(object sender, EventArgs e)
        {
            ctrlPatientInfo1.LoadPatientInfo(_Patient);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }
    }
}

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

    public partial class frmMedicalRecordInfo : Form
    {
        private Form _Sender;

        private clsMedicalRecord _MedicalRecord = new clsMedicalRecord();
        public frmMedicalRecordInfo(Form sender , int MedicalRecordID)
        {
            InitializeComponent();

            _MedicalRecord = clsMedicalRecord.GetMedicalRecordInfo(MedicalRecordID, ref clsGlobal.ErrorMessage);

            _Sender = sender;
        }

        public frmMedicalRecordInfo(Form sender, clsMedicalRecord MedicalRecord)
        {
            InitializeComponent();

            _MedicalRecord = MedicalRecord;

            _Sender = sender;
        }
        private void frmMedicalRecordInfo_Load(object sender, EventArgs e)
        {
            ctrlMedicalRecordInfo1.LoadMedicalRecordInfo(_MedicalRecord);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }
    }
}

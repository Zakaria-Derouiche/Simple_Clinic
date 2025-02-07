using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class frmDoctorInfo : Form
    {
        private clsDoctor _Doctor = new clsDoctor();

        private Form _Sender = null;
        public frmDoctorInfo(int DoctorID, Form Sender = null)
        {
            InitializeComponent();

            _Sender = Sender;

            _Doctor = clsDoctor.GetDoctorInfoByID(DoctorID, ref clsGlobal.ErrorMessage);
        }

        private void frmDoctorInfo_Load(object sender, EventArgs e)
        {
            ctrlDoctorInfo1.LoadDoctorInfo(_Doctor);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();

        }
    }
}

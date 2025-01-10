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
    public partial class frmDoctorInfo : Form
    {
        clsDoctor _Doctor = new clsDoctor();
        public frmDoctorInfo(int DoctorID)
        {
            InitializeComponent();

            _Doctor = clsDoctor.GetDoctorInfoByID(DoctorID, ref clsGlobal.ErrorMessage);
        }

        private void frmDoctorInfo_Load(object sender, EventArgs e)
        {
            ctrlDoctorInfo1.LoadDoctorInfo(_Doctor);
        }
    }
}

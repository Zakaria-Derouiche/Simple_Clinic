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
    public partial class ctrlDoctorInfoWithFilter : UserControl
    {

        private clsDoctor _Doctor = new clsDoctor();

        public clsDoctor Doctor {  get { return _Doctor; } }
        public ctrlDoctorInfoWithFilter()
        {
            InitializeComponent();

            comboBoxFilterBy.SelectedIndex = 0;

            btnFind.Enabled = false;

        }

        private void ctrlDoctorInfoWithFilter_Load(object sender, EventArgs e)
        {
           


        }
        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilterBy.Text = string.Empty;
        }

        private void txtBoxFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxFilterBy.SelectedIndex == 0 || comboBoxFilterBy.SelectedIndex == 2)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            else
                e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxFilterBy_TextChanged(object sender, EventArgs e)
        {
            btnFind.Enabled = txtBoxFilterBy.Text.Length > 0;

        }

        public void LoadDoctorInfo(int DoctorID)
        {
            _Doctor = clsDoctor.GetDoctorInfoByID(DoctorID, ref clsGlobal.ErrorMessage);

            ctrlDoctorInfo1.LoadDoctorInfo(_Doctor);
        }

        private void _GetDoctorInfo()
        {
            if (comboBoxFilterBy.SelectedIndex == 0)
            {
                _Doctor = clsDoctor.GetDoctorInfoByID(Convert.ToInt32(txtBoxFilterBy.Text), ref clsGlobal.ErrorMessage);
            }
            
            else
            {
                _Doctor = clsDoctor.GetDoctorInfoByEmployeeID(Convert.ToInt32(txtBoxFilterBy.Text), ref clsGlobal.ErrorMessage);
            }
        }

        public void LoadUserInfo(int UserID)
        {
            _Doctor = clsDoctor.GetDoctorInfoByID(UserID, ref clsGlobal.ErrorMessage);

            _LoadUserInfo();

            btnFind.Enabled = _Doctor == null || _Doctor.DoctorID < 1;

            txtBoxFilterBy.Enabled = _Doctor == null || _Doctor.DoctorID < 1;

            comboBoxFilterBy.Enabled = _Doctor == null || _Doctor.DoctorID < 1;
        }

        private void _LoadUserInfo()
        {
            //if (_Doctor != null)
                ctrlDoctorInfo1.LoadDoctorInfo(_Doctor);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            _GetDoctorInfo();

            _LoadUserInfo();

        }
    }
}

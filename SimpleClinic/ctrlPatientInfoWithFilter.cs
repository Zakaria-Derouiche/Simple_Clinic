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
    public partial class ctrlPatientInfoWithFilter : UserControl
    {
        private clsPatient _Patient = new clsPatient();
        public ctrlPatientInfoWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlPatientInfoWithFilter_Load(object sender, EventArgs e)
        {
            btnFind.Enabled = false;

            comboBoxFilterBy.SelectedIndex = 0;
        }


        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilterBy.Text = "";
        }

        private void _GetPatientInfo()
        {
            if (comboBoxFilterBy.SelectedIndex == 0)
                _Patient = clsPatient.GetPatientInfoByID(Convert.ToInt32(txtBoxFilterBy.Text), ref clsGlobal.ErrorMessage);
            else 
                _Patient = clsPatient.GetPatientInfoByPersonID(Convert.ToInt32(txtBoxFilterBy.Text), ref clsGlobal.ErrorMessage);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _GetPatientInfo();

            ctrlPatientInfo1.LoadPatientInfo(_Patient);
        }

        private void txtBoxFilterBy_TextChanged(object sender, EventArgs e)
        {
            
                btnFind.Enabled = txtBoxFilterBy.Text.Length > 0;
        }

        private void txtBoxFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

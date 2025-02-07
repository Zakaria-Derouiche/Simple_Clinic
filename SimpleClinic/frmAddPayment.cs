using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicBusiness;

namespace SimpleClinic
{
    public partial class frmAddPayment : Form
    {
        private Form _Sender;

        private int _AppointmentID = -1;

        private Decimal _Amount = 0;

        private clsPayment _Payment = new clsPayment();

        private bool _IsSaved = false;

        public frmAddPayment(Form Sender, int AppointmentID)
        {
            InitializeComponent();

            _Sender = Sender;

            _AppointmentID = AppointmentID;

            

        }
        
        private void _CheckPayemnt()
        {
            _Payment = clsPayment.GetPaymentInfoByAppointmentID(_AppointmentID, ref clsGlobal.ErrorMessage);
            if (_Payment != null && _Payment.ID > 0)
            {
                MessageBox.Show("The Payment For This Appointment Is Already Done", "Info", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                _Sender.Show();

                this.Close();
            }
               
        }
        private void txtBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            comBoxPayemntMethod.SelectedIndex = 0;

            lblAppointmentID.Text = _AppointmentID.ToString();

            _CheckPayemnt();
        }
        private void txtBoxAmount_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = txtBoxAmount.Text.Length > 0;
        }
        private void _FillPaymentClass()
        {
            _Payment = new clsPayment(_AppointmentID, DateTime.Now, comBoxPayemntMethod.Text, _Amount, txtBoxAmount.Text);


        }
        private void _Save()
        {
            _FillPaymentClass();

            _IsSaved = _Payment.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);
        }

        private void _Check()
        {
            if(Decimal.TryParse(txtBoxAmount.Text, out _Amount))
            {
                _Save();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Check();

            if(_IsSaved)
            {
                MessageBox.Show("Successful Operation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }

       
    }
}

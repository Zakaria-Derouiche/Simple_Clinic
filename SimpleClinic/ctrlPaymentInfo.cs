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
    public partial class ctrlPaymentInfo : UserControl
    {
        clsPayment _Payemnt = new clsPayment();
        public ctrlPaymentInfo()
        {
            InitializeComponent();
        }

        public void LoadPaymentInfo(clsPayment Payment)
        {
            _Payemnt = Payment;

            lblID.Text = _Payemnt == null || _Payemnt.ID < 1 ? "[???]" : _Payemnt.ID.ToString();

            lblAppointmentID.Text = _Payemnt == null || _Payemnt.ID < 1 ? "[???]" : _Payemnt.AppointmentID.ToString();

            lblDate.Text = _Payemnt == null || _Payemnt.ID < 1 ? "[???]" : _Payemnt.PaymentDateTime.ToString();

            lblPaymentMethod.Text = _Payemnt == null || _Payemnt.ID < 1 ? "[???]" : _Payemnt.PaymentMethod;

            lblAmount.Text = _Payemnt == null || _Payemnt.ID < 1 ? "[???]" : _Payemnt.PaidAmount.ToString();

            lblNotes.Text = _Payemnt == null || _Payemnt.ID < 1 ? "[???]" : _Payemnt.Notes;

            lblCreatedByUserID.Text = _Payemnt == null || _Payemnt.ID < 1 ? "[???]" : _Payemnt.ScheduledByUserID.ToString();

            linkLblAppointmentInfo.Visible = _Payemnt != null && _Payemnt.ID > 0;
        }

        private void linkLblAppointmentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAppointmentInfo Info = new frmAppointmentInfo(_Payemnt.AppointmentID, ParentForm);

            ParentForm.Hide();

            Info.ShowDialog();
        }
    }
}

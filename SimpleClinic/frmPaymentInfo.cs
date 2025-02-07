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
    public partial class frmPaymentInfo : Form
    {
        private Form _Sender;

        private clsPayment _Payment = new clsPayment();
        public frmPaymentInfo(Form Sender, int PaymentID)
        {
            InitializeComponent();

            _Sender = Sender;

            _Payment = clsPayment.GetPaymentInfoByID(PaymentID, ref clsGlobal.ErrorMessage);


        }

        private void frmPaymentInfo_Load(object sender, EventArgs e)
        {
            ctrlPaymentInfo1.LoadPaymentInfo(_Payment);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }
    }
}

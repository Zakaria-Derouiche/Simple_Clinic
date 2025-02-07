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
    public partial class frmAppointmentInfo : Form
    {
        private Form _Sender;

        clsAppointment _Appointment = new clsAppointment();
        public frmAppointmentInfo(int AppointmentID, Form Sender)
        {
            InitializeComponent();
            
            _Appointment = clsAppointment.GetAppointmentInfo(AppointmentID, ref clsGlobal.ErrorMessage);


            _Sender = Sender;
        }
        private void frmAppointmentInfo_Load(object sender, EventArgs e)
        {
            ctrlAppointmentInfo1.LoadAppointmentInfo(_Appointment);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }

       
    }
}

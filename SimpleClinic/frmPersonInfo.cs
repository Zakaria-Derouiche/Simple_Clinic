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
    public partial class frmPersonInfo : Form
    {
        private Form _Sender;

        clsPerson _Person;
        public frmPersonInfo(clsPerson Person, Form Sender = null)
        {
            InitializeComponent();

            _Person = Person;

            _Sender = Sender;
        }
       

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.LoadPersonInfo(_Person);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }

    }
}

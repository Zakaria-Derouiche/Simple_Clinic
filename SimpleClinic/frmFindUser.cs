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
    public partial class frmFindUser : Form
    {
        Form _Sender;
        
        public frmFindUser(Form Sender = null)
        {
            InitializeComponent();

            _Sender = Sender;
        }

        private void frmFindUser_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();


        }
    }
}

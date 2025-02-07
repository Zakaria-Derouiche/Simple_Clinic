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
    public partial class frmUserInfo : Form
    {
        private clsUser _User = new clsUser();

        Form _Sender;
        public frmUserInfo(int UserID, Form Sender)
        {

            InitializeComponent();

            _Sender = Sender;

           _User = clsUser.GetUserInfoByID(UserID, ref clsGlobal.ErrorMessage);


        }

        public frmUserInfo(Form Sender)
        {

            InitializeComponent();

            _Sender = Sender;

            _User = clsGlobal.CurrentUser;


        }



        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserInfo1.LoadUserInfo(_User);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _Sender.Show();

            this.Close();
        }
    }
}

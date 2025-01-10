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
        public frmUserInfo(int UserID)
        {

            InitializeComponent();

           _User = clsUser.GetUserInfoByID(UserID, ref clsGlobal.ErrorMessage);

        }
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserInfo1.LoadUserInfo(_User);
        }
    }
}

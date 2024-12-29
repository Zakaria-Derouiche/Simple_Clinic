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
        public frmPersonInfo(clsPerson Person)
        {
            InitializeComponent();

            ctrlPersonInfo1.LoadPersonInfo(Person);
        }
        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}

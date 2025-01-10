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
    public partial class frmFindPerson : Form
    {
        Form _Sender = null;
        public frmFindPerson(Form Sender = null)
        {
            InitializeComponent();
            
            _Sender = Sender;

            ctrlPersonWithFilter1.PersonSelected += _Raise;
        }
        private void frmFindPerson_Load(object sender, EventArgs e)
        {
            linkLblUpdatePersonInfo.Visible = false;
        }
        private void _Raise(object sender, EventArgs e)
        {
            if(ctrlPersonWithFilter1.Person != null && ctrlPersonWithFilter1.Person.ID != -1)
            {
                linkLblUpdatePersonInfo.Visible = true;
            }
        }

        private void _Raise(object sender, clsPerson Person)
        {
            ctrlPersonWithFilter1.LoadPersonInfo(Person);
        }
        private void linkLblUpdatePersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson Person = new frmAddEditPerson(ctrlPersonWithFilter1.Person, this);

            Person.PersonAddedOrUpdated += _Raise;

            this.Hide();

            Person.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(_Sender != null)

                _Sender.Show();

            this.Close();
        }
    }
}

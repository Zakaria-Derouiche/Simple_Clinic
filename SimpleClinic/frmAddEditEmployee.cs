using ClinicBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class frmAddEditEmployee : Form
    {

        public event EventHandler<clsEmployee> EmployeeAdded;

        Form _Sender;
        private enum enMode { Add, Edit}

        private enMode _Mode;

        private bool _IsPictureChanged = false;

        private string _DisplayedPersonImage {  get; set; }

        private clsEmployee _Employee = new clsEmployee(); 

        private void Raise(object sender, EventArgs e)
        {
            lblPersonID.Text = ctrlPersonWithFilter1.Person == null || ctrlPersonWithFilter1.Person.ID < 1 ? "" :

                ctrlPersonWithFilter1.Person.ToString();

             _Employee = ctrlPersonWithFilter1.Person == null || ctrlPersonWithFilter1.Person.ID < 1 ? null :
                clsEmployee.GetEmployeeInfoByPersonID(ctrlPersonWithFilter1.Person.ID, ref clsGlobal.ErrorMessage);
  
            _CheckEmployee();

            _LoadEmployeeInfo();
        }

        public frmAddEditEmployee(int EmployeeID, Form Sender = null)
        {
            InitializeComponent();

            _Employee = clsEmployee.GetEmployeeInfoByID(EmployeeID, ref clsGlobal.ErrorMessage);

            
            _Mode = _Employee == null || _Employee.EmployeeID <= 0 ? enMode.Add : enMode.Edit;

            ctrlPersonWithFilter1.PersonSelected += Raise;

            _Sender = Sender;
        }

        private void _CheckEmployee()
        {
            if (_Employee == null || _Employee.EmployeeID < 1)
            
                _Mode = enMode.Add;
            
            else

                _Mode = enMode.Edit;

        }

        private void frmAddEditEmployee_Load(object sender, EventArgs e)
        {
            _CheckEmployee();

            _LoadEmployeeInfo();

            if (_Mode == enMode.Edit)

                ctrlPersonWithFilter1.LoadPersonInfo((clsPerson)_Employee);
        }

        private void _LoadEmployeeInfo()
        {
            
            lblEmployeeID.Text = _Mode == enMode.Add ? "[???]" : _Employee.EmployeeID.ToString();
            
            lblPersonID.Text = ctrlPersonWithFilter1.Person == null || ctrlPersonWithFilter1.Person.ID == -1 ?"[???]" :
                ctrlPersonWithFilter1.Person.ID.ToString();
           
            txtBoxReasonOfLeaving.Enabled = _Employee != null && _Employee.EmployeeID != -1 &&
                _Employee.ReasonOfLeaving != string.Empty;

            txtBoxReasonOfLeaving.Text = _Employee == null || _Employee.EmployeeID == -1 || 
                _Employee.ReasonOfLeaving == string.Empty  ? "" : _Employee.ReasonOfLeaving;

            picBoxEmployeeImage.ImageLocation = _Employee == null || _Employee.EmployeeID == -1 ||
                _Employee.ImagePath == string.Empty ? "" : _GetDecryptedImage();

            _PrepareFrontEnd();
            
        }

        private void _PrepareFrontEnd()
        {
            lblTitle.Text = _Mode == enMode.Add ? "Add New Employee" : "Update Employee Info";

            lblTitle.Location = new Point((this.Size.Width /2) - (lblTitle.Size.Width / 2), 9);

            linkLblAddImage.Text = _Employee == null || _Employee.EmployeeID == -1 || _Employee.ImagePath == string.Empty ?
               "Add Image" : "Change Image";

            linkLblAddImage.Location = linkLblAddImage.Text == "Change Image" ? new Point(20, 120) : new Point(32, 120);

            linkLblRemoveImage.Location = new Point(17, 140);

            linkLblRemoveImage.Visible = _Employee != null && _Employee.EmployeeID != -1 && _Employee.ImagePath != string.Empty;

            gboxEmployeeInfo.Enabled = ctrlPersonWithFilter1.Person != null && ctrlPersonWithFilter1.Person.ID != -1;

            txtBoxReasonOfLeaving.Enabled = _Mode == enMode.Edit;

            dtpEndDate.Enabled = _Mode == enMode.Edit;

            rbResigned.Enabled = _Mode == enMode.Edit;

            rbFired.Enabled = _Mode == enMode.Edit;

            

        }

        private string _GetDecryptedImage()
        {
            string ImagePath = clsEncryptionDecryption.Decrypt(_Employee.ImagePath);

            string DispalyedImagePath = clsGlobal.DesplayedImageFolder + clsUtil.GetFileName(ImagePath);

            clsEncryptionDecryption.DecryptFile(ImagePath, DispalyedImagePath);

            _DisplayedPersonImage = DispalyedImagePath;

            return DispalyedImagePath;
        }
        private void _FillEmployeeInfo()
        {
            _Employee.HireDate = dtpHireDate.Value;

            _Employee.HireDate = _Employee.HireDate == dtpHireDate.Value ? _Employee.HireDate : dtpHireDate.Value;

            _Employee.EndDate = dtpHireDate.Enabled ? dtpEndDate.Value : _Employee.EndDate;

            _Employee.ReasonOfLeaving = txtBoxReasonOfLeaving.Text;

            _Employee.TypeOfLeaving = rbFired.Enabled ? rbFired.Checked || rbResigned.Checked : _Employee.TypeOfLeaving;

            _ProccessImage();
        }        
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Employee = new clsEmployee();
            if (_Mode == enMode.Add && (ctrlPersonWithFilter1.Person == null || ctrlPersonWithFilter1.Person.ID == -1))
                MessageBox.Show("No Person Selected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (clsEmployee.IsEmployeeExistByPersonID(_Employee.ID, ref clsGlobal.ErrorMessage))
            {
                MessageBox.Show("There is An Exsist employee Attached to this Person", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (_Mode == enMode.Add && ctrlPersonWithFilter1.Person != null && ctrlPersonWithFilter1.Person.ID != -1)
            {
                _Employee = new clsEmployee(ctrlPersonWithFilter1.Person);
            }
            _FillEmployeeInfo();
           
            bool IsSaved = _Employee.Save(clsGlobal.CurrentUser.UserID, ref clsGlobal.ErrorMessage);
            if (IsSaved)
            {
                MessageBox.Show("Employee Information Has Saved Successfully", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _IsPictureChanged = false;
            }
            else 
            {
                MessageBox.Show(clsGlobal.ErrorMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void _EncryptAndMoveImage()
        {
            

            string FileName = clsUtil.GetFileName(picBoxEmployeeImage.ImageLocation);

            string OutputFile = clsGlobal.PeopleImagesFolder + FileName;

            clsEncryptionDecryption.EncryptFile(picBoxEmployeeImage.ImageLocation, OutputFile);

            _Employee.ImagePath = clsEncryptionDecryption.Encrypt(OutputFile);

        }
        private void _ProccessImage()
        {
            if (_IsPictureChanged)
            {
                if (picBoxEmployeeImage.ImageLocation != string.Empty)
                    _EncryptAndMoveImage();       
                else
                    _Employee.ImagePath = string.Empty; 
            }
        }
        private void linkLblAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                clsUtil.DeleteFile(_DisplayedPersonImage);
                clsUtil.CopyImageToImageToDisplayFolder(ref selectedFilePath);
                _DisplayedPersonImage = selectedFilePath;
                picBoxEmployeeImage.ImageLocation = selectedFilePath;              
                _IsPictureChanged = true;
                linkLblRemoveImage.Visible = true;
                linkLblAddImage.Text = "Change Image";
                linkLblAddImage.Location = new Point(20, 136);
            }
        }
        private void linkLblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you Sure You Want To Remove This Image?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsUtil.DeleteFile(_DisplayedPersonImage);
                picBoxEmployeeImage.ImageLocation = "";
                _DisplayedPersonImage = string.Empty;
                linkLblRemoveImage.Visible = false;
                linkLblAddImage.Text = "Add Image";
                _IsPictureChanged = true;
            }
        }
        private void dtpHireDate_EnabledChanged(object sender, EventArgs e)
        {
            if (dtpHireDate.Enabled)
            {
                dtpHireDate.MaxDate = DateTime.Now;

                dtpHireDate.Value = _Employee == null || _Employee.EmployeeID == -1 ? DateTime.Now : _Employee.HireDate;
               
            }              
        }
        private void dtpEndDate_EnabledChanged(object sender, EventArgs e)
        {
            if(dtpEndDate.Enabled)
            {
                dtpEndDate.MaxDate = DateTime.Now;

                dtpEndDate.Value = _Employee == null || _Employee.EmployeeID == -1 || !_Employee.EndDate.HasValue?

               DateTime.Now : _Employee.EndDate.Value;

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            clsUtil.DeleteFile(_DisplayedPersonImage);

            _DisplayedPersonImage = string.Empty;

            if(_Employee != null && _Employee.EmployeeID > 0)
                
                EmployeeAdded?.Invoke(this, _Employee);

           
            _Sender.Show();

            this.Close();
        }
    }
}

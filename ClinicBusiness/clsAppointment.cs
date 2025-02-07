using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness
{
    public class clsAppointment
    {
        private enum enMode { Add, Edit}

        private enMode _Mode;
        public int ID {  get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }

        private string ErrorMessage = string.Empty;
        
        public clsMedicalRecord MedicalRecord {
            get { return clsMedicalRecord.GetMedicalRecordInfoByAppointmentID(ID, ref ErrorMessage); }
            set { }
        }
        public DateTime AppointmentDate { get; set; }

        public string AppointmentStatus { get; set; }

        public clsAppointment()
        {
            ID = -1;
            PatientID = -1;
            DoctorID = -1;
            AppointmentDate = DateTime.Now;
            AppointmentStatus = string.Empty;
            _Mode = enMode.Add;
        }

        private clsAppointment(int ID, int PatientID, int DoctorID, DateTime AppointmentDate, string AppointmentStatus)
        {
            this.ID = ID;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.AppointmentDate = AppointmentDate;
            this.AppointmentStatus = AppointmentStatus;
            _Mode = enMode.Edit;
        }

        public bool Save(int UserID, ref string ErrorMessage)
        {
            bool IsSaved = false;
            switch (_Mode)
            {
                case enMode.Add:
                    int NewID = -1;
                    IsSaved = clsAppointmentData.AddNewAppointment(ref NewID, PatientID, DoctorID, AppointmentDate, AppointmentStatus,
                    UserID, ref ErrorMessage);
                    ID =  NewID;
                    _Mode = IsSaved?  enMode.Edit : enMode.Add;
                    break;
                case enMode.Edit:
                    IsSaved = clsAppointmentData.UpdateAppointmentInfo(ID, PatientID, DoctorID, AppointmentDate, AppointmentStatus,
                    UserID, ref ErrorMessage);
                    break;
            }
            return IsSaved;
        }

        public static bool IsAppointmentExist(int ID, ref string ErrorMessage)
        {
            return clsAppointmentData.IsAppointmentExist(ID, ref ErrorMessage);
        }

        public static clsAppointment GetAppointmentInfo(int ID, ref string ErrorMessage)
        {
            int patientID = -1;
            int doctorID = -1;
            DateTime appointmentDate = DateTime.Now;
            string appointmentStatus = string.Empty;
            if(clsAppointmentData.GetAppointmentInfoByID(ID, ref patientID, ref doctorID, ref appointmentDate, ref appointmentStatus,
                ref ErrorMessage))
            {
                return new clsAppointment(ID, patientID, doctorID, appointmentDate, appointmentStatus);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteAppointment(int ID,int UserID,  ref string ErrorMessage)
        {
            return clsAppointmentData.DeleteAppointment(ID, UserID, ref ErrorMessage);
        }

        public static DataTable GetSetOfAppointments(int PageNumber, int NumberOfPatiensPerPage, ref string ErrorMessage)
        {
            DataTable dtDecryptedAppointments = new DataTable();
            dtDecryptedAppointments.Columns.Add("ID", typeof(int));
            dtDecryptedAppointments.Columns.Add("Patient", typeof(string));
            dtDecryptedAppointments.Columns.Add("Doctor", typeof(string));
            dtDecryptedAppointments.Columns.Add("Date", typeof(DateTime));
            dtDecryptedAppointments.Columns.Add("Appointment Status", typeof(string));
            DataTable dtEncryptedAppointments = clsAppointmentData.GetSetOfAppointmentPerPage(PageNumber,
                NumberOfPatiensPerPage, ref ErrorMessage);

            foreach (DataRow row in dtEncryptedAppointments.Rows)
            {
                dtDecryptedAppointments.Rows.Add((int)row["ID"],
                    string.Join(" ", ((string)row["Patient"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    string.Join(" ", ((string)row["Doctor"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    (DateTime)row["Date"],
                    (string)row["Appointments Status"]

                );
            }
            return dtDecryptedAppointments;
            
        }
        public static DataTable GetPersonAppointments(string NationalNumber, int PageNumber, int NumberOfPatiensPerPage,
            ref string ErrorMessage)
        {
            DataTable dtDecryptedAppointments = new DataTable();
            dtDecryptedAppointments.Columns.Add("ID", typeof(int));
            dtDecryptedAppointments.Columns.Add("Patient", typeof(string));
            dtDecryptedAppointments.Columns.Add("Doctor", typeof(string));
            dtDecryptedAppointments.Columns.Add("Date", typeof(DateTime));
            dtDecryptedAppointments.Columns.Add("Appointment Status", typeof(string));
            DataTable dtEncryptedAppointments = clsAppointmentData.GetPersonAppointments(NationalNumber, PageNumber,
                NumberOfPatiensPerPage, ref ErrorMessage);

            foreach (DataRow row in dtEncryptedAppointments.Rows)
            {
                dtDecryptedAppointments.Rows.Add((int)row["ID"],
                    string.Join(" ", ((string)row["Patient"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    string.Join(" ", ((string)row["Doctor"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    (DateTime)row["Date"],
                    (string)row["Appointments Status"]

                );
            }
            return dtDecryptedAppointments;
        }
        public static DataTable GetPersonAppointmentsByName(string FullName, int PageNumber, int NumberOfPatiensPerPage,
         ref string ErrorMessage)
        {
            DataTable dtDecryptedAppointments = new DataTable();
            dtDecryptedAppointments.Columns.Add("ID", typeof(int));
            dtDecryptedAppointments.Columns.Add("Patient", typeof(string));
            dtDecryptedAppointments.Columns.Add("Doctor", typeof(string));
            dtDecryptedAppointments.Columns.Add("Date", typeof(DateTime));
            dtDecryptedAppointments.Columns.Add("Appointment Status", typeof(string));
            DataTable dtEncryptedAppointments = clsAppointmentData.GetPersonAppointmentsByName(FullName, PageNumber,
                NumberOfPatiensPerPage, ref ErrorMessage);

            foreach (DataRow row in dtEncryptedAppointments.Rows)
            {
                dtDecryptedAppointments.Rows.Add((int)row["ID"],
                    string.Join(" ", ((string)row["Patient"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    string.Join(" ", ((string)row["Doctor"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    (DateTime)row["Date"],
                    (string)row["Appointments Status"]

                );
            }
            return dtDecryptedAppointments;
        }

        public static DataTable GetDoctorAppointmentsByNationalNumber(string NationalNo, int PageNumber, int NumberOfPatiensPerPage,
         ref string ErrorMessage)
        {
            DataTable dtDecryptedAppointments = new DataTable();
            dtDecryptedAppointments.Columns.Add("ID", typeof(int));
            dtDecryptedAppointments.Columns.Add("Doctor", typeof(string));
            dtDecryptedAppointments.Columns.Add("Patient", typeof(string));
            dtDecryptedAppointments.Columns.Add("Date", typeof(DateTime));
            dtDecryptedAppointments.Columns.Add("Appointment Status", typeof(string));
            DataTable dtEncryptedAppointments = clsAppointmentData.GetDoctorAppointmentsByNationalNumber(NationalNo, PageNumber,
                NumberOfPatiensPerPage, ref ErrorMessage);
            foreach (DataRow row in dtEncryptedAppointments.Rows)
            {
                dtDecryptedAppointments.Rows.Add((int)row["ID"],
                    string.Join(" ", ((string)row["Doctor"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                     string.Join(" ", ((string)row["Patient"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    (DateTime)row["Date"],
                    (string)row["Appointments Status"]

                );
            }
            return dtDecryptedAppointments;
        }
        public static DataTable GetDoctorAppointments(string DoctorFullName, int PageNumber, int NumberOfPatiensPerPage,
            ref string ErrorMessage)
        {
            DataTable dtDecryptedAppointments = new DataTable();
            dtDecryptedAppointments.Columns.Add("ID", typeof(int));
            dtDecryptedAppointments.Columns.Add("Doctor", typeof(string));
            dtDecryptedAppointments.Columns.Add("Patient", typeof(string));
            
            dtDecryptedAppointments.Columns.Add("Date", typeof(DateTime));
            dtDecryptedAppointments.Columns.Add("Appointment Status", typeof(string));
            DataTable dtEncryptedAppointments = clsAppointmentData.GetDoctorAppointments(DoctorFullName, PageNumber,
                NumberOfPatiensPerPage, ref ErrorMessage);

            foreach (DataRow row in dtEncryptedAppointments.Rows)
            {
                dtDecryptedAppointments.Rows.Add((int)row["ID"],
                    string.Join(" ", ((string)row["Doctor"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    string.Join(" ", ((string)row["Patient"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    (DateTime)row["Date"],
                    (string)row["Appointments Status"]
                );
            }
            return dtDecryptedAppointments;
            
        }

      
        public static DataTable GetAppointmentsByDate(string Date, int PageNumber, int NumberOfPatiensPerPage,
            ref string ErrorMessage)
        {
            DataTable dtDecryptedAppointments = new DataTable();
            dtDecryptedAppointments.Columns.Add("ID", typeof(int));
            dtDecryptedAppointments.Columns.Add("Patient", typeof(string));
            dtDecryptedAppointments.Columns.Add("Doctor", typeof(string));
            dtDecryptedAppointments.Columns.Add("Date", typeof(DateTime));
            dtDecryptedAppointments.Columns.Add("Appointments Status", typeof(string));
            DataTable dtEncryptedAppointments = clsAppointmentData.GetAppointmentsByDate(Date, PageNumber,
                NumberOfPatiensPerPage, ref ErrorMessage);

            foreach (DataRow row in dtEncryptedAppointments.Rows)
            {
                dtDecryptedAppointments.Rows.Add((int)row["ID"],
                    string.Join(" ", ((string)row["Patient"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    string.Join(" ", ((string)row["Doctor"]).Split(' ').
                    Select(s => clsEncryptionDecryption.Decrypt(s))),
                    (DateTime)row["Date"],
                    (string)row["Appointments Status"]
                    
                );
            }
            return dtDecryptedAppointments;
            
        }
        public static int GetTotalAppointmentsNumber(ref string ErrorMessage)
        {
            return clsAppointmentData.GetAppointmentsTotalNumber(ref ErrorMessage);
        }
    }
}

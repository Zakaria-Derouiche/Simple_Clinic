using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness
{
    public class clsMedicalRecord
    {
        private enum EnMode { Add, Edit}

        private EnMode _Mode;
        public int ID { get; set; }
        
        public int AppointmentID { get; set; }

        public string Description { get; set; }

        public string Diagnosis { get; set; }

        public string Notes { get; set; }

        public DateTime CreationDate { get; set; }

        public int CreatedByUserID { get; set; }

        public clsMedicalRecord()
        {
            ID = -1;
            AppointmentID = -1;
            Description = string.Empty;
            Diagnosis = string.Empty;
            Notes = string.Empty;
            CreationDate = DateTime.Now;
            CreatedByUserID = -1;
            _Mode = EnMode.Add;
        }

        private clsMedicalRecord(int ID, int AppointmentID, string Description, string Diagnosis, string Notes, DateTime CreationDate,
            int CreatedByUserID)
        {
            this.ID = ID ;
            this.AppointmentID = AppointmentID;
            this.Description =Description;
            this.Diagnosis = Diagnosis;
            this.Notes = Notes;
            this.CreationDate = CreationDate;
            this.CreatedByUserID = CreatedByUserID;
            _Mode = EnMode.Edit;
        }

        public bool Save(int UserID, ref string ErrorMessage)
        { 
            bool IsSaved = false;
            switch(_Mode)
            {
                case EnMode.Add:
                    int NewID = -1;
                    IsSaved = clsMedicalRecordData.AddNewMedicalRecord(ref NewID, AppointmentID, Description, Diagnosis, Notes, 
                        UserID, ref ErrorMessage);
                    ID = NewID;
                    _Mode = IsSaved ? EnMode.Edit : EnMode.Add; 
                    break;
                case EnMode.Edit:
                    IsSaved = clsMedicalRecordData.UpdateMedicalRecordInfo(ID, AppointmentID, Description, Diagnosis, Notes,
                        UserID, ref ErrorMessage);
                    break;
            }

            return IsSaved;
        }

        public static bool IsMedicalRecordExist(int MedicalRecordID, ref string ErrorMessage)
        {
            return clsMedicalRecordData.IsMedicalRecordExist(MedicalRecordID, ref ErrorMessage);
        }

        public static bool IsMedicalRecordExistByAppointmentID(int AppointmentID, ref string ErrorMessage)
        {
            return clsMedicalRecordData.IsMedicalRecordExistByAppointmentID(AppointmentID, ref ErrorMessage);
        }

        public static clsMedicalRecord GetMedicalRecordInfo(int ID, ref string ErrorMessage)
        {
            int appointmentID = -1;
            string description = string.Empty;
            string diagnosis = string.Empty;
            string notes = string.Empty;
            DateTime creationDate = DateTime.Now;
            int createdByUserID = -1;
            if (clsMedicalRecordData.GetMedicalRecordInfoByID(ID, ref appointmentID, ref description, ref diagnosis,
                ref notes, ref creationDate, ref createdByUserID, ref ErrorMessage))
            {
                return new clsMedicalRecord(ID, appointmentID, description, diagnosis, notes, creationDate, createdByUserID);
            }
            else
            {
                return null;
            }

        }

        public static clsMedicalRecord GetMedicalRecordInfoByAppointmentID(int AppointmentID, ref string ErrorMessage)
        {
            int iD = -1;
            string description = string.Empty;
            string diagnosis = string.Empty;
            string notes = string.Empty;
            DateTime creationDate = DateTime.Now;
            int createdByUserID = -1;
            if (clsMedicalRecordData.GetMedicalRecordInfoByAppointmentID(AppointmentID, ref iD, ref description, ref diagnosis,
                ref notes, ref creationDate, ref createdByUserID, ref ErrorMessage))
            {
                return new clsMedicalRecord(iD, AppointmentID, description, diagnosis, notes, creationDate, createdByUserID);
            }
            else
            {
                return null;
            }

        }

        public static bool DeleteMedicalRecord(int ID, ref string ErrorMessage)
        {
            return clsMedicalRecordData.DeleteMedicalRecord(ID, ref ErrorMessage);
        }

        public static DataTable GetSetOfMedicalRecords(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            return clsMedicalRecordData.GetSetOfMedicalRecords(PageNumber, RowsPerPage, ref ErrorMessage);
        }

        public static DataTable GetPersonMedicalRecords(string NationlNumber, int PageNumber, int RowsPerPage,
            ref string ErrorMessage)
        {
            return clsMedicalRecordData.GetPersonMedicalRecords(NationlNumber, PageNumber, RowsPerPage, ref ErrorMessage);
        }
        public static DataTable GetPersonMedicalRecordsByName(string FullName, int PageNumber, int RowsPerPage, 
            ref string ErrorMessage)
        {
            return clsMedicalRecordData.GetPersonMedicalRecordsByName(FullName, PageNumber, RowsPerPage, ref ErrorMessage);
        }

        public static DataTable GetPersonMedicalRecordsByDate(string Date, int PageNumber, int RowsPerPage,
           ref string ErrorMessage)
        {
            return clsMedicalRecordData.GetPersonMedicalRecordsByDate(Date, PageNumber, RowsPerPage, ref ErrorMessage);
        }
        public static int GetTotalMedicalRecordsNumber(ref string ErrorMessage)
        {
            return clsMedicalRecordData.GetMedicalRecordsTotalNumber(ref ErrorMessage);
        }

    }
}

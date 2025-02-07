using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClinicBusiness
{
    public class clsPrescription
    {
        private enum EnMode { Add, Edit}

        private EnMode _Mode;
        public int ID { get; set; }
        public int MedicalRecordID { get; set; }

        public string MedicationName { get; set; }

        public string Dosage {  get; set; }

        public string Frequency { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public string SpecialInstructions { get; set; }

        public clsPrescription()
        {
            ID = -1;
            MedicalRecordID = -1;
            MedicationName = string.Empty;
            Dosage = string.Empty;
            Frequency = string.Empty;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            SpecialInstructions = string.Empty;
            _Mode = EnMode.Add;
        }
        private clsPrescription(int ID, int MedicalRecordID, string MedicationName, string Dosage,
             string Frequency,  DateTime StartDate, DateTime EndDate, string SpecialInstructions)
        {
            this.ID = ID;
            this.MedicalRecordID =MedicalRecordID;
            this.MedicationName = MedicationName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SpecialInstructions = SpecialInstructions;
            _Mode = EnMode.Edit;
        }

        public clsPrescription( int MedicalRecordID, string MedicationName, string Dosage,
            string Frequency,  DateTime StartDate,  DateTime EndDate, string SpecialInstructions)
        {
            this.ID = ID;
            this.MedicalRecordID = MedicalRecordID;
            this.MedicationName = MedicationName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SpecialInstructions = SpecialInstructions;
            _Mode = EnMode.Add;
        }
        public static bool IsPrescriptionExistByID(int PrescriptionID, ref string ErrorMessage)
        {
            return clsPrescriptionData.IsPrescriptionExistByID(PrescriptionID, ref ErrorMessage);
        }
        public static bool IsPrescriptionExistByMedicalRecordID(int MedicalRecordID, ref string ErrorMessage)
        {
            return clsPrescriptionData.IsPrescriptionExistByMedicalRecordID(MedicalRecordID, ref ErrorMessage);
        }

        public static clsPrescription GetPrescriptionByID(int ID,  ref string ErrorMessage)
        {
            int medicalRecordID = -1;
            string medicationName = string.Empty;
            string dosage = string.Empty;
            string frequency = string.Empty;
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            string specialInstructions = string.Empty;
            if(clsPrescriptionData.GetPrescriptionByID(ID, ref medicalRecordID, ref medicationName, ref dosage,
            ref frequency, ref startDate, ref endDate, ref specialInstructions, ref ErrorMessage))
            {
                return new clsPrescription();
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetPrescriptionsByMedicalRecordID(int MedicalRecordID, ref string ErrorMessage)
        {
            return clsPrescriptionData.GetPrescriptionsByMedicalRecordID(MedicalRecordID, ref ErrorMessage);
        }

        public bool Save(int UserID, ref string ErrorMessage)
        {
            bool IsSaved = false;
            switch(_Mode)
            {
                case EnMode.Add:
                    int NewID = -1;
                    IsSaved = clsPrescriptionData.AddNewPrescription(ref NewID, MedicalRecordID, MedicationName, Dosage, Frequency,
                        StartDate, EndDate, SpecialInstructions, ref ErrorMessage);
                    ID = NewID;
                    _Mode = NewID > 0 ? EnMode.Edit : EnMode.Add;
                    break;
                case EnMode.Edit:
                    IsSaved = clsPrescriptionData.UpdatePrescriptionInfo(ID, MedicalRecordID, MedicationName, Dosage, Frequency,
                        StartDate, EndDate, SpecialInstructions, ref ErrorMessage);
                    break;
            }
            return IsSaved;
        }

        public static bool DeletePerscription(int ID, ref string ErrorMessage)
        {
            return clsPrescriptionData.DeletePerscription(ID, ref ErrorMessage);
        }



    }
}

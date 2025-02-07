using ClinicDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusiness
{
    public class clsPayment
    {
        private enum EnMode { Add, Edit}

        private EnMode _Mode;

        public int ID { get; set; }

        public int AppointmentID { get; set; }

        public DateTime PaymentDateTime { get; set; }   

        public string PaymentMethod { get; set; }

        public Decimal PaidAmount { get; set; }

        public string Notes { get; set; }

        public int ScheduledByUserID { get; set; }

        public clsPayment()
        {
            ID = -1;
            AppointmentID = -1;
            PaymentDateTime = DateTime.Now;
            PaymentMethod = string.Empty;
            PaidAmount = 0;
            Notes = string.Empty;
            ScheduledByUserID = -1;
            _Mode = EnMode.Add;
        }
        public clsPayment(int AppointmentID, DateTime PaymentDateTime, string PaymentMethod, Decimal PaidAmount,
          string Notes)
        {
            this.ID = -1;
            this.AppointmentID = AppointmentID;
            this.PaymentMethod = PaymentMethod;
            this.PaymentDateTime = PaymentDateTime;
            this.PaidAmount = PaidAmount;
            this.Notes = Notes;
            _Mode = EnMode.Add;
        }
        private clsPayment(int ID, int AppointmentID, DateTime PaymentDateTime, string PaymentMethod, Decimal PaidAmount,
            string Notes, int ScheduledByUserID)
        {
            this.ID = ID;
            this.AppointmentID = AppointmentID;
            this.PaymentMethod = PaymentMethod;
            this.PaymentDateTime = PaymentDateTime;
            this.PaidAmount = PaidAmount;
            this.Notes = Notes;
            this.ScheduledByUserID = ScheduledByUserID;
            _Mode = EnMode.Edit;
        }

        public static clsPayment  GetPaymentInfoByID(int ID, ref string ErrorMessage)
        {
            int appointmentID = -1;
            DateTime paymentDateTime = DateTime.Now;
            string paymentMethod = string.Empty;
            Decimal paidAmount = 0;
            string notes = string.Empty;
            int scheduledByUserID = -1;
            if(clsPaymentsData.GetPaymentInfoByID(ID, ref appointmentID, ref paymentDateTime, ref paymentMethod,
            ref paidAmount, ref notes, ref scheduledByUserID, ref ErrorMessage))
            {
               return new clsPayment(ID, appointmentID, paymentDateTime, paymentMethod, paidAmount, notes, scheduledByUserID);
            }
            else
            {
                return null;
            }
        }

        public static clsPayment GetPaymentInfoByAppointmentID(int AppointmentID, ref string ErrorMessage)
        {
            int iD = -1;
            DateTime paymentDateTime = DateTime.Now;
            string paymentMethod = string.Empty;
            Decimal paidAmount = 0;
            string notes = string.Empty;
            int scheduledByUserID = -1;
            if (clsPaymentsData.GetPaymentInfoByAppointmentID(AppointmentID, ref iD, ref paymentDateTime, ref paymentMethod,
            ref paidAmount, ref notes, ref scheduledByUserID, ref ErrorMessage))
            {
                return new clsPayment(iD, AppointmentID, paymentDateTime, paymentMethod, paidAmount, notes, scheduledByUserID);
            }
            else
            {
                return null;
            }
        }

        public bool Save(int UserID, ref string ErrorMessage)
        {
            bool IsSaved = false;
            switch (_Mode)
            {
                case EnMode.Add:
                    int NewID = -1;
                    IsSaved = clsPaymentsData.AddNewPayment(ref NewID, AppointmentID, PaymentMethod, PaidAmount, Notes,
                        UserID, ref ErrorMessage);
                    ID = NewID;
                    _Mode = IsSaved ? EnMode.Edit : EnMode.Add;
                    break;
                case EnMode.Edit:
                    IsSaved = clsPaymentsData.UpdatePaymentInfo(ID, AppointmentID, PaymentMethod, PaidAmount, Notes,
                       UserID, ref ErrorMessage);
                    break;
            }
            return IsSaved;
        }
        public static bool DeletePayment(int ID, ref string ErrorMessage)
        {
            return clsPaymentsData.DeletePayment(ID, ref ErrorMessage);
        }

        public static DataTable GetSetOfPayments(int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            return clsPaymentsData.GetSetOfPayments(PageNumber, RowsPerPage, ref ErrorMessage);  
        }

        public static DataTable GetSetOfPaymentsByName(string FullName, int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            return clsPaymentsData.GetPersonPaymentsByName(FullName, PageNumber, RowsPerPage, ref ErrorMessage);
        }

        public static DataTable GetSetOfPaymentsNationalNumber (string NationalNumber, int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            return clsPaymentsData.GetPersonPayments(NationalNumber, PageNumber, RowsPerPage, ref ErrorMessage);
        }
        public static DataTable GetSetOfPaymentsByDate(string Date, int PageNumber, int RowsPerPage, ref string ErrorMessage)
        {
            return clsPaymentsData.GetPersonPaymentsByDate(Date, PageNumber, RowsPerPage, ref ErrorMessage);
        }

        
        public static int GetPaymentsTotalNumber(ref string ErrorMessage)
        {
            return clsPaymentsData.GetPaymentsTotalNumber(ref ErrorMessage);
        }
    }
}

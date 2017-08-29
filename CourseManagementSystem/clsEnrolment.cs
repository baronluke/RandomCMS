using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    class clsEnrolment
    {
        private int enrolmentID;
        private int studentID;
        private int courseID;
        private string enrolmentDate;
        private string expectedEndDate;
        private string courseDelivery;
        private string paymentMethod;
        private string paymentDueDate;
        private double amountPaid;
        private double balanceOwing;
        private string paymentStatus;
        private bool disability;
        private string disabilityDetails;
        private string studyStatus;

        public clsEnrolment()
        {
        }

        public clsEnrolment(int enrolmentID)
        {
            this.enrolmentID = enrolmentID;
        }

        public clsEnrolment(int enrolmentID, int studentID, int courseID)
        {
            this.enrolmentID = enrolmentID;
            this.studentID = studentID;
            this.courseID = courseID;
        }

        public clsEnrolment(int enrolmentID, int studentID, int courseID, string enrolmentDate, string expectedEndDate, string courseDelivery, string paymentMethod, string paymentDueDate, double amountPaid, double balanceOwing, string paymentStatus, bool disability, string disabilityDetails, string studyStatus)
        {
            this.enrolmentID = enrolmentID;
            this.studentID = studentID;
            this.courseID = courseID;
            this.enrolmentDate = enrolmentDate;
            this.expectedEndDate = expectedEndDate;
            this.courseDelivery = courseDelivery;
            this.paymentMethod = paymentMethod;
            this.paymentDueDate = paymentDueDate;
            this.amountPaid = amountPaid;
            this.balanceOwing = balanceOwing;
            this.paymentStatus = paymentStatus;
            this.disability = disability;
            this.disabilityDetails = disabilityDetails;
            this.studyStatus = studyStatus;
        }

        public int EnrolmentID { get => enrolmentID; set => enrolmentID = value; }
        public int StudentID { get => studentID; set => studentID = value; }
        public int CourseID { get => courseID; set => courseID = value; }
        public string EnrolmentDate { get => enrolmentDate; set => enrolmentDate = value; }
        public string ExpectedEndDate { get => expectedEndDate; set => expectedEndDate = value; }
        public string CourseDelivery { get => courseDelivery; set => courseDelivery = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public string PaymentDueDate { get => paymentDueDate; set => paymentDueDate = value; }
        public double AmountPaid { get => amountPaid; set => amountPaid = value; }
        public double BalanceOwing { get => balanceOwing; set => balanceOwing = value; }
        public string PaymentStatus { get => paymentStatus; set => paymentStatus = value; }
        public bool Disability { get => disability; set => disability = value; }
        public string DisabilityDetails { get => disabilityDetails; set => disabilityDetails = value; }
        public string StudyStatus { get => studyStatus; set => studyStatus = value; }
    }
}

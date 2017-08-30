using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    class clsStudent
    {
        private int studentID;
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string gender;
        private string streetAddress;
        private string suburb;
        private string postCode;
        private string phoneNumber;
        private string email;
        private string nationality;
        private bool disability;
        private string disabilityDetails;

        public clsStudent()
        {
        }

        public clsStudent(int studentID)
        {
            this.studentID = studentID;
        }

        public clsStudent(int studentID, string firstName, string lastName)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public clsStudent(int studentID, string firstName, string lastName, string dateOfBirth, string gender, string streetAddress, string suburb, string postCode, string phoneNumber, string email, string nationality, bool disability)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.streetAddress = streetAddress;
            this.suburb = suburb;
            this.postCode = postCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.nationality = nationality;
            this.disability = disability;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string PostCode { get => postCode; set => postCode = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public bool Disability { get => disability; set => disability = value; }
        public string DisabilityDetails { get => disabilityDetails; set => disabilityDetails = value; }

        public void AddStudent(ArrayList arl)
        {
            arl.Add(this);
        }

        public void DeleteStudent(ArrayList arl)
        {
            foreach (object stu in arl)
            {
                if (((clsStudent)stu).StudentID.Equals(this.studentID))
                {
                    arl.Remove(stu);
                    break;
                }
            }
        }

        public bool SearchStudent(ArrayList arl)
        {
            bool valid = false;
            foreach (object stu in arl)
            {
                if (((clsStudent)stu).StudentID.Equals(this.studentID))
                {
                    this.studentID = ((clsStudent)stu).studentID;
                    this.firstName = ((clsStudent)stu).firstName;
                    this.lastName = ((clsStudent)stu).lastName;
                    this.dateOfBirth = ((clsStudent)stu).dateOfBirth;
                    this.gender = ((clsStudent)stu).gender;
                    this.streetAddress = ((clsStudent)stu).streetAddress;
                    this.suburb = ((clsStudent)stu).suburb;
                    this.postCode = ((clsStudent)stu).postCode;
                    this.phoneNumber = ((clsStudent)stu).phoneNumber;
                    this.email = ((clsStudent)stu).email;
                    this.nationality = ((clsStudent)stu).nationality;
                    this.disability = ((clsStudent)stu).disability;
                    this.disabilityDetails = ((clsStudent)stu).disabilityDetails;
                    valid = true;
                    break;
                }
            }

            if (valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void something()
        {

        }

        public void somethingElse()
        {

        }
    }
}

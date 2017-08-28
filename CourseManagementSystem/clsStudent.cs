using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    public class clsStudent
    {
        private int studentID;
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string gender;
        private string streetAddress;
        private string suburb;
        private int postCode;
        private int phoneNumber;
        private string email;
        private string nationality;
        private bool disability;

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

        public clsStudent(int studentID, string firstName, string lastName, string dateOfBirth, string gender, string streetAddress, string suburb, int postCode, int phoneNumber, string email, string nationality, bool disability)
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
        
    }
}

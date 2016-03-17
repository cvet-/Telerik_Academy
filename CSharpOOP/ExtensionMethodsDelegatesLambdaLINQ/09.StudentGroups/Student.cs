using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Students
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private string _fn;
        private string _phone;
        private string _email;
        private int _groupNumber;
        private List<int> _marks;
        private EmailValidator emailValidator = new EmailValidator();


        public Student(string first, string last, string fNumber, string tel, string email, List<int> allMarks, int group)
        {
            this.FirstName = first;
            this.LastName = last;
            this.FacultyNumber = fNumber;
            this.Phone = tel;
            this.Email = email;
            this.Marks = allMarks;
            this.GroupNumber = group;
        }

        public string FirstName
        {
            get { return this._firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }
                this._firstName = value;
            }
        }
        public string LastName
        {
            get { return this._lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }
                this._lastName = value;
            }

        }
        public string Phone
        {
            get { return this._phone; }
            private set
            {
                if (string.IsNullOrEmpty(value) || (value[0] != '+' && value[0] != '0'))
                {
                    throw new ArgumentException("Tel. cannot be null or empty and must start with + or 0");
                }
                this._phone = value;
            }
        }
        public string FacultyNumber
        {
            get { return this._fn; }
            set { this._fn = value; }
        }

         public string Email 
         {
            get { return this._email; }
            private set
            {
                if (!this.emailValidator.IsValidEmail(value))
                {
                    throw new ArgumentException("Invald email");
                }
                this._email = value;
            }
        }

        public int GroupNumber
        {
            get { return this._groupNumber; }
            set
            {
                if (value < 1)
                {
                    throw new ApplicationException("Group number must be a positive number");
                }

                this._groupNumber = value;
            }
        }

        public List<int> Marks
        {
            get { return new List<int>(this._marks); }
            private set { this._marks = value; }
        }
       public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nFaculty number: {2}\n" +
                                 "Group number: {3}\nMarks: {4}\nPhone: {5}\nEmail: {6}",
                this._firstName, this._lastName, this._fn, this._groupNumber,
                string.Join(", ", this._marks), this._phone, this._email);
        }
       
    }
}

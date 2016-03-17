namespace QualityMethods
{
    using System;

    public class Student
    {
        private string firstName;

        private string lastName;

        public Student(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.AdditionalInfo = string.Empty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("First name must not be null or empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Last name must not be null or empty.");
                }

                this.lastName = value;
            }
        }

        public DateTime BirthDate { get; set; }

        public string AdditionalInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = this.BirthDate;
            DateTime secondDate = other.BirthDate;
            bool firstStudentIsOlder = firstDate < secondDate;

            return firstStudentIsOlder;
        }
    }
}
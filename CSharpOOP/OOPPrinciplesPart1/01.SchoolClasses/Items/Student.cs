using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Items
{
    public class Student : Person, IDescriptionable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassNumber { get; set; }
        public string Description { get; set; }

        public Student(string firstName, string lastName, string classNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            ClassNumber = classNumber;
        }
    }
}

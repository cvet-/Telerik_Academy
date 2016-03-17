using System;
using System.Collections.Generic;
using School.Items;

namespace School.Items
{
    public class Teacher : Person, IDescriptionable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public List<Discipline> Discipline { get; set; }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Discipline = new List<Discipline>();
        }
        public void Teach(Class target, Discipline discipline)
        {
            if (!Discipline.Contains(discipline))
            {
                throw new Exception("Unable to teach discipline not in current instance discipline range.");
            }

            throw new NotImplementedException("Not implemeneted Teach method.");
        }
    }
}

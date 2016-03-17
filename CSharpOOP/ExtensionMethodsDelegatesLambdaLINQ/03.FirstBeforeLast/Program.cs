//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.

using System;
using System.Linq;

namespace _03.FirstBeforeLast
{
    class Program
    {
        static void Main()
        {
            var students = new[]
			{
				new { FirstName = "Sarah", LastName = "Manning"},
				new { FirstName = "Alison", LastName = "Hendrix"},
				new { FirstName = "Rachel", LastName = "Duncan"},
				new { FirstName = "Delphine", LastName = "Cormier"},
				new { FirstName = "Cosima", LastName = "Niehaus"},
				new { FirstName = "Beth", LastName = "Childs"},
			};
            var findStudents =
                from s in students
                where s.FirstName.CompareTo(s.LastName) == -1
                select s;
            foreach (var student in findStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}

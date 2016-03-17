using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AgeRange
{
    class Program
    {
        static void Main()
        {
            var students = new[]
			{
				new { FirstName = "Sarah", LastName = "Manning", Age = 23},
				new { FirstName = "Alison", LastName = "Hendrix", Age =26},
				new { FirstName = "Rachel", LastName = "Duncan", Age =30},
				new { FirstName = "Delphine", LastName = "Cormier", Age =20},
				new { FirstName = "Cosima", LastName = "Niehaus", Age =21},
				new { FirstName = "Beth", LastName = "Childs", Age = 29},
			};

            var studentsAgeRange =
                from s in students
                where s.Age >= 18 && s.Age <= 24
                select s;

            foreach (var student in studentsAgeRange)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}

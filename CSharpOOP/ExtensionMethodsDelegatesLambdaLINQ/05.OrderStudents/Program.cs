using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OrderStudents
{
    class Program
    {
        static void Main()
        {
            var students = new[]
			{
				new Student { FirstName = "Sarah", LastName = "Manning"},
				new Student { FirstName = "Alison", LastName = "Hendrix"},
				new Student { FirstName = "Rachel", LastName = "Duncan"},
				new Student { FirstName = "Delphine", LastName = "Cormier"},
				new Student { FirstName = "Cosima", LastName = "Niehaus"},
				new Student { FirstName = "Beth", LastName = "Childs"},

			};

            var sortedByLambda = SortWithLambda(students);
            PrintSortedStudents("Ordered with Lambda", sortedByLambda);
            Console.WriteLine();

            var sortedByLinq = SortWithLINQ(students);
            PrintSortedStudents("Ordered with Linq", sortedByLinq);

        }

        private static Student[] SortWithLINQ(IEnumerable<Student> students)
        {
            var sortedStudents =
                from s in students
                orderby s.LastName descending
                orderby s.FirstName descending
                select s;
            return sortedStudents.ToArray();
        }

        private static Student[] SortWithLambda(IEnumerable<Student> students)
        {
            return students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName).ToArray();
        }

        private static void PrintSortedStudents(string title, Student[] students)
        {
            Console.WriteLine(title);
            Console.WriteLine();

            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Students;

namespace _18_19.GroupedByGroupNumber
{
    class Program
    {
        static void Main()
        {
            StudentsTaskManager.sampleStudents.Add(
                new Student("Felix", "Dawkins", "123546", "0885421345", "felix@yahoo.com",
                    new List<int>
                    {
                       (int) Marks.Average,
                       (int) Marks.Good,
                       (int) Marks.Excellent
                    },1));
            // Problem 18. Grouped by GroupNumber (using LINQ)
            
            var groupedStudents = 
                from s in StudentsTaskManager.sampleStudents
                group s by s.GroupNumber
                into groups
                select new
                {
                    Group = groups.Key,
                    Students = groups.ToList()
                };
            Console.WriteLine("Using LINQ");
            foreach (var groupedStudent in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students:\n{1}", groupedStudent.Group,
                    string.Join("\r\n\r\n", groupedStudent.Students));
            }
            // Problem 19. Grouped by GroupName extensions

            var groupedStudentsExt = StudentsTaskManager.sampleStudents.GroupBy(s=> s.GroupNumber,
                (groupNumber, students) => 
                new { Group = groupNumber, Students = students});

            Console.WriteLine("\nUsing Extensions");
            foreach (var groupedStudent in groupedStudentsExt)
            {
                Console.WriteLine("\nGroup: {0} Students:\n{1}",
                    groupedStudent.Group, string.Join("\r\n\r\n", groupedStudent.Students));
            }
        }

    }
}

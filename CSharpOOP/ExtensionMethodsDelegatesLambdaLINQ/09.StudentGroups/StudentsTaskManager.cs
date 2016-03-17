using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
   public class StudentsTaskManager
    {
        // The solutions to all problems from 09 to 16 

        public static Student Student1 = new Student(
            "Cosima", "Niehaus", "324521", "02200200", "cos@abv.bg",
            new List<int>
                {
                    (int)Marks.Excellent, 
                    (int)Marks.Excellent, 
                    (int)Marks.Excellent, 
                    (int)Marks.Excellent
                },
                1);
        public static Student Student2 = new Student(
            "Sarah", "Manning", "000263", "0888200200", "sarah@abv.bg",
            new List<int>
                {
                    (int)Marks.Good, 
                    (int)Marks.Poor, 
                    (int)Marks.Poor, 
                    (int)Marks.Average
                }
            , 1);
        public static Student Student3 = new Student(
            "Alison", "Hendrix", "32413", "+35928200200", "youdistroyedusdonnie@mail.bg",
            new List<int>
                {
                    (int)Marks.Good, 
                    (int)Marks.Excellent, 
                    (int)Marks.Very_Good, 
                    (int)Marks.Average
                }
            , 2);

        public static Student Student4 = new Student(
            "Rachel", "Duncan", "231152", "+359882600200", "rachelD@yahoo.com",
            new List<int>
                {
                    (int)Marks.Good, 
                    (int)Marks.Poor, 
                    (int)Marks.Very_Good, 
                    (int)Marks.Average
                }
            , 2);

        public static List<Student> sampleStudents = new List<Student> { Student1, Student2, Student3, Student4 };


        static void Main()
        {
            Console.WriteLine("Print all students");

            for (int i = 1; i <= sampleStudents.Count; i++)
            {
                Console.WriteLine("Student " + i + ":\n");
                Console.WriteLine(sampleStudents[i - 1]);
                Console.WriteLine();
            }

            //problem 9
            // Select only the students from group 2

            var studentsFromGroup2 =
                from student in sampleStudents
                where student.GroupNumber == 2
                select student;

            // Order the students from group 2 by first name
            var orderedStudentsFromGroup2 =
                from student in studentsFromGroup2
                orderby student.FirstName
                select student;


            Console.WriteLine("Students from group 2, ordered by first name (using LINQ):\n");

            foreach (Student student in orderedStudentsFromGroup2)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            
            Console.WriteLine("Students from group 2, ordered by first name (using extension methods):\n");
            var orderedStudents2 = sampleStudents.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            foreach (Student student in orderedStudents2)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            // problem 11: extract all students w/ email in abv.bg using LINQ

            var studentsWithEmailsInAbv =
                from student in sampleStudents
                where student.Email.Contains("@abv.bg")
                select student;

           Console.WriteLine("Students with emails in abv.bg:\n");

           foreach (Student student in studentsWithEmailsInAbv)
           {
               Console.WriteLine(student);
               Console.WriteLine();
           }

          // problem 12: Extract all students w/ phones in Sofia, using LINQ

            var studentsWithPhonesInSofia =
                from student in sampleStudents
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592")
                select student;

            Console.WriteLine("Students with phones in Sofia:\n");

            foreach (Student student in studentsWithPhonesInSofia)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            // problem 13: Select all students that have at least one mark Excellent (6)
            // into a new anonymous class that has properties – FullName and Marks.

            var studentsWithExcellentMark =
                from student in sampleStudents
                where student.Marks.Contains((int)Marks.Excellent)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    MarksList = student.Marks
                };

            Console.WriteLine("Students that have at least one excellent mark, each in new anonymous class with " +
                              "properties Fullname and MarksList:\n");

            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }
          
            // problem 14: Write down a similar program that extracts the students with exactly two marks "2".

            var studentsWithTwoTwos = sampleStudents.Where(x => x.Marks.FindAll(y => y == 2).Count == 2).
                Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    MarksList = x.Marks
                });

            Console.WriteLine("Students that have exactly two poor marks, each in new anonymous class with " +
                              "properties Fullname and MarksList:\n");

            foreach (var student in studentsWithTwoTwos)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }

            // problem 15: Extract all Marks of the students that enrolled in 2006. 
            // (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            var studentsFrom2006 = sampleStudents.Where(x => x.FacultyNumber[4] == '0' && x.FacultyNumber[5] == '6');
            var allMarksFrom2006 = new List<int>();

            foreach (var student in studentsFrom2006)
            {
                allMarksFrom2006.AddRange(student.Marks);
            }

            Console.WriteLine("All marks of the students, enrolled in 2006:\n{0}", string.Join(", ", allMarksFrom2006));
            Console.WriteLine();

            // problem 16: 

            Group group1 = new Group(1, "Developmental evolutionary biology");
            Group group2 = new Group(2, "Science");
            Group group3 = new Group(3, "Computer Science");

            List<Group> groups = new List<Group> { group1, group2, group3 };

            var studentsFromEvoDevo =
                from someGroup in groups
                where someGroup.GroupNumber == 1
                join student in sampleStudents on someGroup.GroupNumber equals student.GroupNumber
                select new 
                {          
                    Name = student.FirstName + " " + student.LastName,
                    Department = someGroup.DepartmentName
                };

            Console.WriteLine("All students from  evo-devo, extracted as new anonymous classes," +
                              " containing properties Name and Department:");

            foreach (var student in studentsFromEvoDevo)
            {
                Console.WriteLine(student);
            }
            
        }
    }

}

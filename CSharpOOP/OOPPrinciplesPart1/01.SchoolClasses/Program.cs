using School.Items;
using System;
namespace School
{
    class School
    {
        static void Main()
        {
          
            var strudent1 = new Student("f66513", "Ivan", "Nikolov");
            var strudent2 = new Student("f12350", "Gosho", "Peshev");
            var strudent3 = new Student("f53349", "Emil", "Minkov");

            var firstAClass = new Class("123");
            firstAClass.Students.Add(strudent1);
            firstAClass.Students.Add(strudent2);
            firstAClass.Students.Add(strudent3);
            firstAClass.Description = "Brace yourself!";

            var math = new Discipline("Math") { ExercisesNumber = 20, LecturesNumber = 30 };
            var literature = new Discipline("Literature") { LecturesNumber = 50 };

            var teacher = new Teacher("Pesho", "Ivanov");
            teacher.Description = "The best in his field.";
            teacher.Discipline.Add(math);
            teacher.Discipline.Add(literature);

            var school = new Items.School("PMG");
            school.Address = "Sofia";
            school.Students.Add(strudent1);
            school.Students.Add(strudent2);
            school.Students.Add(strudent3);
            school.Teachers.Add(teacher);
            school.Classes.Add(firstAClass);
            school.Disciplines.Add(literature);
            
            Console.WriteLine(school.Name);
            Console.WriteLine(school.Address);
            Console.WriteLine("Name of discipline: {0}", math.Name);
            Console.WriteLine("Teacher's name: {0} {1}", teacher.FirstName, teacher.LastName);
            Console.WriteLine("Description of the teacher: {0}", teacher.Description);
            Console.WriteLine("Description of the discipline: {0}", firstAClass.Description);
            Console.WriteLine("Number of lectures: {0}", math.LecturesNumber);
            Console.WriteLine("Number of exercises: {0}", math.ExercisesNumber);
        }        
    }
}
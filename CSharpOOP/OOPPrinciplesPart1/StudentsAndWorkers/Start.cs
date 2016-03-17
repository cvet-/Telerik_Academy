using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Start
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student ("Cosima", "Niehaus", 10),
                new Student ("Sarah", "Manning", 7),
                new Student ("Alison", "Hendrix", 9),
                new Student ("Rachel", "Duncan", 11),
                new Student ("Helena", "X", 1),
                new Student ("Felix", "Dawkins", 5),
                new Student ("Delphine", "Cormier", 11),
                new Student ("Donnie", "Hendrix", 9),
                new Student ("Paul", "Dierden", 2),
                new Student ("Art", "Bell", 6),
            };

            var orderedStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine("Students sorted by grade:");
            foreach (var orderedStudent in orderedStudents)
            {
                orderedStudent.Print();
            }
            Console.WriteLine();
            var workers = new List<Worker>()
            {
                new Worker ("Katniss", "Everdeen", 5, 750),
                new Worker ("Peeta", "Mellark", 7, 200),
                new Worker ("Gale", "Hawthorne", 9, 150),
                new Worker ("Finnick", "Odair", 11, 500),
                new Worker ("Haymitch", "Abernathy", 7, 600),
                new Worker ("Effie", "Trinket", 5, 230),
                new Worker ("Madge", "Undersee", 3, 100),
                new Worker ("Primrose", "Everdeen", 9, 600),
                new Worker ("Alma", "Coin", 8, 730),
                new Worker ("President", "Snow", 6, 132),
            };

            var orderedWorkers = workers.OrderBy(x => x.MoneyPerHour());
            Console.WriteLine("Workers ordered by money per hour:");
            foreach (var orderedWorker in orderedWorkers)
            {
                orderedWorker.Print();
            }
            Console.WriteLine();
            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var orderedHumans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            PrintTitle("Humans sorted by name");
            foreach (var human in orderedHumans)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
        private static void PrintTitle(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine(new string('-', title.Length));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDefinition.Items;

namespace StudentDefinition
{
    class Program
    {
        static void Main()
        {
            var student1 = new Student("John", "Atanasov", "421586353");

            var studentEqual = new Student("John", "Atanasov", "421586353");
            Console.WriteLine("Different objects with the same properties are equal: {0}",student1.Equals(studentEqual));
            Console.WriteLine();

            Student student1DeepCopy = student1.Clone();
            Console.WriteLine("The copy and the original are the same: {0}", student1.Equals(student1DeepCopy));
            Console.WriteLine("The copy reference the original -> " + ReferenceEquals(student1, student1DeepCopy));
            Console.WriteLine();

            var student2 = new Student("John", "Atanasov", "421586353");
            var student3 = new Student("Peter", "Nikolov", "245124749");
            CompareStudents(student1, student2);
            CompareStudents(student1, student3);
            CompareStudents(student2, student3);
            Console.WriteLine();

            Console.WriteLine(student1.ToString());
            Console.WriteLine();

            student1.MiddleName = "Ivanov";
            student1.MobilePhone = "0885123456";
            student1.Faculty = Faculty.Bachelor;
            student1.University = University.SU;
            Console.WriteLine(student1.ToString());
            Console.WriteLine();
        }

        private static void CompareStudents(Student student1, Student student2)
        {
            Console.WriteLine("Compare: \r\n\t{0} and \r\n\t{1} \r\n\t=> {2}", student1, student2,
                              GetCompareString(student1.CompareTo(student2)));
        }
        private static string GetCompareString(int compareResult)
        {
            switch (compareResult)
            {
                case -1:
                    return "First object is before the second one.";
                case 0:
                    return "Objects are equal.";
                case 1:
                    return "Second object before the first one.";
                default:
                    return "Unknown order.";
            }
        }
    }
}

using System;

namespace PersonDefinition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Display information about a person with not specified age:");
            var person = new Person("Jane");
            Console.WriteLine(person.ToString());

            Console.WriteLine();
            Console.WriteLine("Display information about a person with specified age:");
            person.Age = 22;
            Console.WriteLine(person.ToString());
        }
    }
}

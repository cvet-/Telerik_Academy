using System;
using AnimalHierarchy.Items;

namespace AnimalHierarchy
{
    class Start
    {
        static void Main()
        {
            var animals = new Animal[]
            {
                 new Tomcat("Tom", 7.2),
					new Tomcat("Grumpy", 3.1),
					new Kitten("Sarah", 3.2), 
					new Frog("Jef", 0.7, Gender.Male), 
					new Dog("Wow", 5.3, Gender.Male), 
					new Kitten("Miko", 2.8), 
					new Frog("Mary", 4.2, Gender.Female) 
            };

            Console.WriteLine("Average age of frogs is: {0}", Animal.GetAverageAge<Frog>(animals));
            Console.WriteLine("Average age of dogs is: {0}", Animal.GetAverageAge<Dog>(animals));
            Console.WriteLine("Average age of cats is: {0}", Animal.GetAverageAge<Cat>(animals));
        }
    }
}

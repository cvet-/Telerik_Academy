﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Items
{
    class Animal : ISound
    {
        public string Name { get; set; }
        private double age;
        public Gender Gender { get; set; }
        public string Sound { get; set; }

        // Constructor
        public Animal (string name, double age, Gender gender, string sound)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Sound = sound;
        }
        // Age property
        public double Age
        {
            get { return age; }
            set
            {
                if (age < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Age cannot be a negative number");
                }
                age = value;
            }
        }
        public virtual void MakeSound()
        {
            Console.WriteLine(Sound);
        }
        // Calculate the average age of each kind of animal
        public static Double GetAverageAge<T>(IEnumerable<Animal> animals) where T : Animal
        {
            if (animals == null)
            {
                throw new ArgumentNullException("animals");
            }
            return animals.Where(x => x is T).DefaultIfEmpty().Average(x => x.Age);
        }
    }
}

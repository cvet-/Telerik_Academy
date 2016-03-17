using System;
namespace StudentsAndWorkers
{
    class Worker : Human // Inheritance
    {
        // Fields
        public int workHoursPerDay;
        public decimal weekSalary;

        // Constructor
        public Worker(string firstName, string lastName, int workHoursPerDay, decimal weekSalary)
            : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }
        // Property for WorkHoursPerDay
        public int WorkHoursPerDay 
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Working hours cannot be a negative number");
                }
                workHoursPerDay = value;
            }
        }
        // Property for WeekSalary
        public decimal WeekSalary 
        {
            get { return weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Week salary cannot be a negative number");
                }
                weekSalary = value;
            }
        }
        // Method
        public decimal MoneyPerHour()
        {
            return WeekSalary / (decimal)(7 * WorkHoursPerDay);
        }
        // Print Method
        public void Print()
        {
            Console.WriteLine("{0} {1} has ${2:0.00} salary.", FirstName, LastName, MoneyPerHour());
        }
    }
}

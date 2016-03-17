namespace QualityMethods
{
    using System;

    public class Start
    {
        public static void Main()
        {
            Console.WriteLine(MathUtilities.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(MathUtilities.NumberToDigit(5));

            Console.WriteLine(MathUtilities.FindMax(5, -1, 3, 2, 14, 2, 3));

            MathUtilities.PrintAsNumber(1.3M, "f");
            MathUtilities.PrintAsNumber(0.75M, "%");
            MathUtilities.PrintAsNumber(2.30M, "r");

            Console.WriteLine(MathUtilities.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + MathUtilities.IsHorizontal(-1, 2.5));
            Console.WriteLine("Vertical? " + MathUtilities.IsVertical(3, 3));

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17));
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3));

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
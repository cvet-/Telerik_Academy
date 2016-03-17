namespace Figures
{
    using System;

    public class Start
    {
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle);

            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine(rectangle);
        }
    }
}
namespace Figure
{
    public class Start
    {
        public static void Main()
        {
            Figure firstFigure = new Figure(5, 10.1);
            Figure rotatedFirstFigure = firstFigure.GetRotatedFigure(56.4);
        }
    }
}
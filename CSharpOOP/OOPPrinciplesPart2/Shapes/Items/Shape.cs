namespace Shapes.Items
{
    abstract class Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public abstract double CalculateSurface();
    }
}

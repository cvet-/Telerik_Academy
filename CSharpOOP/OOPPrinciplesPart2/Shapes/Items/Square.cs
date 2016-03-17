namespace Shapes.Items
{
    class Square : Shape
    {
        public Square(double width)
            : base(width, width)
        {

        }
        public override double CalculateSurface()
        {
            return Width * Width;
        }
    }
}

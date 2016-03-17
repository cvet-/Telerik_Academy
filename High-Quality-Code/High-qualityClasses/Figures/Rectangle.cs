namespace Figures
{
    using System;

    public class Rectangle : Figure
    {
        private const double MinSideLength = 0.1;

        private double width;

        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < MinSideLength)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than 0.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < MinSideLength)
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than 0.");
                }

                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
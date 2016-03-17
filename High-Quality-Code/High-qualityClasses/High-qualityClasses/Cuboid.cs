namespace Utils
{
    using System;

    public class Cuboid
    {
        private const double MinLength = 0.1;

        private double width;

        private double height;

        private double depth;

        public Cuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < MinLength)
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
                if (value < MinLength)
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than 0.");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value < MinLength)
                {
                    throw new ArgumentOutOfRangeException("Depth must be greater than 0.");
                }

                this.depth = value;
            }
        }

        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalculateDiagonalXY()
        {
            double distance = MathUtils.CalculateDistance2D(0, this.Width, 0, this.Height);
            return distance;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = MathUtils.CalculateDistance2D(0, this.Width, 0, this.Depth);
            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = MathUtils.CalculateDistance2D(0, this.Height, 0, this.Depth);
            return distance;
        }

        public double CalculateDiagonalXYZ()
        {
            double distance = MathUtils.CalculateDistance3D(0, this.Width, 0, this.Height, 0, this.Depth);
            return distance;
        }
    }
}
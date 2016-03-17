namespace Figures
{
    using System;

    public abstract class Figure
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();

        public override string ToString()
        {
            string result = "I am a " + this.GetType().Name + ". ";

            result += string.Format(
                "My perimeter is {0:F2}. My surface is {1:F2}.",
                this.CalculatePerimeter(),
                this.CalculateSurface());

            return result;
        }
    }
}
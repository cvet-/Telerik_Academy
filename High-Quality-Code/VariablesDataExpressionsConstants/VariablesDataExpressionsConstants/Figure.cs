﻿namespace Figure
{
    using System;

    public class Figure
    {
        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public Figure GetRotatedFigure(double angle)
        {
            double absoluteCosineOfAngle = Math.Abs(Math.Cos(angle));
            double absoluteSineOfAngle = Math.Abs(Math.Sin(angle));

            double widthRotatedFigure = (absoluteCosineOfAngle * this.Width) + (absoluteSineOfAngle * this.Height);
            double heightRotatedFigure = (absoluteSineOfAngle * this.Width) + (absoluteCosineOfAngle * this.Height);

            Figure rotatedFigure = new Figure(widthRotatedFigure, heightRotatedFigure);
            return rotatedFigure;
        }
    }
}
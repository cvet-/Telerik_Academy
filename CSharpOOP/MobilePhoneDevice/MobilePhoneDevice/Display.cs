﻿using System;
using System.Text;

namespace MobilePhoneDevice
{
    internal class Display
    {
        private double size;
        private decimal colorsNumber;

        //Default constructor
        public Display()
            : this(0, 0)
        {
        }

        public Display(double size, decimal colorsNumber)
        {
            Size = size;
            ColorsNumber = colorsNumber;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0.01)
                    throw new ArgumentOutOfRangeException("Size", "Size cannot be less than 0.01 inches.");

                this.size = value;
            }
        }

        public decimal ColorsNumber
        {
            get
            {
                return this.colorsNumber;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("ColorsNumber", "ColorsNumber cannot be a negative number.");

                this.colorsNumber = value;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendLine(string.Format("Size: {0} inch", Size));
            info.AppendLine(string.Format("ColorsNumber: {0}M", ColorsNumber));
            return info.ToString();
        }
    }
}
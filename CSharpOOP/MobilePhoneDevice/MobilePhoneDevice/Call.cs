﻿using System;

namespace MobilePhoneDevice
{
    internal class Call
    {
        private string dialedNumber;
        private DateTime startedTime;
        private int duration;

        public Call(DateTime startedTime, string dialedNumber)
            : this(startedTime, dialedNumber, 0)
        {
        }

        public Call(DateTime startedTime, string dialedNumber, int duration)
        {
            this.DialedNumber = dialedNumber;
            this.StartedTime = startedTime;
            this.Duration = duration;
        }

        public DateTime StartedTime
        {
            get
            {
                return startedTime;
            }
            private set
            {
                this.startedTime = value;
            }
        }

        public string DialedNumber
        {
            get
            {
                return dialedNumber;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("DialedNumber", "The number should consist of exactly 10 digits.");
                }

                foreach (var symbol in value)
                {
                    if (!char.IsDigit(symbol))
                    {
                        throw new ArgumentException("There are invalid charactes in the number.");
                    }
                }

                this.dialedNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Duration", "The duration cannot be a negative number.");

                duration = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Call on {0} to number {1} lasted {2} seconds.", StartedTime, DialedNumber, Duration);
        }
    }
}
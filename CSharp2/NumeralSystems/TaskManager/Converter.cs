// Note: Instead of making 9 different projects, I decided on making one that contains two classes.
// Class Converter contains all the methods needed to solve the problems in our assignment. 
// In class Solve I call the methods and output the wanted result.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager
{
    class Converter
    {
        /// <summary>
        ///  Method to Convert Binary to Decimal 
        /// </summary>
        /// <param name="binaryNumber"></param>
        /// <returns></returns>
        public static long BinaryToDecimal(string binaryNumber)
        {
            long decimalNumber = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int digit = binaryNumber[i] - '0';
                int position = binaryNumber.Length - i - 1;
                decimalNumber += digit * (long)Math.Pow(2, position);
            }

            return decimalNumber;
        }

        /// <summary>
        /// Method to Convert Decimal to Binary
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <returns></returns>
        public static string DecimalToBinary(long decimalNumber)
        {
            string binaryNumber = "";
            while (decimalNumber > 0)
            {
                var digit = decimalNumber % 2;
                binaryNumber = digit + binaryNumber;
                decimalNumber = decimalNumber / 2;
            }
            return binaryNumber;
        }

        /// <summary>
        /// Method to Convert Hexadecimal to Decimal
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static long HexToDecimal(string hex)
        {
            long decimalNumber = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                int digit = 0;
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    digit = hex[i] - '0';
                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    digit = hex[i] - 'A' + 10;
                }
                decimalNumber += digit * (long)Math.Pow(16, hex.Length - i - 1);
            }
            return decimalNumber;
        }

        /// <summary>
        /// Method to Convert Decimal to Hexadecimal
        /// </summary>
        /// <param name="decimalNumber"></param>
        /// <returns></returns>
        public static string DecimalToHex(long decimalNumber)
        {
            string hex = "";

            while (decimalNumber > 0)
            {
                long digit = decimalNumber % 16;

                if (digit >= 0 && digit <= 9)
                {
                    hex = (char)(digit + '0') + hex;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hex = (char)(digit - 10 + 'A') + hex;
                }
                decimalNumber /= 16;
            }

            return hex;
        }

        /// <summary>
        /// Method to Convert Hexadecimal to Binary
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static string HexToBinary(string hex)
        {
            long number = HexToDecimal(hex);
            return DecimalToBinary(number);
        }

        /// <summary>
        /// Method to Convert Binary to Hexadecinmal
        /// </summary>
        /// <param name="binary"></param>
        /// <returns></returns> 
        public static string BinaryToHex(string binary)
        {
            long number = BinaryToDecimal(binary);
            return DecimalToHex(number);
        }

        /// <summary>
        /// Shows the binary representation of given 16-bit signed integer
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string BinaryShort(short number)
        {
            return Convert.ToString(number, 2);
        }

        /// <summary>
        /// Shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string[] FloatingPoint(float number)
        {
            StringBuilder binary = new StringBuilder();
            byte[] bytes = BitConverter.GetBytes(number);
            Array.Reverse(bytes);
            string stringBytes = BitConverter.ToString(bytes);

            foreach (var item in stringBytes)
            {
                if (Char.IsLetter(item) || Char.IsDigit(item))
                {
                    binary.Append(HexToBinary(item + "").PadLeft(3, '0'));
                }
            }

            string[] result = new string[3];
            result[0] = binary[0].ToString();
            result[1] = binary.ToString().Substring(1, 8);
            result[2] = binary.ToString().Substring(9);

            return result;
        }

        /// <summary>
        ///  Converts from any numeral system of given base s to any other numeral system of base d
        /// </summary>
        /// <param name="number"></param>
        /// <param name="baseFrom"></param>
        /// <returns></returns>
        public static string FromDecimal(long d, long number)
        {
            StringBuilder result = new StringBuilder();
            long remainder;
            char currentLetter;
            while (number > 0)
            {
                remainder = number % d;

                if (remainder < 10)
                    currentLetter = (char)(remainder + '0');
                else
                    currentLetter = (char)(remainder + 55);

                result.Insert(0, currentLetter);

                number /= d;
            }
            return result.ToString();
        }

        public static long ToDecimal(string convertedNumber, long s)
        {
            long num = 0;
            byte currentValue;
            convertedNumber = convertedNumber.ToUpper();

            for (int current = 0; current < convertedNumber.Length; current++)
            {
                num *= s;

                if (Char.IsLetter(convertedNumber[current]))
                {
                    currentValue = (byte)(convertedNumber[current] - 55);
                }
                else
                {
                    currentValue = (byte)(convertedNumber[current] - '0');
                }
                num += currentValue;

            }
            return num;
        }

        public static string FromAnyToAny(string convertedNumber, long s, long d)
        {
            long num = ToDecimal(convertedNumber, s);

            if (num == 0)
                return num.ToString();

            return FromDecimal(d, num);
        }

    }
}

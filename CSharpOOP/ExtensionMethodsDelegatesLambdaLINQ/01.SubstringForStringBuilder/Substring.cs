using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SubstringForStringBuilder
{
   public static class SubstringExtention
    {
        public static StringBuilder Substring (this StringBuilder str, int index, int length)
        {
            if (str == null)
            {
                throw new ArgumentNullException("str", "Null is not a valid value for the operation.");
            }
            if (index<0)
            {
                throw new ArgumentOutOfRangeException("index", "Starting index cannot be a negative value.");
            }
            if (length<0)
            {
                throw new ArgumentOutOfRangeException("length", "Length of the string cannot be a negative value.");
            }
            if (index + length > str.Length)
            {
                throw new ArgumentOutOfRangeException("str", "Selected string is not long enought due the given method attributes");
            }
            return new StringBuilder(new string(str.ToString().ToCharArray(index, length)));
        }
    }
}

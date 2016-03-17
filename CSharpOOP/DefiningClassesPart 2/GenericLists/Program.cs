using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringCollecton = new GenericList<string>(6);
            stringCollecton.Add("T");
            stringCollecton.Add("e");
            stringCollecton.Add("l");
            stringCollecton.Add("e");
            stringCollecton.Add("r");
            stringCollecton.Add("i");
            stringCollecton.Add("k");


            //ToString method
            Console.WriteLine(stringCollecton.ToString());

            //Get count
            Console.WriteLine("Number of elements: {0}", stringCollecton.Count);

            string word = "Academy";

            //Insert element
            Console.WriteLine("Add word '{0}':", word);
            stringCollecton.InsertAt(7, word);
            Console.WriteLine(stringCollecton.ToString());

            //Remove element
            Console.WriteLine("Remove word '{0}'", word);
            stringCollecton.RemoveAt(stringCollecton.GetPosition(word));
            Console.WriteLine(stringCollecton.ToString());

            //Get element position
            Console.WriteLine("'{0}' is on {1}th position", stringCollecton[5], stringCollecton.GetPosition(stringCollecton[5]));

            //Get max
            Console.WriteLine("Max element is {0}", stringCollecton.Max());
            Console.WriteLine("Min element is {0}", stringCollecton.Min());
        }
    }
}

using System;
using System.Linq;

namespace Attributes
{
    class Program
    {
        static void Main()
        {
            Type objectType = typeof(Example);
            Version version = AttributesReader.Read<VersionAttribute>(objectType).First().Version;
            Console.WriteLine("Class {0} is version {1}.", objectType,version);
        }
    }
}

using System;
using MobilePhoneDevice;

namespace MobilePhoneDevice
{
    public static class GSMTest
    {
        public static void Start()
        {
            //Array of GSM objects
            var gsmDevices = new GSM[]
			{
				new GSM("HTC One", "HTC"),
				new GSM("Lumia", "Nokia"),
				new GSM("iPhone 4S", "Apple"),
				new GSM("Galaxy S6 Edge", "Samsung"),
				
			};

            //Display info about each object
            foreach (var gsmDevice in gsmDevices)
            {
                Console.WriteLine(gsmDevice.ToString());
            }

            //Disaply GalaxyS6 info
            Console.WriteLine(GSM.GalaxyS6.ToString());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Timer
{
    class Program
    {
        private static Timer _dateUpdateTimer;
        private static int _stopCounter;

        static void Main()
        {
           _dateUpdateTimer = new Timer(5);
			_dateUpdateTimer.Callback += Do;
			_dateUpdateTimer.Start();
			Console.WriteLine("Timer started!");
		
        }
        private static void Do()
        {
            if (_stopCounter < 3)
            {
                _stopCounter++;
            }
            else
            {
                PrintCloseMessage();
                _dateUpdateTimer.Stop();
            }
            Console.WriteLine("Current time is {0}", DateTime.Now.ToLongTimeString());
        }
        private static void PrintCloseMessage()
        {
            Console.WriteLine("GoodBye!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 2
            string name = "Tyler Israelsen";
            string location = "Chicago, IL";

            // step 3
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");

            // step 4
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"The current date is { currentDate.ToString("d")}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

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
            Console.WriteLine($"The current date is {currentDate.ToString("d")}");

            // step 5
            DateTime christmas = new DateTime(2021, 12, 25);
            double daysUntilChristmas = christmas.Subtract(DateTime.Today).TotalDays;
            Console.WriteLine($"The number of days until Christmas is {daysUntilChristmas}");

            // step 6
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Enter a width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Enter a height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

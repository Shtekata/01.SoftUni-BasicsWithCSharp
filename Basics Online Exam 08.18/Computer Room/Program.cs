using System;

namespace Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var hours = int.Parse(Console.ReadLine());
            var peoples = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();
            var price = 0.0;

            switch (month)
            {
                case "march":
                case "april":
                case "may": if (time == "day") price = 10.5; else price = 8.4; break;
                case "june":
                case "july":
                case "august": if (time == "day") price = 12.6; else price = 10.2; break; 
            }
            if (peoples > 3) price *= 0.9;
            if (hours > 4) price *= 0.5;
            var cost = peoples * price * hours;

            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {cost:f2}");
        }
    }
}

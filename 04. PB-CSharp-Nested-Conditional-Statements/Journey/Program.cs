using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer") { Console.WriteLine("Somewhere in Bulgaria"); Console.WriteLine($"Camp - {0.3 * budget:f2}"); }
                if (season == "winter") { Console.WriteLine("Somewhere in Bulgaria"); Console.WriteLine($"Hotel - {0.7 * budget:f2}"); }
            }
            else if (budget <= 1000)
            {
                if (season == "summer") { Console.WriteLine("Somewhere in Balkans"); Console.WriteLine($"Camp - {0.4 * budget:f2}"); }
                if (season == "winter") { Console.WriteLine("Somewhere in Balkans"); Console.WriteLine($"Hotel - {0.8 * budget:f2}"); }
            }
            else if (budget > 1000) { Console.WriteLine("Somewhere in Europe"); Console.WriteLine($"Hotel - {0.9 * budget:f2}"); }
        }
    }
}

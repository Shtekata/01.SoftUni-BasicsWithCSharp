using System;

namespace Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = 5;
            var nights = 5 - 1;
            var meters = 5364;
            var currentM = 0;

            while (meters < 8848)
            {
                var dOrN = Console.ReadLine();
                if (dOrN == "END") break;
                if (dOrN == "Yes") nights--;
                currentM = int.Parse(Console.ReadLine());
                if (nights < 0) break;
                meters += currentM;
            }
            if (meters >= 8848) Console.WriteLine($"Goal reached for {days-nights} days!");
            else
            { Console.WriteLine($"Failed!"); Console.WriteLine($"{meters}"); }
        }
    }
}

using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var room = Console.ReadLine();
            var rating = Console.ReadLine();

            var night = day - 1;
            var price = 0.0;
            switch (room)
            {
                case "room for one person":price = 18 * night; break;
                case "apartment":price = 25 * night; break;
                case "president apartment":price = 35 * night; break;
            }
            if (room == "apartment" && night < 10) price *= 0.7;
            else if (room == "apartment" && night <= 15) price *= 0.65;
            else if (room == "apartment" && night > 15) price *= 0.5;

            if (room == "president apartment" && night < 10) price *= 0.9;
            else if (room == "president apartment" && night <= 15) price *= 0.85;
            else if (room == "president apartment" && night > 15) price *= 0.8;

            if (rating == "positive") price *= 1.25;
            else if (rating == "negative") price *= 0.9;

            Console.WriteLine($"{price:f2}");
        }
    }
}

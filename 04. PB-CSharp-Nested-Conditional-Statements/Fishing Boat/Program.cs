using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var fishermans = int.Parse(Console.ReadLine());
            var priceForBoat = 0.0;

            switch (season)
            {
                case "Spring": priceForBoat = 3000; break;
                case "Summer":
                case "Autumn": priceForBoat = 4200; break;
                case "Winter": priceForBoat = 2600; break;
            }

            if (1 <= fishermans && fishermans <= 6) priceForBoat *= 0.9;
            else if (fishermans <= 11) priceForBoat *= 0.85;
            else priceForBoat *= 0.75;

            if (season != "Autumn" && fishermans % 2 == 0) priceForBoat *= 0.95;

            if (budget >= priceForBoat) Console.WriteLine($"Yes! You have {(budget - priceForBoat):f2} leva left.");
            else Console.WriteLine($"Not enough money! You need {(priceForBoat - budget):f2} leva.");

        }
    }
}

using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var flowers = Console.ReadLine();
            var numberOfFlowers = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());
            var price = 0.0;

            switch (flowers)
            {
                case "Roses": price = 5; if (numberOfFlowers > 80) price *= 0.9; break;
                case "Dahlias": price = 3.8; if (numberOfFlowers > 90) price *= 0.85; break;
                case "Tulips": price = 2.8; if (numberOfFlowers > 80) price *= 0.85; break;
                case "Narcissus": price = 3; if (numberOfFlowers < 120) price *= 1.15; break;
                case "Gladiolus": price = 2.5; if (numberOfFlowers < 80) price *= 1.2; break;
            }
            var priceForFlowers = numberOfFlowers * price;

            if (priceForFlowers <= budget) Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and " +
                $"{(budget - priceForFlowers):f2} leva left.");
            else Console.WriteLine($"Not enough money, you need {(priceForFlowers - budget):f2} leva more.");

        }
    }
}

using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareMeters = double.Parse(Console.ReadLine());
            var kilogramsPerSqm = double.Parse(Console.ReadLine());
            var neededLiters = int.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());

            var liters = ((squareMeters * 0.4) * kilogramsPerSqm) / 2.5;
            var difference = Math.Abs(liters - neededLiters);

            if (liters >= neededLiters)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(liters)} liters.");
                Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling(difference / numberOfWorkers)} liters per person.");
            }
            else Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");
        }
    }
}

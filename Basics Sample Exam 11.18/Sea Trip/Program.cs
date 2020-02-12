using System;

namespace Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var food = double.Parse(Console.ReadLine());
            var souvenirs = double.Parse(Console.ReadLine());
            var hotel = double.Parse(Console.ReadLine());

            var transport = 7 / 100.0 * 420 * 1.85;
            var foodSouv = 3 * (food + souvenirs);
            var overnight = 0.9 * hotel + 0.85 * hotel + 0.8 * hotel;
            var sum = transport + foodSouv + overnight;
            Console.WriteLine($"Money needed: {sum:f2}");
        }
    }
}

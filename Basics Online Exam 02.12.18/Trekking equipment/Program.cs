using System;

namespace Trekking_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbOfClimbers = int.Parse(Console.ReadLine());
            var carabiners = int.Parse(Console.ReadLine());
            var ropes = int.Parse(Console.ReadLine());
            var picelle = int.Parse(Console.ReadLine());

            var sum = 1.2*(numbOfClimbers * (carabiners * 36 + ropes * 3.6 + picelle * 19.8));
            Console.WriteLine($"{sum:f2}");
        }
    }
}

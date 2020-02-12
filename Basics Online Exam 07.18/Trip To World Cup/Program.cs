using System;

namespace Trip_To_World_Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticketIn = double.Parse(Console.ReadLine());
            var ticketOut = double.Parse(Console.ReadLine());
            var ticket = double.Parse(Console.ReadLine());
            var games = int.Parse(Console.ReadLine());
            var discount = int.Parse(Console.ReadLine());

            var sum = 6 * (ticketIn + ticketOut) * (1 - discount / 100.0) + 6 * ticket * games;

            Console.WriteLine($"Total sum: {sum:f2} lv.");
            Console.WriteLine($"Each friend has to pay {sum / 6:f2} lv.");
        }
    }
}

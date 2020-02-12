using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = int.Parse(Console.ReadLine());
            var busStops = int.Parse(Console.ReadLine());
            var inBus = 0;
            var outBus = 0;

            for (int i = 0; i < busStops; i++)
            {
                outBus = int.Parse(Console.ReadLine());
                inBus = int.Parse(Console.ReadLine());
                pass += inBus - outBus;            
            }
            if (busStops % 2 == 1) pass += 2;
            Console.WriteLine($"The final number of passenger is: {pass}.");
        }
    }
}

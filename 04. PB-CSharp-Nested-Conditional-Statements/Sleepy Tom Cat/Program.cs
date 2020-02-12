using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = int.Parse(Console.ReadLine());
            var rezult = (365 - holidays) * 63 + holidays * 127;
            if (rezult > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(rezult - 30000) / 60} hours and {(rezult - 30000) % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(30000 - rezult) / 60} hours and {(30000 - rezult) % 60} minutes less for play");
            }
        }
    }
}

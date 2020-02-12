using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var astroHeight = double.Parse(Console.ReadLine());

            var volume = width * length * height;
            var room = 2 * 2 * (astroHeight + 0.4);
            var astro = Math.Floor(volume / room);
            if (volume / room < 3) Console.WriteLine($"The spacecraft is too small.");
            else if (volume / room <= 10) Console.WriteLine($"The spacecraft holds {astro} astronauts.");
            else if (volume / room > 10) Console.WriteLine($"The spacecraft is too big.");
        }
    }
}

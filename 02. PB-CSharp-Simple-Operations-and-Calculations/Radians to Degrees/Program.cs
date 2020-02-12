using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var c = (180 / Math.PI) * r;
            Console.WriteLine(Math.Round(c,0));
        }
    }
}

using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            var f = 32 + c * 1.8000;
            Console.WriteLine(Math.Round(f,2));
        }
    }
}

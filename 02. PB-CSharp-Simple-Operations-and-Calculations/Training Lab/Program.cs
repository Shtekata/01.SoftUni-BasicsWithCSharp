using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var column = Math.Truncate((w-1)/0.7);
            var row = Math.Truncate(l / 1.2);
            var result = column * row - 3;
            Console.WriteLine(result);
        }
    }
}

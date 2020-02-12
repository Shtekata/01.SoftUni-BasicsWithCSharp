using System;

namespace Stadium_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            var sectors = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var ticket = double.Parse(Console.ReadLine());

            var profit = ticket * capacity;
            var secPr = profit / sectors;
            var charity = (profit - 0.75 * secPr) / 8;

            Console.WriteLine($"Total income - {profit:f2} BGN");
            Console.WriteLine($"Money for charity - {charity:f2} BGN");
        }
    }
}

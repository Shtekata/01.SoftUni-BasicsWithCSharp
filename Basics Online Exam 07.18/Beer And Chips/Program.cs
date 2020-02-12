using System;

namespace Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var budget = double.Parse(Console.ReadLine());
            var beers = int.Parse(Console.ReadLine());
            var snack = int.Parse(Console.ReadLine());

            var sumBeers = beers * 1.2;
            var sumSnack = Math.Ceiling(sumBeers * 0.45 * snack);
            var sum = sumBeers + sumSnack;

            if (budget >= sum) Console.WriteLine($"{name} bought a snack and has {budget-sum:f2} leva left.");
            else Console.WriteLine($"{name} needs {sum-budget:f2} more leva! ");
        }
    }
}

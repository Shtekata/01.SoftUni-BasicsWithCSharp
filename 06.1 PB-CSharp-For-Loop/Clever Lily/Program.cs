using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceOfWm = double.Parse(Console.ReadLine());
            var priceOfToy = double.Parse(Console.ReadLine());
            var sumToys = 0.0;
            var sumVm = 10;
            var sumWMBase = 0;
            var brotherGet = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1) sumToys += priceOfToy;
                else { sumWMBase += sumVm; sumVm += 10; brotherGet++; }
            }
            var sum = sumToys + sumWMBase -brotherGet;
            if (sum >= priceOfWm) Console.WriteLine($"Yes! {(sum-priceOfWm):f2}");
            else Console.WriteLine($"No! {(priceOfWm-sum):f2}");
        }
    }
}

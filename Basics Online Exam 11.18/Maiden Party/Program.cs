using System;

namespace Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceOfParty = double.Parse(Console.ReadLine());
            var loveMеssage = int.Parse(Console.ReadLine());
            var figures = int.Parse(Console.ReadLine());
            var key = int.Parse(Console.ReadLine());
            var cartoon = int.Parse(Console.ReadLine());
            var luck = int.Parse(Console.ReadLine());

            var price = 0.6 * loveMеssage + 7.2 * figures + 3.6 * key + 18.2 * cartoon + 22 * luck;
            if (loveMеssage+figures+key+cartoon+luck>=25) price *= 0.65;
            price *= 0.9;
            if (price >= priceOfParty) Console.WriteLine($"Yes! {price-priceOfParty:f2} lv left.");
            else Console.WriteLine($"Not enough money! {priceOfParty-price:f2} lv needed.");
        }
    }
}

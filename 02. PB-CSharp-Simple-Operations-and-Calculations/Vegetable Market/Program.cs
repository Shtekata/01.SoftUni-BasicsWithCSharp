using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablePrice = double.Parse(Console.ReadLine());
            var fruitsPrice = double.Parse(Console.ReadLine());
            var vegetablesVolume = int.Parse(Console.ReadLine());
            var fruitsVolume = int.Parse(Console.ReadLine());
            var vegetables = vegetablePrice * vegetablesVolume;
            var fruits = fruitsPrice * fruitsVolume;
            var price = (vegetables + fruits) / 1.94;
            Console.WriteLine(price);
        }
    }
}

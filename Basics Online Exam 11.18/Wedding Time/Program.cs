using System;

namespace Wedding_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceOfWhiskey = double.Parse(Console.ReadLine());
            var water = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var champagne = double.Parse(Console.ReadLine());
            var whiskey = double.Parse(Console.ReadLine());

            var priceOfCampagne = priceOfWhiskey * 0.5;
            var priceOfWine = priceOfCampagne * 0.4;
            var priceOfWater = priceOfCampagne * 0.1;

            var AllWhiskey = priceOfWhiskey * whiskey;
            var AllCampagne = priceOfCampagne * champagne;
            var AlleWine = priceOfWine * wine;
            var AllWater = priceOfWater * water;

            var sum = AllWhiskey + AllCampagne + AlleWine + AllWater;
            Console.WriteLine($"{sum:f2}");
        }
    }
}

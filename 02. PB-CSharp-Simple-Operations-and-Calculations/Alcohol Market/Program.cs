using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfWhiskey = double.Parse(Console.ReadLine());
            double volumeOfBeer = double.Parse(Console.ReadLine());
            double volumeOfWine = double.Parse(Console.ReadLine());
            double volumeOfRakia = double.Parse(Console.ReadLine());
            double volumeOfWhiskey = double.Parse(Console.ReadLine());
            double priceOfRakia = priceOfWhiskey / 2;
            double priceOfWine = priceOfRakia - priceOfRakia * 0.4;
            double priceOfBeer = priceOfRakia - priceOfRakia * 0.8;
            double amountOfRakia = priceOfRakia * volumeOfRakia;
            double amountOfWine = priceOfWine * volumeOfWine;
            double amountOfBeer = priceOfBeer * volumeOfBeer;
            double amountOfWhiskey = priceOfWhiskey * volumeOfWhiskey;
            double amount = amountOfRakia + amountOfWine + amountOfBeer + amountOfWhiskey;
            Console.WriteLine($"{amount:f2}");
        }
    }
}

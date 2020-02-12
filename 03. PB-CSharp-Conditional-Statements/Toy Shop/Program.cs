using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfExcursion = double.Parse(Console.ReadLine());
            int numberOfPuzzle = int.Parse(Console.ReadLine());
            int numberOfDoll = int.Parse(Console.ReadLine());
            int numberOfBear = int.Parse(Console.ReadLine());
            int numberOfMinion = int.Parse(Console.ReadLine());
            int numberOfTruck = int.Parse(Console.ReadLine());

            double priceOfPuzzle = 2.6;
            double priceOfDoll = 3;
            double priceOfBear = 4.1;
            double priceOfMinion = 8.2;
            double priceOfTruck = 2;

            double number = numberOfPuzzle + numberOfDoll + numberOfBear + numberOfMinion + numberOfTruck;
            double sumOfSale = numberOfPuzzle * priceOfPuzzle + numberOfDoll * priceOfDoll + numberOfBear * priceOfBear + numberOfMinion * priceOfMinion + numberOfTruck * priceOfTruck;
            if (number >= 50)
            {
                sumOfSale -= sumOfSale * 0.25;
            }
            sumOfSale -= sumOfSale * 0.1;
            if (sumOfSale >= priceOfExcursion)
            {
                Console.WriteLine($"Yes! {sumOfSale-priceOfExcursion:f2} lv left.");
            }
            else Console.WriteLine($"Not enough money! { priceOfExcursion-sumOfSale:f2} lv needed.");
        }
    }
}

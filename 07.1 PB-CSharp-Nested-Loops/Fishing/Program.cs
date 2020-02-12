using System;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfFish = int.Parse(Console.ReadLine());
            var number = 1;
            var sum = 0.0;
            var money = 0.0;
            var sumMoney = 0.0;
            while (number <= numberOfFish)
            {
                var fish = Console.ReadLine();
                if (fish == "Stop") break;
                var kgOfFish = double.Parse(Console.ReadLine());
                for (int i = 0; i < fish.Length; i++)
                {
                    char now = fish[i];
                    sum += now;
                }
                money = sum / kgOfFish;
                if (number % 3 == 0 && number != 1 && number !=0) money = -money;
                sumMoney += money;
                number++;
                sum = 0.0;
            }
            if (number >= numberOfFish) Console.WriteLine($"Lyubo fulfilled the quota!");
            if (sumMoney <= 0) Console.WriteLine($"Lyubo's profit from {number-1} fishes is {Math.Abs(sumMoney):f2} leva.");
            else Console.WriteLine($"Lyubo lost {sumMoney:f2} leva today.");
        }
    }
}

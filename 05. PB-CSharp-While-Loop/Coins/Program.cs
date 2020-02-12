using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = decimal.Parse(Console.ReadLine());
            coins = coins * 100;
            var number = 0;

            while (coins > 0)
            {
                if (coins >= 200) { number++; coins -= 200; }
                else if (coins >= 100) { number++; coins -= 100; }
                else if (coins >= 50) { number++; coins -= 50; }
                else if (coins >= 20) { number++; coins -= 20; }
                else if (coins >= 10) { number++; coins -= 10; }
                else if (coins >= 5) { number++; coins -= 5; }
                else if (coins >= 2) { number++; coins -= 2; }
                else if (coins >= 1) { number++; coins -= 2; }
            }
            Console.WriteLine(number);
        }
    }
}

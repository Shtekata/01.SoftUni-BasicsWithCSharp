using System;

namespace Going_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var outgo = int.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var money = int.Parse(Console.ReadLine());

            var cost = outgo / 100.0 * distance * price;

            if (money >= cost) Console.WriteLine($"You can go home. {money-cost:f2} money left.");
            else Console.WriteLine($"Sorry, you cannot go home. Each will receive {money/5.0:f2} money.");
        }
    }
}

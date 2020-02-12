using System;

namespace Fan_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            var number = int.Parse(Console.ReadLine());
            var price = 0;

            for (int i = 0; i < number; i++)
            {
                var kind = Console.ReadLine();
                switch (kind)
                {
                    case "hoodie":price += 30;break;
                    case "keychain":price += 4;break;
                    case "T-shirt":price += 20;break;
                    case "flag":price += 15;break;
                    case "sticker":price += 1;break;
                }
            }
            if (budget >= price) Console.WriteLine($"You bought {number} items and left with {budget-price} lv.");
            else Console.WriteLine($"Not enough money, you need {price-budget} more lv.");
        }
    }
}

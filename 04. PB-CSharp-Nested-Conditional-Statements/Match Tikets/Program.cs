using System;

namespace Match_Tikets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int People = int.Parse(Console.ReadLine());

            double priceOfTicket = category == "VIP" ? 499.99 : 249.99;

            if (1 <= People && People <= 4) budget *= 0.25;
            else if (4 < People && People <= 9) budget *= 0.4;
            else if (9 < People && People <= 24) budget *= 0.5;
            else if (24 < People && People <= 49) budget *= 0.6;
            else budget *= 0.75;

            double moneyForTickets = People * priceOfTicket;
            double left = Math.Abs(budget - moneyForTickets);

            if (moneyForTickets <= budget) Console.WriteLine($"Yes! You have {left:F2} leva left.");
            else Console.WriteLine($"Not enough money! You need {left:F2} leva.");
        }
    }
}

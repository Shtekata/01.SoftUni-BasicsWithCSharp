using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakesNumber = int.Parse(Console.ReadLine());
            int wafersNumber = int.Parse(Console.ReadLine());
            int pancakesNumber = int.Parse(Console.ReadLine());
            double cakes = cakesNumber * 45;
            double wafers = wafersNumber * 5.8;
            double pancakes = pancakesNumber * 3.2;
            double amountOfTheDay = (cakes + wafers + pancakes)*confectioners;
            double campaignAmount = amountOfTheDay * days;
            double amount = campaignAmount - campaignAmount / 8;
            Console.WriteLine($"{amount:f2}");
        }
    }
}

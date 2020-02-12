using System;

namespace Honeymoon
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var city = Console.ReadLine();
            var numberOfNights = int.Parse(Console.ReadLine());

            var cairo = numberOfNights * 500.0 + 600;
            var paris = numberOfNights * 300.0 + 350;
            var lima = numberOfNights * 800.0 + 850;
            var newYork = numberOfNights * 600.0 + 650;
            var tokyo = numberOfNights * 700.0 + 700;

            var traveling = true;

            if (numberOfNights < 5) { cairo *= 0.97; newYork *= 0.97; }
            else if (numberOfNights < 10) { cairo *= 0.95; newYork *= 0.95; paris *= 0.93; }
            else if (numberOfNights < 25) { cairo *= 0.9; paris *= 0.88; newYork *= 0.88; tokyo *= 0.88; }
            else if (numberOfNights < 50) { tokyo *= 0.83; cairo *= 0.83; newYork *= 0.81; lima *= 0.81; paris *= 0.78; }
            else { cairo *= 0.7; paris *= 0.7; lima *= 0.7; newYork *= 0.7; tokyo *= 0.7; }

            var money = 0.0;
            var moneyCairo = Math.Abs(budget - cairo);
            var moneyParis = Math.Abs(budget - paris);
            var moneyLima = Math.Abs(budget - lima);
            var moneyNewYork = Math.Abs(budget - newYork);
            var moneyTokyo = Math.Abs(budget - tokyo);

            if (city == "Cairo") { money = moneyCairo; if (cairo > budget) traveling = false; }
            if (city == "Paris") { money = moneyParis; if (paris > budget) traveling = false; }
            if (city == "Lima") { money = moneyLima; if (lima > budget) traveling = false; }
            if (city == "New York") { money = moneyNewYork; if (newYork > budget) traveling = false; }
            if (city == "Tokyo") { money = moneyTokyo; if (tokyo > budget) traveling = false; }

            if (traveling) Console.WriteLine($"Yes! You have {money:f2} leva left.");
            else Console.WriteLine($"Not enough money! You need {money:f2} leva.");
        }
    }
}

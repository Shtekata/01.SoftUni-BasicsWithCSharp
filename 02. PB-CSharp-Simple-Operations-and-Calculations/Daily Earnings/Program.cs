using System;

namespace Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var cashMoney = double.Parse(Console.ReadLine());
            var rateOfTheDolar = double.Parse(Console.ReadLine());

            var MontlyProfit = workingDays * cashMoney;
            var AnnualProfit = MontlyProfit * 12;
            AnnualProfit += MontlyProfit * 2.5;
            AnnualProfit -= AnnualProfit * 25 / 100;
            var DailyProfit = AnnualProfit / 365 * rateOfTheDolar;

            Console.WriteLine($"{DailyProfit:f2}");
        }
    }
}

using System;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var currency1 = Console.ReadLine();
            var currency2 = Console.ReadLine();
            var rate1 = 0.0m;
            var rate2 = 0.0m;
            if (currency1 == "BGN")
            {
                rate1 = 1;
            }
            else if (currency1 == "USD")
            {
                rate1 = 1.79549m;
            }
            else if (currency1 == "EUR")
            {
                rate1 = 1.95583m;
            }
            else if (currency1 == "GBP")
            {
                rate1 = 2.53405m;
            }
            if (currency2 == "BGN")
            {
                rate2 = 1;
            }
            else if (currency2 == "USD")
            {
                rate2 = 1.79549m;
            }
            else if (currency2 == "EUR")
            {
                rate2 = 1.95583m;
            }
            else if (currency2 == "GBP")
            {
                rate2 = 2.53405m;
            }
            var result = money * rate1 / rate2;
            Console.WriteLine("{0} {1}",Math.Round(result,2),currency2);
        }
    }
}

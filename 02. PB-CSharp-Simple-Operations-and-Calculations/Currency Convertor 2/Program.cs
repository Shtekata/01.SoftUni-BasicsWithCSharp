using System;

namespace Currency_Convertor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string currency = Console.ReadLine();
            string endCurrency = Console.ReadLine();

            if (currency == "USD")
            {
                money = money * 1.79549;
            }
            else if (currency == "EUR")
            {
                money = money * 1.95583;
            }
            else if (currency == "GBP")
            {
                money = money * 2.53405;        
            }

            if (endCurrency == "USD")
            {
                money = money / 1.79549;
            }
            else if (endCurrency == "EUR")
            {
                money = money / 1.95583;
            }
            else if (endCurrency == "GBP")
            {
                money = money / 2.53405;
            }

            Console.WriteLine($"{money:F2}");
        }
    }
}

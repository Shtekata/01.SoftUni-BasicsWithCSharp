using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int days = 0;

            while (true)
            {
                string kindOfExpense = Console.ReadLine();
                double moneyInOut = double.Parse(Console.ReadLine());
                days++;

                if (kindOfExpense == "spend")
                {
                    availableMoney -= moneyInOut;
                    spendCounter++;
                    if (moneyInOut >= availableMoney) availableMoney = 0;
                    if (spendCounter == 5) { Console.WriteLine($"You can't save the money."); Console.WriteLine(days); break; }
                    
                }
                if (kindOfExpense == "save")
                {
                    spendCounter = 0;
                    availableMoney += moneyInOut;
                    if (availableMoney >= neededMoney) { Console.WriteLine($"You saved the money for {days} days."); break; }
                }
            }
        }
    }
}

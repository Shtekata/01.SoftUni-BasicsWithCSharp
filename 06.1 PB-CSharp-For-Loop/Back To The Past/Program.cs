using System;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            for (int i = 0; i <= year-1800; i++)
            {
                if (i%2!=0)
                {
                    money -= 12000 + 50 * (i + 18);
                }
                else
                {
                    money -= 12000;
                }
            }
            if (money >= 0) Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            else Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
        }
    }
}

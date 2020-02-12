using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var bonus = 0.0;
            var points = int.Parse(Console.ReadLine());
            if (points <= 100)
            {
                bonus += 5;
            }
            else
            {
                if (points <=1000)
                {
                    bonus += points * 0.2;
                }
                else
                {
                    bonus += points * 0.1;
                }
            }
            if (points % 2 == 0)
            {
                bonus += 1;
            }
            if (points % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus+points);
        }
    }
}

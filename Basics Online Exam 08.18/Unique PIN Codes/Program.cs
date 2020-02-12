using System;

namespace Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());

            if (number1 > 0 && number1 < 10 && number2 > 0 && number2 < 10 & number3 > 0 && number3 < 10)
            {
                for (int k = 2; k <= number1; k++)
                {
                    if (k % 2 == 0)
                    {
                        for (int i = 2; i <= number2; i++)
                        {
                            for (int j = 2; j <= i; j++)
                            {
                                if (i % j == 0 && i != 2 && i != j)
                                {
                                    break;
                                }
                                else if (j == i)
                                {
                                    for (int l = 2; l <= number3; l++)
                                    {
                                        if (l % 2 == 0)
                                        {
                                            Console.WriteLine($"{k} {i} {l}");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

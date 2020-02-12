using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            for (int n = number1; n <= number2; n++)
            {
                var even = 0;
                var odd = 0;
                var currentNumber = n;
                for (int i = 0; i < 6; i++)
                {
                    if (i % 2 == 0) even += currentNumber % 10;
                    else odd += currentNumber % 10;
                    currentNumber /= 10;
                }
                if (even == odd) Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
    }
}

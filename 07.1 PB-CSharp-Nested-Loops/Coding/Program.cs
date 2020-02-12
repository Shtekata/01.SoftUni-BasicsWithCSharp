using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var numberLength = number.ToString().Length;

            for (int i = 0; i < numberLength; i++)
            {
                var currentNumber = number % 10;
                if (currentNumber == 0) Console.Write("ZERO");
                else
                {
                    for (int c = 0; c < currentNumber; c++)
                    {
                        char symbol = (char)(currentNumber + 33);
                        Console.Write($"{symbol}");
                    }
                }
                number /= 10;
                Console.WriteLine();
            }
        }
    }
}

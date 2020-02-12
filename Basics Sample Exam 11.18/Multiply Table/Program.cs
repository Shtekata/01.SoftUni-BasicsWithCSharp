using System;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var number1 = number % 10;
            number = number / 10;
            var number2 = number % 10;
            number = number / 10;


            for (int i = 1; i <= number1; i++)
            {
                for (int j = 1; j <= number2; j++)
                {
                    for (int k = 1; k <= number; k++)
                    {
                        var multiply = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {multiply};");
                    }
                }
            }
        }
    }
}

using System;

namespace Equal_Sums_Left_Right_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
            {
                var current1 = i % 10;
                var current2 = i / 10 % 10;
                var current3 = i / 100 % 10;
                var current4 = i / 1000 % 10;
                var current5 = i / 10000 % 10;

                var left = current1 + current2;
                var right = current4 + current5;

                if (left == right || left == current3 + right || left + current3 == right) Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}

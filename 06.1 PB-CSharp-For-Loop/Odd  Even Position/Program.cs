using System;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());

            var sumOdd = 0.0;
            var minOdd = double.MaxValue;
            var maxOdd = double.MinValue;
            var sumEven = 0.0;
            var minEven = double.MaxValue;
            var maxEven = double.MinValue;

            for (int i = 1; i <= number; i++)
            {
                var input = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += input;
                    if (input > maxEven) maxEven = input;
                    if (input < minEven) minEven = input;
                }
                else
                {
                    sumOdd += input;
                    if (input > maxOdd) maxOdd = input;
                    if (input < minOdd) minOdd = input;
                }
            }
            Console.WriteLine($"OddSum = {sumOdd}");
            if (minOdd != double.MaxValue) Console.WriteLine($"OddMin = {minOdd}"); else Console.WriteLine("OddMin = No");
            if (maxOdd != double.MinValue) Console.WriteLine($"OddMax = {maxOdd}"); else Console.WriteLine("OddMax = No");
            Console.WriteLine($"EvenSum = {sumEven}");
            if (minEven != double.MaxValue) Console.WriteLine($"EvenMin = {minEven}"); else Console.WriteLine("EvenMin = No");
            if (maxEven != double.MinValue) Console.WriteLine($"EvenMax = {maxEven}"); else Console.WriteLine("EvenMax = No");
        }
    }
}

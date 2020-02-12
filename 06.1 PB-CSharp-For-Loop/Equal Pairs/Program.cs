using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var numberFirst = double.Parse(Console.ReadLine());
            var numberDouble = double.Parse(Console.ReadLine());
            var oldSum = numberFirst + numberDouble;
            var difference = 0.0;
            var maxDifference = 0.0;
            for (int i = 0; i < number - 1; i++)
            {
                var number1 = double.Parse(Console.ReadLine());
                var number2 = double.Parse(Console.ReadLine());
                var sum = number1 + number2;
                if (sum > 0 && oldSum > 0 || sum < 0 && oldSum < 0) difference = sum - oldSum;
                else difference = Math.Abs(sum) + Math.Abs(oldSum);
                if (difference > maxDifference) maxDifference = difference;
                oldSum = sum;
            }
            if (difference == 0) Console.WriteLine($"Yes, value={oldSum}");
            else Console.WriteLine($"No, maxdiff={maxDifference}");
        }
    }
}

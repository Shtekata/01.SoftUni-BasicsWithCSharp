using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var maxNumber = int.Parse(Console.ReadLine());
            var sum = maxNumber;

            for (int i=1; i<number; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber > maxNumber) maxNumber = currentNumber;
            }
            if (maxNumber == sum / 2.0)
            { Console.WriteLine("Yes"); Console.WriteLine($"Sum = {maxNumber}"); }
            else
            { Console.WriteLine("No"); Console.WriteLine($"Diff = {Math.Abs(maxNumber-(sum-maxNumber))}"); }
        }
    }
}

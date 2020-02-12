using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var firstSum = 0;
            var secondSum = 0;
            for (int i = 0; i < number; i++)
            {
                firstSum += int.Parse(Console.ReadLine());
            }
            for (int a = 0; a < number; a++)
            {
                secondSum += int.Parse(Console.ReadLine());
            }
            if (firstSum == secondSum) Console.WriteLine($"Yes, sum = {firstSum}");
            else Console.WriteLine($"No, diff = {Math.Abs(firstSum-secondSum)}");
        }
    }
}

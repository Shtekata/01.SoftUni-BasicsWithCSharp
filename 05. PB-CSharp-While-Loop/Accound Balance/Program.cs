using System;

namespace Accound_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfSum = double.Parse(Console.ReadLine());
            var finalSum = 0.0;
            var sum = 0.0;
            var number = 0;
            while (number<numberOfSum)
            {
                if (sum<0)
                {
                    Console.WriteLine($"Invalid operation!");
                    Console.WriteLine($"Total: {finalSum:f2}");
                    break;
                }
                sum = double.Parse(Console.ReadLine());
                if (sum >= 0) finalSum += sum;
                if (sum >= 0) Console.WriteLine($"Increase: {sum:f2}");
                number++;
            }
            if(sum>=0) Console.WriteLine($"Total: {finalSum:f2}");
        }
    }
}

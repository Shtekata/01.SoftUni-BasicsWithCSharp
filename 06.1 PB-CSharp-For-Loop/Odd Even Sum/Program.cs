using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var odd = 0;
            var even = 0;
            for (int i = 0; i < number; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (i % 2 == 0) even += input;
                else odd += input;
            }
            if (even == odd)
            { Console.WriteLine("Yes"); Console.WriteLine($"Sum = {even}"); }
            else { Console.WriteLine("No"); Console.WriteLine($"Diff = {Math.Abs(even - odd)}"); }
        }
    }
}

using System;

namespace Divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;

            for (int i = 1; i <= number; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0) p2++;
                if (input % 3 == 0) p3++;
                if (input % 4 == 0) p4++;
            }
            var p2p = p2 / number * 100;
            var p3p = p3 / number * 100;
            var p4p = p4 / number * 100;

            Console.WriteLine($"{p2p:f2}%");
            Console.WriteLine($"{p3p:f2}%");
            Console.WriteLine($"{p4p:f2}%");
        }
    }
}

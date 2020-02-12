using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int r = 0; r <= n-1; r++)
            {
                if (r == 0 || r == n - 1)
                {
                    Console.Write(new string('*', 2 * n));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', 2 * n));
                }
                else
                {
                    Console.Write($"*{new string('/', 2 * n - 2)}*");
                    if (r == (n - 1) / 2) Console.Write(new string('|', n));
                    else Console.Write(new string(' ', n));
                    Console.Write($"*{new string('/', 2 * n - 2)}*");
                }
                Console.WriteLine();

            }
        }
    }
}

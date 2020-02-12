using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var row = (n + 1) / 2;
            var stars = 1;
            if (n % 2 == 0) { row = n / 2; stars = 2; }
            var spaces = (n - stars) / 2;
            if (n % 2 == 0) Console.WriteLine($"{new string('-', spaces)}**{new string('-', spaces)}");
            else Console.WriteLine($"{new string('-', spaces)}*{new string('-', spaces)}");
            for (int r = 0; r < row - 1; r++)
            {
                Console.WriteLine($"{new string('-', spaces - r - 1)}*{new string('-', n - (spaces - r - 1) * 2 - 2)}*{new string('-', spaces - r - 1)}");
            }
            for (int r = 0; r < row - 2; r++)
            {
                Console.WriteLine($"{new string('-', r + 1)}*{new string('-', n - (r + 1) * 2 - 2)}*{new string('-', r + 1)}");
            }
            if (n != 1 && n != 2)
            {
                if (n % 2 == 0) Console.WriteLine($"{new string('-', spaces)}**{new string('-', spaces)}");
                else Console.WriteLine($"{new string('-', spaces)}*{new string('-', spaces)}");
            }
        }
    }
}

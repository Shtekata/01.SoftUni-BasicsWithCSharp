using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var r = (n + 1) / 2;
            for (int i = 0; i < r; i++)
            {
                Console.Write(new string('-', r - i-1));
                Console.Write(new string('*', i));
                if (n % 2 == 0) { Console.Write("**"); }
                else Console.Write("*");
                Console.Write(new string('*', i));
                Console.Write(new string('-', r - i-1));
                Console.WriteLine();

            }
            for (int c = 0; c < n/2; c++)
            {
                Console.WriteLine($"|{new string('*',n-2)}|");
            }
        }
    }
}

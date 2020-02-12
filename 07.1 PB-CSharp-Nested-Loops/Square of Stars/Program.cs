using System;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int r = 0; r < n; r++)
            {
                Console.Write("*");
                for (int c = 1; c < n; c++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}

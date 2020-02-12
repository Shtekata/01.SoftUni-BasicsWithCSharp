using System;

namespace Callenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            var men = int.Parse(Console.ReadLine());
            var women = int.Parse(Console.ReadLine());
            var tables = int.Parse(Console.ReadLine());
            var n = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    if (n == tables) break;
                    Console.Write($"({i} <-> {j}) ");
                    n++;
                }
            }
            Console.WriteLine();
        }
    }
}

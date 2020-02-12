using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            var floors = int.Parse(Console.ReadLine());
            var rooms = int.Parse(Console.ReadLine());
            for (int i = 0; i < rooms; i++)
            {
                Console.Write($"L{floors}{i} ");
            }
            Console.WriteLine();
            for (int j = floors-1; j >= 1; j--)
            {
                for (int k = 0; k < rooms; k++)
                {
                    if (j % 2 == 1) Console.Write($"A{j}{k} ");
                    else Console.Write($"O{j}{k} ");
                }
                Console.WriteLine();
            }
        }
    }
}

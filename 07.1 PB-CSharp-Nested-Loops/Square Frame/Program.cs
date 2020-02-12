using System;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int r = 0; r < n; r++)
            {
                if (r == 0 || r == n - 1)
                {
                    Console.Write("+");
                    for (int c = 0; c < n - 2; c++) { Console.Write(" -"); }
                    Console.Write(" +");
                }

                else
                {
                    Console.Write("|");
                    for (int c1 = 0; c1 < n - 2; c1++) { Console.Write(" -"); }
                    Console.Write(" |");  
                }
                Console.WriteLine();
            }
        }
    }
}

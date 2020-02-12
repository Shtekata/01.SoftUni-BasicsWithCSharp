using System;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            var spaces = n;
            for (int r = 0; r < n; r++)
            {
                Console.Write(new string(' ',spaces-1));
                for (int i = 0; i < stars; i++) Console.Write("* ");
                Console.WriteLine();
                spaces--;
                stars++;
            }
            for (int r = 0; r < n-1; r++)
            {
                Console.Write(new string(' ', spaces+1));
                for (int i = 0; i < stars-2; i++) Console.Write("* ");
                Console.WriteLine();
                spaces++;
                stars--;
            }
        }
    }
}

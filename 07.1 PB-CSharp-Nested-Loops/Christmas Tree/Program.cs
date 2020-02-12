using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());

            for (int row = 0; row <= numb; row++)
            {
                for (int col = 0; col < numb-row; col++)
                {
                    Console.Write(" ");
                }
                for (int col2 = 0; col2 < row; col2++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int col2 = 0; col2 < row; col2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

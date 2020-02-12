using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var currentNumber = 1;
            var row = 1;

            while (true)
            {
                for (int r = 0; r < row; r++)
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                    if (currentNumber > number) { Console.WriteLine(); return; }
                }
                row++;
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var row = 1;
            var currentNumber1 = 1;
            var currentNumber2 = number-1;
            var a = 1;
            var b = 1;

            for (int r = 1; r <= number; r++)
            {
                for (int c = a; c <= number; c++)
                {
                    Console.Write($"{currentNumber1} ");
                    currentNumber1++;
                }
                currentNumber1 = r + 1;
                a++;

               for (int i = b; i > 1; i--)
               {
                   Console.Write($"{currentNumber2} ");
                   currentNumber2--;
               }
               currentNumber2 = number - 1;
               b++;
               Console.WriteLine();
            }
        }
    }
}

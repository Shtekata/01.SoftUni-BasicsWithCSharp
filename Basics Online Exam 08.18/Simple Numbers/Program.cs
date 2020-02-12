using System;

namespace Simple_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && i != 2 && i != j)
                    {
                        break;
                    }
                    else if (j == i) Console.Write($"{j} ");
                }
            }
            Console.WriteLine();
        }
    }
}

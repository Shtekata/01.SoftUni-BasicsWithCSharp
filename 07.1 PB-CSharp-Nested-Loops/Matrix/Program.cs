using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = c; k <= d; k++)
                    {
                        for (int l = c; l <= d; l++)
                        {
                            if (i + l == j + k && i != j && k != l)
                            {
                                Console.WriteLine($"{i}{j}");
                                Console.WriteLine($"{k}{l}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}

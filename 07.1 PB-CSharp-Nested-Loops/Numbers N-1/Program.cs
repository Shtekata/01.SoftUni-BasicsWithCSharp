using System;

namespace Numbers_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

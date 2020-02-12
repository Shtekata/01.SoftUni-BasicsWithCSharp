using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            for (int i=1; i<number; i++)
            {
                int next = int.Parse(Console.ReadLine());
                if (next < min) min = next;
            }
            Console.WriteLine(min);
        }
    }
}

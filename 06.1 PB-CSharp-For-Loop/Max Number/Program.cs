using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                var next = int.Parse(Console.ReadLine());
                if (max < next) max = next;
            }
            Console.WriteLine(max);
        }
    }
}

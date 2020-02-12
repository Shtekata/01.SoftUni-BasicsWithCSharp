using System;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var even = int.Parse(Console.ReadLine());
            for (int i = 0; i <= even; i+=2)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}

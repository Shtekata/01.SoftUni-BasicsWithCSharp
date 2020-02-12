using System;

namespace Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(new string('*',number));
            }
        }
    }
}

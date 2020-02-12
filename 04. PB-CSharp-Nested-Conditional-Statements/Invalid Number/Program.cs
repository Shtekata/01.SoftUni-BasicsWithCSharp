using System;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int isValid = int.Parse(Console.ReadLine());
            if (!((isValid >= 100 && isValid <= 200) || isValid == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

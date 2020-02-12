using System;

namespace Number_in_Range__1_100_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter a number in the range [1...100]: ");
            var number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine($"Invalid number!");
                Console.Write($"Enter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
            }
        Console.WriteLine($"The number is: {number}");
        }
    }
}

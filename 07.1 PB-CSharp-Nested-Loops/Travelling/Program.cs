using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var currentSum = 0.0;
                var neededSum = 0.0;

                var destination = Console.ReadLine();
                if (destination == "End") break;

                neededSum += double.Parse(Console.ReadLine());
                while (currentSum<neededSum)
                {
                    var input = Console.ReadLine();
                    if (input == "End") return;
                    currentSum += double.Parse(input);
                }
     
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}

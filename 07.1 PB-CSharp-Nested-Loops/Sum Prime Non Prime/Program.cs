using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var primeNumbers = 0;
            var nonPrimeNumbers = 0;
            bool variable = false;

            while (input != "stop")
            {
                var number = int.Parse(input);
                if (number < 0) Console.WriteLine("Number is negative.");
                else if (number != 0 && number != 1)
                {
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0) { variable = true; }
                    }
                    if (variable) nonPrimeNumbers += number;
                    else primeNumbers += number;
                    variable = false;
                }
                else nonPrimeNumbers += number;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbers}");
        }
    }
}

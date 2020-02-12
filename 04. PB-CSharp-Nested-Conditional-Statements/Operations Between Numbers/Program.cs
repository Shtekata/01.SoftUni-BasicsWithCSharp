using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = double.Parse(Console.ReadLine());
            var numberTwo = double.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();
            var result = 0.0;

            if (symbol == "/")
            {
                if (numberTwo != 0)
                    Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo:f2}");
                else Console.WriteLine($"Cannot divide {numberOne} by zero");
            }
            else if (symbol == "%")
            {
                if (numberTwo != 0)
                    Console.WriteLine($"{numberOne} % {numberTwo} = {numberOne % numberTwo}");
                else Console.WriteLine($"Cannot divide {numberOne} by zero");
            }
            else
            {
                if (symbol == "+") result = numberOne + numberTwo;

                if (symbol == "-") result = numberOne - numberTwo;

                if (symbol == "*") result = numberOne * numberTwo;

                Console.Write($"{numberOne} {symbol} {numberTwo} = {result} - ");
                Console.WriteLine(result % 2 == 0 ? "even" : "odd");
            }
        }
    }
}

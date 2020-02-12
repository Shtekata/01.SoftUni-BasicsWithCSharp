using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string kind = Console.ReadLine();
            string town = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            if (kind == "coffee")
            {
                if (town == "Sofia") Console.WriteLine(number * 0.5);
                else if (town == "Plovdiv") Console.WriteLine(number * 0.4);
                else if (town == "Varna") Console.WriteLine(number * 0.45);
            }
            else if (kind == "water")
            {
                if (town == "Sofia") Console.WriteLine(number * 0.8);
                else if (town == "Plovdiv") Console.WriteLine(number * 0.7);
                else if (town == "Varna") Console.WriteLine(number * 0.7);
            }
            else if (kind == "beer")
            {
                if (town == "Sofia") Console.WriteLine(number * 1.2);
                else if (town == "Plovdiv") Console.WriteLine(number * 1.15);
                else if (town == "Varna") Console.WriteLine(number * 1.1);
            }
            else if (kind == "sweets")
            {
                if (town == "Sofia") Console.WriteLine(number * 1.45);
                else if (town == "Plovdiv") Console.WriteLine(number * 1.30);
                else if (town == "Varna") Console.WriteLine(number * 1.35);
            }
            else if (kind == "peanuts")
            {
                if (town == "Sofia") Console.WriteLine(number * 1.60);
                else if (town == "Plovdiv") Console.WriteLine(number * 1.50);
                else if (town == "Varna") Console.WriteLine(number * 1.55);
            }
        }
    }
}

using System;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var size = double.Parse(Console.ReadLine());
            var discount = -1.0;

            if (town == "sofia")
            {
                if (0 <= size && size <= 500) discount = size * 0.05;
                if (500 < size && size <= 1000) discount = size * 0.07;
                if (1000 < size && size <= 10000) discount = size * 0.08;
                if (size > 10000) discount = size * 0.12;
            }
            if (town == "varna")
            {
                if (0 <= size && size <= 500) discount = size * 0.045;
                if (500 < size && size <= 1000) discount = size * 0.075;
                if (1000 < size && size <= 10000) discount = size * 0.1;
                if (size > 10000) discount = size * 0.13;
            }
            if (town == "plovdiv")
            {
                if (0 <= size && size <= 500) discount = size * 0.055;
                if (500 < size && size <= 1000) discount = size * 0.08;
                if (1000 < size && size <= 10000) discount = size * 0.12;
                if (size > 10000) discount = size * 0.145;
            }
            if (discount >= 0)
                Console.WriteLine($"{discount:f2}");
            else Console.WriteLine("error");
        }
    }
}

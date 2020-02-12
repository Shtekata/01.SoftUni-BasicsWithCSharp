using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double cover = number * (length + 2 * 0.3) * (width + 2 * 0.3);
            double square = number * (length/2) * (length/2);
            double priceUSD = cover * 7 + square * 9;
            double priceBGN = priceUSD*1.85;
            Console.WriteLine($"{priceUSD:f2} {"USD"}");
            Console.WriteLine($"{priceBGN:f2} {"BGN"}");
        }
    }
}

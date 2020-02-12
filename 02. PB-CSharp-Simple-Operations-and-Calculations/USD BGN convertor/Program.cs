using System;

namespace USD_BGN_convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar = double.Parse(Console.ReadLine());
            Console.WriteLine($"{ dolar * 1.79549:f2}");
        }
    }
}

using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;
            Console.WriteLine(Math.Round(bgn,2));
        }
    }
}

using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());

            var bitcoinCash = bitcoin * 1168 / 1.95;
            var yuanCash = yuan * 0.15 * 1.76 / 1.95;
            var amount = bitcoinCash + yuanCash - (bitcoinCash + yuanCash) * percent / 100;
            Console.WriteLine(amount);
        }
    }
}

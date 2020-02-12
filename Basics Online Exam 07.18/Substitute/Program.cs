using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            var kk = int.Parse(Console.ReadLine());
            var ll = int.Parse(Console.ReadLine());
            var mm = int.Parse(Console.ReadLine());
            var nn = int.Parse(Console.ReadLine());
            var number = 0;

            for (int k = kk; k <= 8; k++)
            {
                if (k % 2 == 0)
                {
                    for (int l = 9; l >= ll; l--)
                    {
                        if (l % 2 == 1)
                        {
                            for (int m = mm; m <= 8; m++)
                            {
                                if (m % 2 == 0)
                                {
                                    for (int n = 9; n >= nn; n--)
                                    {
                                        if (n % 2 == 1)
                                        {
                                            if (k == m && l == n) Console.WriteLine($"Cannot change the same player.");
                                            else { Console.WriteLine($"{k}{l} - {m}{n}"); number++; }
                                            if (number == 6) return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }                
            }
        }
    }
}
        
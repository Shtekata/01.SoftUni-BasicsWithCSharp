using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfGroups = int.Parse(Console.ReadLine());
            var group = 0;
            var k = 0;
            var kk = 0;
            var kkk = 0;
            var kkkk = 0;
            var kkkkk = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                group = int.Parse(Console.ReadLine());
                if (group <= 5) k += group;
                else if (group <= 12) kk += group;
                else if (group <= 25) kkk += group;
                else if (group <= 40) kkkk += group;
                else if (group > 40) kkkkk += group;
            }
            double sum = k + kk + kkk + kkkk + kkkkk;
            var kp = k / sum * 100;
            var kkp = kk / sum * 100;
            var kkkp = kkk / sum * 100;
            var kkkkp = kkkk / sum * 100;
            var kkkkkp = kkkkk / sum * 100;
            Console.WriteLine($"{kp:f2}%");
            Console.WriteLine($"{kkp:f2}%");
            Console.WriteLine($"{kkkp:f2}%");
            Console.WriteLine($"{kkkkp:f2}%");
            Console.WriteLine($"{kkkkkp:f2}%");
        }
    }
}

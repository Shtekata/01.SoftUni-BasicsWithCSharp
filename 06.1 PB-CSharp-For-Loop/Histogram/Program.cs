using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;

            for (int i = 0; i < number; i++)
            {
                int currentValue = int.Parse(Console.ReadLine());
                if (currentValue < 200) p1 ++;
                else if (currentValue < 400) p2 ++;
                else if (currentValue < 600) p3 ++;
                else if (currentValue < 800) p4 ++;
                else p5 ++;
            }
            double percentP1 = p1 / number * 100;
            double percentP2 = p2 / number * 100;
            double percentP3 = p3 / number * 100;
            double percentP4 = p4 / number * 100;
            double percentP5 = p5 / number * 100;

            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}%");
            Console.WriteLine($"{percentP3:f2}%");
            Console.WriteLine($"{percentP4:f2}%");
            Console.WriteLine($"{percentP5:f2}%");
        }
    }
}

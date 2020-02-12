using System;

namespace Wedding_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var kind = string.Empty;
            var sum = 0.0;
            var balloons = 0;
            var flowers = 0;
            var candles = 0;
            var ribbon = 0;

            while (budget > sum)
            {
                kind = Console.ReadLine();
                if (kind == "stop") break;
                var number = int.Parse(Console.ReadLine());
                switch (kind)
                {
                    case "balloons": sum += number * 0.1; balloons += number; break;
                    case "flowers": sum += number * 1.5; flowers += number; break;
                    case "candles": sum += number * 0.5; candles += number; break;
                    case "ribbon": sum += number * 2; ribbon += number; break;
                }
            }
            if (budget <= sum) Console.WriteLine($"All money is spent!");
            else
            { Console.WriteLine($"Spend money: {sum:f2}"); Console.WriteLine($"Money left: {budget - sum:f2}"); }
            Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
        }
    }
}

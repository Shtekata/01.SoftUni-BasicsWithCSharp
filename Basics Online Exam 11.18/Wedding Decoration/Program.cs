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
            var spendMoney = 0.0;

            while ( budget > 0)
            {
                kind = Console.ReadLine();
                if (kind == "stop") break;
                var volume = int.Parse(Console.ReadLine());
                switch (kind)
                {
                    case "balloons": sum += volume * 0.1; balloons += volume; break;
                    case "flowers": sum += volume * 1.5; flowers += volume; break;
                    case "candles":sum += volume * 0.5; candles += volume; break;
                    case "ribbon":sum += volume * 2;ribbon += volume; break;
                }
                budget -= sum;
                spendMoney += sum;
                sum = 0;
            }
            if (budget <= 0) Console.WriteLine($"All money is spent!");
            else
            { Console.WriteLine($"Spend money: {spendMoney:f2}"); Console.WriteLine($"Money left: {budget:f2}"); };
            Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
        }
    }
}

using System;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var maxValue = 0;
            var maxName = string.Empty;
            while (name != "STOP")
            {
                var sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }
                if (sum > maxValue) { maxValue = sum; maxName = $"Winner is {name} - {maxValue}!"; }
                name = Console.ReadLine();
            }
            Console.WriteLine(maxName);
        }
    }
}

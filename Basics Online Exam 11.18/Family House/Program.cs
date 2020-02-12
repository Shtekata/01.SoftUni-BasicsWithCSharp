using System;

namespace Family_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            var electricity = 0.0;

            for (int i = 0; i < months; i++)
            {
                electricity += double.Parse(Console.ReadLine());
            }
            var water = 20 * months;
            var internet = 15 * months;
            var other = (electricity + water + internet) * 1.2;
            var average = (electricity + water + internet + other) / months;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}

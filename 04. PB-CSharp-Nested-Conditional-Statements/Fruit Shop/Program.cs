using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") Console.WriteLine(quantity * 2.5);
                if (fruit == "apple") Console.WriteLine(quantity * 1.2);
                if (fruit == "orange") Console.WriteLine(quantity * 0.85);
                if (fruit == "grapefruit") Console.WriteLine(quantity * 1.45);
                if (fruit == "kiwi") Console.WriteLine(quantity * 2.7);
                if (fruit == "pineapple") Console.WriteLine(quantity * 5.5);
                if (fruit == "grapes") Console.WriteLine(quantity * 3.85);

            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") Console.WriteLine(quantity * 2.7);
                if (fruit == "apple") Console.WriteLine(quantity * 1.25);
                if (fruit == "orange") Console.WriteLine(quantity * 0.9);
                if (fruit == "grapefruit") Console.WriteLine(quantity * 1.6);
                if (fruit == "kiwi") Console.WriteLine(quantity * 3);
                if (fruit == "pineapple") Console.WriteLine(quantity * 5.6);
                if (fruit == "grapes") Console.WriteLine(quantity * 4.2);
            }
            if (day != "monday" || day != "tuesday" || day != "wednesday" || day != "thursday" || day != "friday" ||
                day != "saturday" || day != "sunday" || fruit != "banana" || fruit != "apple" || fruit != "orange" ||
                fruit != "grapefruit" || fruit != "kiwi" || fruit == "pineapple" || fruit == "grapes")
                Console.WriteLine("error");
        }
    }
}

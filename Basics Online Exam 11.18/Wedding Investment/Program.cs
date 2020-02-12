using System;

namespace Wedding_Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            var term = Console.ReadLine();
            var kindOfContract = Console.ReadLine();
            var dessert = Console.ReadLine();
            var peyment = int.Parse(Console.ReadLine());
            var small = 0.0;
            var middle = 0.0;
            var large = 0.0;
            var extraLarge = 0.0;
            var sum = 0.0;

            if (term == "one")
            {
                small = 9.98; middle = 18.99; large = 25.98; extraLarge = 35.99;
            }
            else
            {
                small = 8.58; middle = 17.09; large = 23.59; extraLarge = 31.79;
            }

            switch (kindOfContract)
            {
                case "Small": sum += small; break;
                case "Middle": sum += middle; break;
                case "Large": sum += large; break;
                case "ExtraLarge": sum += extraLarge; break;
            }

            if (dessert == "yes")
            {
                if (sum <= 10) sum += 5.5;
                else if (sum <= 30) sum += 4.35;
                else sum += 3.85;
            }

            if (term == "two") sum *= 0.9625;

            sum *= peyment;

            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}

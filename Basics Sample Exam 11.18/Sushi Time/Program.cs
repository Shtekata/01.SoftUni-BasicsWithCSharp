using System;

namespace Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var kind = Console.ReadLine();
            var rest = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());
            var order = Console.ReadLine();
            var price = 0.0;

            switch (kind)
            {
                case "sashimi":
                    switch (rest)
                    {
                        case "Sushi Zone": price = 4.99;break;
                        case "Sushi Time":price = 5.49;break;
                        case "Sushi Bar":price = 5.25;break;
                        case "Asian Pub":price = 4.5;break;
                    }break;
                case "maki":
                    switch (rest)
                    {
                        case "Sushi Zone": price = 5.29; break;
                        case "Sushi Time": price = 4.69; break;
                        case "Sushi Bar": price = 5.55; break;
                        case "Asian Pub": price = 4.8; break;
                    }
                    break;
                case "uramaki":
                    switch (rest)
                    {
                        case "Sushi Zone": price = 5.99; break;
                        case "Sushi Time": price = 4.49; break;
                        case "Sushi Bar": price = 6.25; break;
                        case "Asian Pub": price = 5.5; break;
                    }
                    break;
                case "temaki":
                    switch (rest)
                    {
                        case "Sushi Zone": price = 4.29; break;
                        case "Sushi Time": price = 5.19; break;
                        case "Sushi Bar": price = 4.75; break;
                        case "Asian Pub": price = 5.5; break;
                    }
                    break;
            }
            var allPrice = price * number;
            if (order=="Y")
            {
                allPrice *= 1.2;
            }
            if (rest != "Sushi Zone" && rest != "Sushi Time" && rest != "Sushi Bar" && rest != "Asian Pub")
            {
                Console.WriteLine($"{rest} is invalid restaurant!");
            }
            else Console.WriteLine($"Total price: {Math.Ceiling(allPrice)} lv.");
        }
    }
}

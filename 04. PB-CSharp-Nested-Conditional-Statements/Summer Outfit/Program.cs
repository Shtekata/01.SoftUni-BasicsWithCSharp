using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var degrees = int.Parse(Console.ReadLine());
            var partOfTheDay = Console.ReadLine();
            var outfit = "";
            var shoes = "";

            if (partOfTheDay == "Morning")
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            if (partOfTheDay == "Afternoon")
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degrees >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            if (partOfTheDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}

using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var priceForApartment = 0.0;
            var priceForStudio = 0.0;

            if (month == "May" || month == "October")
            {
                priceForApartment = 65;
                priceForStudio = 50;
                if (nights > 7 && nights < 15) priceForStudio *= 0.95;
                if (nights > 14) priceForStudio *= 0.7;
            }
            if (month == "June" || month == "September")
            {
                priceForApartment = 68.7;
                priceForStudio = 75.2;
                if (nights > 14) priceForStudio *= 0.8;
            }
            if (month == "July" || month == "August")
            {
                priceForApartment = 77;
                priceForStudio = 76;
            }
            if (nights > 14) priceForApartment *= 0.9;
            Console.WriteLine($"Apartment: {priceForApartment * nights:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio * nights:f2} lv.");

        }
    }
}

using System;

namespace Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            var team = Console.ReadLine();
            var souvenirs = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());

            var flags = 0.0;
            var caps = 0.0;
            var posters = 0.0;
            var stickers = 0.0;
            var sum = 0.0;

            if (team == "Argentina" || team == "Brazil" || team == "Croatia" || team == "Denmark")
            {
                if (souvenirs == "flags" || souvenirs == "caps" || souvenirs == "posters" || souvenirs == "stickers")
                {
                    switch (team)
                    {
                        case "Argentina": flags = 3.25; caps = 7.2; posters = 5.1; stickers = 1.25; break;
                        case "Brazil": flags = 4.2; caps = 8.5; posters = 5.35; stickers = 1.2; break;
                        case "Croatia": flags = 2.75; caps = 6.9; posters = 4.95; stickers = 1.1; break;
                        case "Denmark": flags = 3.1; caps = 6.5; posters = 4.8; stickers = 0.9; break;
                    }
                    switch (souvenirs)
                    {
                        case "flags": sum = flags * number; break;
                        case "caps": sum = caps * number; break;
                        case "posters": sum = posters * number; break;
                        case "stickers": sum = stickers * number; break;
                    }

                    Console.WriteLine($"Pepi bought {number} {souvenirs} of {team} for {sum:f2} lv.");
                }
                else { Console.WriteLine($"Invalid stock!"); return; }
            }
            else { Console.WriteLine($"Invalid country!"); return; }
        }
    }
}

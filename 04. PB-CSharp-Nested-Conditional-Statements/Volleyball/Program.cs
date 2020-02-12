using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekend = int.Parse(Console.ReadLine());

            var sofiaGames = (48 - weekend) * (3.0 / 4);
            var holidaysGames = holidays * (2.0 / 3);
            var weekendGames = weekend;

            var games = sofiaGames + holidaysGames + weekendGames;

            if (year == "leap") games *= 1.15;

            Console.WriteLine(Math.Floor(games));
        }
    }
}

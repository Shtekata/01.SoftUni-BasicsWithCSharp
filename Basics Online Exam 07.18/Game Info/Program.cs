using System;

namespace Game_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            var team = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());
            var time = 0;
            var sumTime = 0.0;
            var additional = 0;
            var penalty = 0;

            for (int i = 0; i < number; i++)
            {
                time = int.Parse(Console.ReadLine());
                if (time > 120) penalty++;
                else if (time > 90) additional++;
                sumTime += time;
            }
            Console.WriteLine($"{team} has played {sumTime} minutes. Average minutes per game: {sumTime/number:f2}");
            Console.WriteLine($"Games with penalties: {penalty}");
            Console.WriteLine($"Games with additional time: {additional}");
        }
    }
}

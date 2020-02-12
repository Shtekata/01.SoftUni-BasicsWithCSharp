using System;

namespace Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = Console.ReadLine();
            var goals = 0;
            var bestPlayer = string.Empty;
            var maxGoals = 0;

            while (player!="END")
            {
                goals = int.Parse(Console.ReadLine());
                if (goals > maxGoals) { maxGoals = goals; bestPlayer = player; }
                if (goals >= 10) break;
                player = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if(goals>=3) Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            else Console.WriteLine($"He has scored {maxGoals} goals.");
        }
    }
}

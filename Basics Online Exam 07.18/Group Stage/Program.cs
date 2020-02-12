using System;

namespace Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            var team = Console.ReadLine();
            var matches = int.Parse(Console.ReadLine());
            var scored = 0;
            var recieved = 0;
            var sumScored = 0;
            var sumRecieved = 0;
            var points = 0;

            for (int i = 0; i < matches; i++)
            {
                scored = int.Parse(Console.ReadLine());
                recieved = int.Parse(Console.ReadLine());
                if (scored > recieved) points += 3;
                if (scored == recieved) points++;
                sumScored += scored;
                sumRecieved += recieved;
            }
            if (sumScored >= sumRecieved)
            { Console.WriteLine($"{team} has finished the group phase with {points} points."); Console.WriteLine($"Goal difference: {sumScored - sumRecieved}.");
            }
            else
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {sumScored - sumRecieved}.");
            }
        }
    }
}

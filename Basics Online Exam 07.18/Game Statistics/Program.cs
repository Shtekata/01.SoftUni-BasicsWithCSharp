using System;

namespace Game_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var minutes = int.Parse(Console.ReadLine());
            var name = Console.ReadLine();

            if (minutes == 0) Console.WriteLine($"Match has just began!");
            else if (minutes < 45) Console.WriteLine($"First half time.");
            else if (minutes >= 45) Console.WriteLine($"Second half time.");

            if (minutes >= 1 && minutes <= 10)
            { Console.WriteLine($"{name} missed a penalty."); if (minutes % 2 == 0) Console.WriteLine($"{name} was injured after the penalty."); }
            if (minutes > 10 && minutes <= 35)
            { Console.WriteLine($"{name} received yellow card."); if (minutes % 2 == 1) Console.WriteLine($"{name} got another yellow card."); }
            if (minutes > 35 && minutes < 45) Console.WriteLine($"{name} SCORED A GOAL !!!");
            if (minutes > 45 && minutes <= 55)
            { Console.WriteLine($"{name} got a freekick."); if (minutes % 2 == 0) Console.WriteLine($"{name} missed the freekick."); }
            if (minutes > 55 && minutes <= 80)
            {
                Console.WriteLine($"{name} missed a shot from corner."); if (minutes % 2 == 1) Console.WriteLine($"{name} has been changed with another player.");
            }
            if (minutes > 80 && minutes <= 90) Console.WriteLine($"{name} SCORED A GOAL FROM PENALTY !!!");
            


        }
    }
}

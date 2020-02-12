using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var steps = 0;
            bool cede = false;
            while (steps < 10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    cede = true;
                    input = Console.ReadLine();
                    steps += int.Parse(input);
                    if (steps >= 10000) Console.WriteLine($"Goal reached! Good job!");
                    else Console.WriteLine($"{10000 - steps} more steps to reach goal.");
                    break;
                }
                steps += int.Parse(input);
            }
            if (cede!=true) Console.WriteLine($"Goal reached! Good job!");
        }
    }
}

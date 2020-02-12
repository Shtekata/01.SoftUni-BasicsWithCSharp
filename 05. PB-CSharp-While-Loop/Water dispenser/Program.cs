using System;

namespace Water_dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            var volume = int.Parse(Console.ReadLine());
            var snapshot = 0;
            var cost = 0;
            var input = string.Empty;
            var number = 0;
            while (snapshot < volume)
            {
                input = Console.ReadLine();
                if (input == "Easy") cost = 50;
                if (input == "Medium") cost = 100;
                if (input == "Hard") cost = 200;
                snapshot += cost;
                number++;
                
            }
            if(snapshot==volume) Console.WriteLine($"The dispenser has been tapped {number} times.");
            else Console.WriteLine($"{snapshot-volume}ml has been spilled.");
        }
    }
}

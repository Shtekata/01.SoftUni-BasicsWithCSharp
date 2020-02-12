using System;

namespace Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            var tshirt = double.Parse(Console.ReadLine());
            var neededM = double.Parse(Console.ReadLine());

            var shorts = tshirt * 0.75;
            var socks = shorts * 0.2;
            var buttons = 2 * (tshirt + shorts);

            var sumDisc = (tshirt + shorts + socks + buttons) * 0.85;

            if (sumDisc >= neededM)
            { Console.WriteLine($"Yes, he will earn the world-cup replica ball!"); Console.WriteLine($"His sum is {sumDisc:f2} lv."); }
            else
            { Console.WriteLine($"No, he will not earn the world-cup replica ball."); Console.WriteLine($"He needs {neededM - sumDisc:f2} lv. more."); }
        }
    }
}

using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var numberOfPieces = length * width;
            var takenPieces = 0;
            var leftPieces = numberOfPieces - takenPieces;

            while (leftPieces>=0)
            {
                string input = Console.ReadLine();
                if (input == "STOP") { Console.WriteLine($"{leftPieces} pieces are left."); return; }
                takenPieces += int.Parse(input);
                leftPieces -= int.Parse(input);
               
            }
            Console.WriteLine($"No more cake left! You need {Math.Abs(leftPieces)} pieces more.");
        }
    }
}

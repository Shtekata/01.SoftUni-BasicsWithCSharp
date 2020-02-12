using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var numberOfPeople = int.Parse(Console.ReadLine());

            days *= 0.9;
            var hours = Math.Floor(days * numberOfPeople * 10);
            var difference = Math.Abs(hours - neededHours);

            if (hours >= neededHours) Console.WriteLine($"Yes!{difference} hours left.");
            else Console.WriteLine($"Not enough time!{difference} hours needed.");
        }
    }
}

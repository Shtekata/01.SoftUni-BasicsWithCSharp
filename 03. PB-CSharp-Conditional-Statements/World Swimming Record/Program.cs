using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = double.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var timeForMeter = double.Parse(Console.ReadLine());

            var delay = Math.Floor(distance / 15);
            var delayAll = delay * 12.5;
            var timeForSwimming = distance * timeForMeter + delayAll;
            var difference = record - timeForSwimming;

            if (timeForSwimming < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeForSwimming:f2} seconds.");
            }
            else Console.WriteLine($"No, he failed! He was {Math.Abs(difference):f2} seconds slower.");
        }
    }
}

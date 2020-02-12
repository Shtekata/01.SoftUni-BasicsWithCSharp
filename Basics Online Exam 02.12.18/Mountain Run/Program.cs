using System;

namespace Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = double.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var timeForOneM = double.Parse(Console.ReadLine());

            var time = distance * timeForOneM;
            var additionalT = Math.Floor(distance / 50) * 30;
            var allTime = time + additionalT;

            if (allTime < record) Console.WriteLine($"Yes! The new record is {allTime:f2} seconds.");
            else Console.WriteLine($"No! He was {allTime-record:f2} seconds slower.");
        }
    }
}

using System;

namespace Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBrotherTime = double.Parse(Console.ReadLine());
            var secondBrotherTime = double.Parse(Console.ReadLine());
            var thirdBrotherTime = double.Parse(Console.ReadLine());
            var timeForFishing = double.Parse(Console.ReadLine());

            var brothersTimePart = 1 / (1 / firstBrotherTime + 1 / secondBrotherTime + 1 / thirdBrotherTime);
            var timeWithRest = brothersTimePart * 1.15;

            var time = timeForFishing - timeWithRest;
            
            Console.WriteLine($"Cleaning time: {timeWithRest:f2}");
            if (time>0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(time)} hours.");
            }
            else Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Abs(Math.Floor(time))} hours.");
   

        }
    }
}

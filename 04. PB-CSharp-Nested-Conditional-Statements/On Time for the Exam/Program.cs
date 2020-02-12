using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourForExam = int.Parse(Console.ReadLine());
            var minuteForExam = int.Parse(Console.ReadLine());
            var hourOfArrive = int.Parse(Console.ReadLine());
            var minuteOfArrive = int.Parse(Console.ReadLine());
            var timeForExam = hourForExam * 60 + minuteForExam;
            var timeOfArrive = hourOfArrive * 60 + minuteOfArrive;
            var difference = timeOfArrive - timeForExam;
            var absDifference = Math.Abs(difference);
            var hourDifference = absDifference / 60;
            var minuteDifference = absDifference % 60;

            if (difference > 0)
            {
                Console.WriteLine("Late");
                if (hourDifference == 0) Console.WriteLine($"{minuteDifference} minutes after the start");
                if (hourDifference == 0 && minuteDifference <= 9) Console.WriteLine($"0{minuteDifference} minutes after the start");
                if (hourDifference != 0 && minuteDifference > 9) Console.WriteLine($"{hourDifference}:{minuteDifference} hours after the start");
                if (hourDifference != 0 && minuteDifference <= 9) Console.WriteLine($"{hourDifference}:0{minuteDifference} hours after the start");
            }

            if (difference < -30)
            {
                Console.WriteLine("Early");
                if (hourDifference == 0) Console.WriteLine($"{minuteDifference} minutes before the start");
                if (hourDifference == 0 && minuteDifference <= 9) Console.WriteLine($"0{minuteDifference} minutes before the start");
                if (hourDifference != 0 && minuteDifference > 9) Console.WriteLine($"{hourDifference}:{minuteDifference} hours before the start");
                if (hourDifference != 0 && minuteDifference <= 9) Console.WriteLine($"{hourDifference}:0{minuteDifference} hours before the start");
            }
            if (difference >= -30 && difference <= 0)
            {
                Console.WriteLine("On time");
                if (difference != 0) Console.WriteLine($"{minuteDifference} minutes before the start");
            }
        }
    }
}

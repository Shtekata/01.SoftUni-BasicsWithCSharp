using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var classNumber = 0;
            var ongoingAssessment = 0.0;
            var allScore = 0.0;

            while (classNumber<12)
            {
                ongoingAssessment = double.Parse(Console.ReadLine());
                if (ongoingAssessment >= 4) { classNumber++; allScore += ongoingAssessment; }
            }
            Console.WriteLine($"{name} graduated. Average grade: {(allScore/12):f2}");
        }
    }
}

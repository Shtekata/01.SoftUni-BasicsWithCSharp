using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxBadGrade = int.Parse(Console.ReadLine());
            var sumOfGrade = 0.0;
            var numberOfGrade = 0;
            string lastProblem = string.Empty;
            int badGrade = 0;

            while (true)
            {
                string nameOfTask = Console.ReadLine();

                if (nameOfTask == "Enough")
                {
                    Console.WriteLine($"Average score: {(sumOfGrade/numberOfGrade):f2}");
                    Console.WriteLine($"Number of problems: {numberOfGrade}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                sumOfGrade += grade;
                numberOfGrade++;
                lastProblem = nameOfTask;
    
                if (grade <= 4) badGrade++;
                if (badGrade == maxBadGrade) { Console.WriteLine($"You need a break, {badGrade} poor grades."); return; }
            }
        }
    }
}

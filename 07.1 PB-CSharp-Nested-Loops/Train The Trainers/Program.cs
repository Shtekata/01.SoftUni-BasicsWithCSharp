using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfJuri = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var evaluation = 0.0;
            var numberOfExams = 0;
            var sumEv = 0.0;
            while (input!="Finish")
            {
                for (int i = 0; i < numberOfJuri; i++)
                {
                    var currentEv = double.Parse(Console.ReadLine());
                    evaluation += currentEv;
                }
                var midEv = evaluation / numberOfJuri;
                numberOfExams++;
                sumEv += midEv;
                evaluation = 0.0;
                Console.WriteLine($"{input} - {midEv:f2}.");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {sumEv/numberOfExams:f2}.");
        }
    }
}

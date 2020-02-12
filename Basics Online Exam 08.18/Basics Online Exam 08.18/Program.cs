using System;

namespace Basics_Online_Exam_08._18
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeForRest = int.Parse(Console.ReadLine());
            var periphery = double.Parse(Console.ReadLine());
            var program = double.Parse(Console.ReadLine());
            var frappe = double.Parse(Console.ReadLine());

            var spentMoney = 3 * periphery + 2 * program + frappe;
            timeForRest -= 5 + 3 * 2 + 2 * 2;

            Console.WriteLine($"{spentMoney:f2}");
            Console.WriteLine(timeForRest);
        }
    }
}

using System;

namespace Basics_Online_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var bar = double.Parse(Console.ReadLine());

            var hall = length * width;
            var barArea = bar * bar;
            var danceFloor = hall * 19 / 100;
            var area = hall - barArea - danceFloor;
            var person = Math.Ceiling(area / 3.2);

            Console.WriteLine(person);
        }
    }
}

using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var numb2 = 0.0;
            var numb3 = 0.0;
            var numb4 = 0.0;

            for (int i = 0; i < numbers; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0) numb2++;
                if (number % 3 == 0) numb3++;
                if (number % 4 == 0) numb4++;
            }
            var numb2per = numb2 / numbers * 100;
            var numb3per = numb3 / numbers * 100;
            var numb4per = numb4 / numbers * 100;

            Console.WriteLine($"{numb2per:f2}%");
            Console.WriteLine($"{numb3per:f2}%");
            Console.WriteLine($"{numb4per:f2}%");
        }
    }
}

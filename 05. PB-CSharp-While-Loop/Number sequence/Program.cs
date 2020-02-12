using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        { 
            string input = Console.ReadLine();
            var maxNumber = int.Parse(input);
            var minNumber = int.Parse(input);

            while (input!="END")
            {
                input = Console.ReadLine();
   
                if (input != "END")
                {
                    int number = int.Parse(input);
                    if (number < minNumber) minNumber = number;
                    if (number > maxNumber) maxNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}

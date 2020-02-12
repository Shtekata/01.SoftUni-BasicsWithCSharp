using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var currentState = 1;
            while (currentState<=number)
            {
                Console.WriteLine(currentState);
                currentState = currentState * 2 + 1;
            }
        }
    }
}

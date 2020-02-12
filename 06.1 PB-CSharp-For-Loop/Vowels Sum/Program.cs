using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowels = Console.ReadLine();
            var sum = 0;
            for (int i = 1; i < vowels.Length; i++)
            {
                if (vowels[i] == 'a') sum += 1;
                if (vowels[i] == 'e') sum += 2;
                if (vowels[i] == 'i') sum += 3;
                if (vowels[i] == 'o') sum += 4;
                if (vowels[i] == 'u') sum += 5;
            }
            Console.WriteLine(sum);
        }
    }
}

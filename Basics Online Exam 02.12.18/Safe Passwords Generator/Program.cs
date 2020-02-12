using System;

namespace Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var maxNumb = int.Parse(Console.ReadLine());
            var number = 0;
            var i = 35;
            var j = 64;

            for (int k = 1; k <= x; k++)
            {
                for (int l = 1; l <= y; l++)
                {
                    Console.Write($"{(char)i}{(char)j}{k}{l}{(char)j}{(char)i}|");
                    i++;
                    j++;
                    if (i == 56) i = 35;
                    if (j == 97) j = 64;
                    number++;
                    if (number == maxNumb) return;
                }
            }
        }
    }
}

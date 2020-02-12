using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var seconds1 = int.Parse(Console.ReadLine());
            var seconds2 = int.Parse(Console.ReadLine());
            var seconds3 = int.Parse(Console.ReadLine());
            var minutes = 0;
            var sumSeconds = seconds1 + seconds2 + seconds3;

            if (sumSeconds >= 60)
            {
                minutes ++;
                sumSeconds -= 60;
            }
            if(sumSeconds >= 60)
            {
                minutes ++;
                sumSeconds -= 60;
            }
            if (sumSeconds < 10)
            {
                Console.WriteLine($"{minutes}{":0"}{sumSeconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}{":"}{sumSeconds}");
            }
        }
    }
}

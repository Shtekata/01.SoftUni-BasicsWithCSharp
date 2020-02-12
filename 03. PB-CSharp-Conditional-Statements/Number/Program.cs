using System;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            number += number;
            Console.WriteLine(number);
        }
    }
}

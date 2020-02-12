using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
       
            var a = double.Parse(Console.ReadLine());
            var b = Convert.ToChar(Console.ReadLine());

            var n = int.Parse(Console.ReadLine());

            var d = Console.ReadLine();
            Console.WriteLine("Hello World!");

            Console.WriteLine($"{a}{b}{n}{d}");
        }
    }
}

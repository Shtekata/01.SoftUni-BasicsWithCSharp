using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please input lenght: ");
            var l = double.Parse(Console.ReadLine());
            //Console.Write("Please input width: ");
            var w = double.Parse(Console.ReadLine());
            //Console.Write("Please input hight: ");
            var h = double.Parse(Console.ReadLine());
            //Console.Write("Please input percentage: ");
            var p = double.Parse(Console.ReadLine());
            var volume = l * w * h/1000*(1-p/100);
            Console.WriteLine($"{volume:f3}");
        }
    }
}

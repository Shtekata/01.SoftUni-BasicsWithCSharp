using System;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var hh = 2 * h;
            var hhh = 3 * h;
            var hhhh = 4 * h;

            if ((x > 0 && x < hhh && y > 0 && y < h) || (x > h && x < hh && y > h && y < hhhh) || (y == h && x > h && x < hh))
                Console.WriteLine("inside");
            else if ((x < 0 || x > hhh || y < 0 || y > h) && (x < h || x > hh || y < h || y > hhhh))
                //|| (x >= 0 && x < h && y > h && y <= hhhh) || (x > hh && x <= hhh && y > h && y <= hhhh))
                Console.WriteLine("outside");
            else Console.WriteLine("border");
        }
    }
}

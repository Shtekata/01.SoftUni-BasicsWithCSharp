using System;

namespace _2D_Rectangle_Area._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double X = Math.Max(X1, X2) - Math.Min(X1, X2);
            double Y = Math.Max(Y1, Y2) - Math.Min(Y1, Y2);
            double Area = X * Y;
            double Circuit = 2 * (X + Y);
            Console.WriteLine(Area);
            Console.WriteLine(Circuit);
        }
    }
}

using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double Hall = L * W * 10000;
            //Console.WriteLine(Hall);
            double wardrobe = A * A * 10000;
            //Console.WriteLine(wardrobe);
            double bench = Hall/10;
            //Console.WriteLine(bench);
            double freeSpace = Hall - wardrobe - bench;
            //Console.WriteLine(freeSpace);
            double numberOfDancers = freeSpace / 7040;
            double up = Math.Floor(numberOfDancers);
            Console.WriteLine(up);
        }
    }
}

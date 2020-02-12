using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfProjection = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            double price = rows * columns;

            if (kindOfProjection == "Premiere") { price = price * 12; Console.WriteLine($"{price:f2} leva"); }
            if (kindOfProjection == "Normal") { price = price * 7.5; Console.WriteLine($"{price:f2} leva"); }
            else if (kindOfProjection == "Discount") { price = price * 5; Console.WriteLine($"{price:f2} leva"); }

        }
    }
}

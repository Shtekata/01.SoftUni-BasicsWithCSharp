using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
                Console.WriteLine(area);
            }
            else if (shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
                Console.WriteLine(area);
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
                Console.WriteLine(area);
            }
            else if (shape == "triangle")
            {
                double hypotension = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());
                area = hypotension * hight / 2;
                Console.WriteLine(area);
            }
        }
    }
}

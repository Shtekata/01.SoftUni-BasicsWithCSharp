﻿using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius. r = ");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = "+Math.PI*r*r);
            Console.WriteLine("Perimeter = " + 2 * Math.PI * r);
        }
    }
}

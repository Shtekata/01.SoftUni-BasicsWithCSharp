﻿using System;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid area = "+((b1+b2)/2*h));
        }
    }
}

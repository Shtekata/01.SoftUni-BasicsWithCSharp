﻿using System;

namespace Numbers_1_N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number=int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}

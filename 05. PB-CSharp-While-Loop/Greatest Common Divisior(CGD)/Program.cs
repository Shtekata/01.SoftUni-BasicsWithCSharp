using System;

namespace Greatest_Common_Divisior_CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = 0;

            if (b == 0) result = a;
            else
            {
                while (b != 0)
                {
                    result = b;
                    b = a % b;
                    a = result;
                }
            }
            Console.WriteLine(result);
        }
    }
}

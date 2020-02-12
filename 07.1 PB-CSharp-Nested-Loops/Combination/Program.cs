using System;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var number = 0;
            for (int i = 0; i <= input; i++)
            {
                for (int j = 0; j <= input; j++)
                {
                    for (int k = 0; k <= input; k++)
                    {
                        for (int l = 0; l <= input; l++)
                        {
                            for (int m = 0; m <= input; m++)
                            {
                                if (i+j+k+l+m==input)
                                {
                                    number++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(number);
        }
    }
}

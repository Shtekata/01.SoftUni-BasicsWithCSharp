using System;

namespace Magic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var magic = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        for (int l = 0; l < 10; l++)
                        {
                            for (int m = 0; m < 10; m++)
                            {
                                for (int n = 0; n < 10; n++)
                                {
                                    if (magic == i * j * k * l * m * n) Console.Write($"{i}{j}{k}{l}{m}{n} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

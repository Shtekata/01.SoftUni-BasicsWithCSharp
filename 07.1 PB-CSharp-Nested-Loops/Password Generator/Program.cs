using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numb1 = int.Parse(Console.ReadLine());
            var numb2 = int.Parse(Console.ReadLine());
            var n = 1;

            for (int i = 1; i <= numb1-1; i++)
            {
                for (int j = 1; j <= numb1-1; j++)
                {
                    for (int k = 0; k < numb2; k++)
                    {
                        var o = (char)(k+97);
                        for (int l = 0; l < numb2; l++)
                        {
                            var p = (char)(l+97);
                            if (i > j) n = i; else n = j; 
                            for (int m = n+1; m <= numb1; m++)
                            {
                                Console.Write($"{i}{j}{o}{p}{m} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

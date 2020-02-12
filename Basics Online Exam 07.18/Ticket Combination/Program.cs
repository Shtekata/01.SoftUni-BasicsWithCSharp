using System;

namespace Ticket_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var counter = 0;
      
            for (int i = 66; i <= 76; i++)
            {
                if (i % 2 == 0)
                {
                    for (int k = 102; k >= 97; k--)
                    {
                        for (int l = 65; l <= 67; l++)
                        {
                            for (int m = 1; m <= 10; m++)
                            {
                                for (int n = 10; n >= 1; n--)
                                {
                                    var sum = i + k + l + m + n;
                                    counter++;
                                    if (counter == number)
                                    {
                                        Console.WriteLine($"Ticket combination: {(char)i}{(char)k}{(char)l}{m}{n}");
                                        Console.WriteLine($"Prize: {sum} lv.");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

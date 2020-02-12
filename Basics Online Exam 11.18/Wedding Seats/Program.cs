using System;

namespace Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            var lastSector = Convert.ToChar(Console.ReadLine());
            var row = int.Parse(Console.ReadLine());
            var seats = int.Parse(Console.ReadLine());
            var number = 0;

            for (int i = 'A'; i <= lastSector; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    var extraSeats = 0;
                    if (j % 2 == 0) extraSeats = 2;
                    for (int k = 0; k < seats+extraSeats; k++)
                    {
                      
                        Console.WriteLine($"{Convert.ToChar(i)}{j}{Convert.ToChar(k+97)}");
                        number++;
                    }
                }
                row++;
            }
            Console.WriteLine(number);
        }
    }
}

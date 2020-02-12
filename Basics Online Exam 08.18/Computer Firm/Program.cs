using System;

namespace Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var computers = int.Parse(Console.ReadLine());
            var input = 0.0;
            var ratingSum = 0.0;
            var salesSum = 0.0;
          
            for (int i = 0; i < computers; i++)
            {
                input = int.Parse(Console.ReadLine());
                var rating = input % 10;
                var sales = (input - rating)/10;
                switch (rating)
                {
                    case 2: sales = 0; break;
                    case 3: sales *= 0.5; break;
                    case 4: sales *= 0.7; break;
                    case 5: sales *= 0.85; break;
                }
                ratingSum += rating;
                salesSum += sales;
                rating = 0;
                sales = 0;
            }
            Console.WriteLine($"{salesSum:f2}");
            Console.WriteLine($"{ratingSum/computers:f2}");
        }
    }
}

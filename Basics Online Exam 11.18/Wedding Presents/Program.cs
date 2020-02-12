using System;

namespace Wedding_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfGuests = int.Parse(Console.ReadLine());
            var numberOfGifts = double.Parse(Console.ReadLine());
            var a = 0;
            var b = 0;
            var v = 0;
            var g = 0;


            for (int i = 0; i < numberOfGifts; i++)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "A": a++; break;
                    case "B": b++; break;
                    case "V": v++; break;
                    case "G": g++; break;
                }
            }
            Console.WriteLine($"{a/numberOfGifts*100:f2}%");
            Console.WriteLine($"{b/numberOfGifts*100:f2}%");
            Console.WriteLine($"{v/numberOfGifts*100:f2}%");
            Console.WriteLine($"{g/numberOfGifts*100:f2}%");
            Console.WriteLine($"{numberOfGifts/numberOfGuests*100:f2}%");
        }
    }
}

using System;

namespace Scholarship2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double uspeh = double.Parse(Console.ReadLine());
            double minZaplata = double.Parse(Console.ReadLine());
            double socialStipendiq = Math.Floor(0.35 * minZaplata);
            double stipendiq = Math.Floor(uspeh * 25);

            if (uspeh<=4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (uspeh < 5.5 && dohod>minZaplata)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (dohod<minZaplata && uspeh<5.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialStipendiq} BGN");
            }
            else if (uspeh>=5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {stipendiq} BGN");
            }
            else if (dohod<minZaplata && uspeh>=5.5)
            {
                if (socialStipendiq>=stipendiq)
                {
                    Console.WriteLine($"You get a Social scholarship for excellent results {stipendiq} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {stipendiq} BGN");
                }
            }
        }
    }
}

using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double stepsPerDay = steps / days;
            double percentage = Math.Ceiling(stepsPerDay / steps * 100);
            double persentageDancers = percentage / dancers;

            if (percentage <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {persentageDancers:f2}%.");
            }
            else Console.WriteLine($"No, They will not succeed in that goal! Required {persentageDancers:f2}% steps to be learned per day.");
        }
    }
}

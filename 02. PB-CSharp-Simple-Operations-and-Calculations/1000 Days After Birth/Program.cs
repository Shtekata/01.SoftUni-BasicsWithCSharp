using System;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateIn = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",null);
            var dateOut = dateIn.AddDays(1000);
            Console.WriteLine(dateOut.ToString("dd-MM-yyyy"));
        }
    }
}

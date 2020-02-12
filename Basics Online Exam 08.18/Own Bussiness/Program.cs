using System;

namespace Own_Bussiness
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var lenght = int.Parse(Console.ReadLine());
            var hight = int.Parse(Console.ReadLine());
            var freeSpace = width * lenght * hight;
            var input = string.Empty;
 

            while (freeSpace > 0)
            {
                input = Console.ReadLine();
                if (input == "Done") { Console.WriteLine($"{freeSpace} Cubic meters left."); break; }
                var volume = int.Parse(input);
                freeSpace -= volume;

            }
            if (input != "Done")Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");





        }
    }
}

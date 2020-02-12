using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var hight = int.Parse(Console.ReadLine());
            var volumeMax = length * width * hight;
            var volume = 0;
            string volumeIn = string.Empty;

            while (volume <= volumeMax)
            {
                volumeIn = Console.ReadLine();
                if (volumeIn == "Done") {Console.WriteLine ($"{volumeMax - volume} Cubic meters left."); break; }
                var volumeInNumber  = int.Parse(volumeIn);
                volume += volumeInNumber;
            }
            if(volumeIn!="Done") Console.WriteLine($"No more free space! You need {volume-volumeMax} Cubic meters more.");
        }
    }
}

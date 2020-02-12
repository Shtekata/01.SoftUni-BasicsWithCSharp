using System;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = int.Parse(Console.ReadLine());
            var widthTiles = double.Parse(Console.ReadLine());
            var lengthTiles = double.Parse(Console.ReadLine());
            var widthBench = int.Parse(Console.ReadLine());
            var lenghtBench = int.Parse(Console.ReadLine());

            var numberWidthTiles = square / widthTiles;
            var numberLendhtTiles = square / lengthTiles;
            var numberTiles = numberWidthTiles * numberLendhtTiles;

            var numberWidthBench = widthBench / widthTiles;
            var numberLenghtBench = lenghtBench / lengthTiles;
            var numberBenchTiles = numberWidthBench * numberLenghtBench;

            var number = numberTiles - numberBenchTiles;
            var time = number * 0.2;
            Console.WriteLine(number);
            Console.WriteLine(time);

        }
    }
}

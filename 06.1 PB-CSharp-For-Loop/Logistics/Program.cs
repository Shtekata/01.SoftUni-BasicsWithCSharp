using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfFreight = int.Parse(Console.ReadLine());
            var freightMinibus = 0;
            var freightTruck = 0;
            var freightTrain = 0;
            var freight = 0.0;

            for (int i = 0; i < numberOfFreight; i++)
            {
                var currentFreight = int.Parse(Console.ReadLine());
                freight += currentFreight;
                if (currentFreight < 4) freightMinibus += currentFreight;
                else if (currentFreight < 12) freightTruck += currentFreight;
                else freightTrain += currentFreight;
            }
            var perMinibus = freightMinibus / freight * 100;
            var perTruck = freightTruck / freight * 100;
            var perTrain = freightTrain / freight * 100;
            var pricePerTon = (freightMinibus * 200 + freightTruck * 175 + freightTrain * 120) / freight;
            Console.WriteLine($"{pricePerTon:f2}");
            Console.WriteLine($"{perMinibus:f2}%");
            Console.WriteLine($"{perTruck:f2}%");
            Console.WriteLine($"{perTrain:f2}%");
        }
    }
}

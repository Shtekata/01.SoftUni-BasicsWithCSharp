using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var metricUnit1 = Console.ReadLine().ToLower();
            var metricUnit2 = Console.ReadLine().ToLower();

            if (metricUnit1 == "mm")
            {
                number = number / 1000;
            }
            if (metricUnit1 == "cm")
            {
                number = number / 100;
            }
            if (metricUnit1 == "mi")
            {
                number = number / 0.000621371192;
            }
            if (metricUnit1 == "in")
            {
                number = number / 39.3700787;
            }
            if (metricUnit1 == "km")
            {
                number = number / 0.001;
            }
            if (metricUnit1 == "ft")
            {
                number = number / 3.2808399;
            }
            if (metricUnit1 == "yd")
            {
                number = number / 1.0936133;
            }

            if (metricUnit2 == "mm")
            {
                number = number * 1000;
            }
            if (metricUnit2 == "cm")
            {
                number = number * 100;
            }
            if (metricUnit2 == "mi")
            {
                number = number * 0.000621371192;
            }
            if (metricUnit2 == "in")
            {
                number = number * 39.3700787;
            }
            if (metricUnit2 == "km")
            {
                number = number * 0.001;
            }
            if (metricUnit2 == "ft")
            {
                number = number * 3.2808399;
            }
            if (metricUnit2 == "yd")
            {
                number = number * 1.0936133;
            }
            Console.WriteLine(number);
        }
    }
}

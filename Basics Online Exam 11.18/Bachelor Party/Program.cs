using System;

namespace Bachelor_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var singer = int.Parse(Console.ReadLine());
            var couvert = 0;
            var sum = 0;
            var guests = 0;
            var input =Console.ReadLine();

            while(input!="The restaurant is full")
            {
                var group = int.Parse(input);
                if (group < 5) couvert = 100;
                else couvert = 70;
                sum += group * couvert;
                guests += group;
                input = Console.ReadLine();
            }
            if (sum >= singer) Console.WriteLine($"You have {guests} guests and {sum-singer} leva left.");
            else Console.WriteLine($"You have {guests} guests and {sum} leva income, but no singer.");
        }
    }
}

using System;

namespace Wedding_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var neededBudget = people * 20;
            if (budget >= neededBudget) Console.WriteLine($"Yes! {(budget - neededBudget) * 0.4:f0} lv are for fireworks and {(budget - neededBudget) * 0.6:f0} lv are for donation.");
            else Console.WriteLine($"They won't have enough money to pay the covert. They will need {neededBudget - budget:f0} lv more.");
        }
    }
}

using System;

namespace Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var batch = int.Parse(Console.ReadLine());
            for (int i = 1; i <= batch; i++)
            {
                var flour = false; var eggs = false; var sugar = false;
                while (true)
                {
                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "flour": flour = true; break;
                        case "eggs": eggs = true; break;
                        case "sugar": sugar = true; break;
                    }
                    if (input == "Bake!")
                    {
                        if (flour && eggs && sugar) { Console.WriteLine($"Baking batch number {i}..."); break; }
                        else Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                    }
                }
            }
        }
    }
}

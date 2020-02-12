using System;

namespace Latin_Leterrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latin alphabet: ");
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.WriteLine(" " + letter);
            }
            Console.WriteLine();
        }
    }
}

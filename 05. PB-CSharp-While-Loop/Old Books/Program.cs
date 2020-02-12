using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());

            int bookCount = 0;
            bool foundTheBook = false;
            while (bookCount < capacity)
            {
                string input = Console.ReadLine();
                if (input == book)
                {
                    foundTheBook = true;
                    break;
                }
                bookCount++;
            }
            if (foundTheBook) Console.WriteLine($"You checked {bookCount} books and found it.");
            else
            { Console.WriteLine($"The book you search is not here!"); Console.WriteLine($"You checked {capacity} books.");}
        }
    }
}

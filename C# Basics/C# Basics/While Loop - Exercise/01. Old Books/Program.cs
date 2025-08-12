using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOFBook = Console.ReadLine();
            string input = Console.ReadLine();

            int bookCount = 0;

            while (input != "No More Books")
            {
                if (input == nameOFBook)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");\
                    break;
                }
                bookCount++;
                input = Console.ReadLine();
            }
            if (input == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCount} books.");
            }
        }
    }
}

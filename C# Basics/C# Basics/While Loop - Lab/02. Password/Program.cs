using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != pass)
            {
                input = Console.ReadLine();
            }
            if (input == pass)
            {
                Console.WriteLine($"Welcome {user}!");
            }
        }
    }
}

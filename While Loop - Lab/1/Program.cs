using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                if (input=="Stop")
                {
                    break;
                }
                Console.WriteLine(input);
                input=Console.ReadLine();
            }
        }
    }
}

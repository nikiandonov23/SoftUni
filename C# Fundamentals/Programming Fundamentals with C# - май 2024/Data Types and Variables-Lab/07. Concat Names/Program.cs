using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();          
            string two = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{one}{delimiter}{two}");
        }
    }
}

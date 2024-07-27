using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputChar = input.ToCharArray();

            Array.Reverse(inputChar);

            string reverseInput = new string(inputChar);

            Console.WriteLine(reverseInput);


        }
    }
}

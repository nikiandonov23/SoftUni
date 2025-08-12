using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            for (int i = 1; i <= 3; i++)
            {
                char one = char.Parse(Console.ReadLine());
                word += one;
            }

            Console.WriteLine(word);

        }
    }
}

using System;

namespace _10._Lower_or_Upper__ASCII_RESHENIE
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            double asciiNumber = letter;


            if (asciiNumber>=65&&asciiNumber<=90)
            {
                Console.WriteLine("upper-case");
            }
            if (asciiNumber >= 97 && asciiNumber <= 122)
            {
                Console.WriteLine("lower-case");

            }
        }
    }
}

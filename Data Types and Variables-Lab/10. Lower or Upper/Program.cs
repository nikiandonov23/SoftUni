using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            char inputToUpper = char.ToUpper(input);

            if (input==inputToUpper)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

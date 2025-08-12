using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());




            void Method()
            {
                if (number == 0)
                    Console.WriteLine($"The number {number} is zero.");
                if (number > 0) Console.WriteLine($"The number {number} is positive. ");
                if (number < 0) Console.WriteLine($"The number {number} is negative. ");
            }

            Method();
        }

    }
}

using System;

namespace _03._Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());


            int numsum = num1 % 2;
            if (numsum != 0)
                Console.WriteLine("odd");
            else
                Console.WriteLine("even");




        }
    }
}

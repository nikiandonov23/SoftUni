using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double result = (double)number;

            Console.WriteLine($"{result/1000:f2}");
          
        }
    }
}

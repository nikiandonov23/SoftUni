using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _03._Rounding_Numbers_s_ARRAY_ot_DOUBLE
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] newArray = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < newArray.Length; i++)
            {
                double number = newArray[i];

                int roundedNumber = (int)(Math.Round(number, MidpointRounding.AwayFromZero));

                Console.WriteLine($"{number} => {roundedNumber}");
            }
        }

       

    }
}

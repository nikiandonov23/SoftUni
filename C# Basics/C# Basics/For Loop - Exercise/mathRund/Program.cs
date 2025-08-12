using System;

namespace mathRund
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 1268.45;
            double roundedNumber =Math.Round(number,1);
            double roundedNumberAgain = Math.Round(roundedNumber,1);
            Console.WriteLine(roundedNumberAgain);
        }
    }
}

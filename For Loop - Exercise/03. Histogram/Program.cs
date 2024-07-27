using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());              //number of numbers to be checked
            Double Under200 = 0;
            Double under399 = 0;
            Double under599 = 0;
            Double under799 = 0;
            Double biggerThan800 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    Under200 += 1;
                }
                if ((number >= 200) && (number <= 399))
                {
                    under399 += 1;
                }
                if ((number >= 400) && (number <= 599))
                {
                    under599 += 1;
                }
                if ((number >= 600) && (number <= 799))
                {
                    under799 += 1;
                }
                if ((number >= 800) && (number <= 1000))
                {
                    biggerThan800 += 1;
                }
                
            }
            Console.WriteLine($"{(Under200/n*100):f2}%");
            Console.WriteLine($"{(under399 / n * 100):f2}%");
            Console.WriteLine($"{(under599 / n * 100):f2}%");
            Console.WriteLine($"{(under799 / n * 100):f2}%");
            Console.WriteLine($"{(biggerThan800 / n * 100):f2}%");



        }
    }
}

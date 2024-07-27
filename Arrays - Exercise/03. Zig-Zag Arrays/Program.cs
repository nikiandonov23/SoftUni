using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int loopCounter = 0;

            string evenLoopNumbers = "";
            string oddLoopNumbers = "";

            for (int i = 1; i <= n; i++)
            {
                loopCounter++;
                string input = Console.ReadLine();
                string[] array = input.Split(" ");

           


                if (loopCounter % 2 != 0)
                {
                    oddLoopNumbers += array[0] + " ";

                }
                if (loopCounter % 2 == 0)
                {
                    oddLoopNumbers += array[1] + " ";
                }


                if (loopCounter % 2 != 0)
                {
                    evenLoopNumbers += array[1] + " ";

                }
                if (loopCounter % 2 == 0)
                {
                    evenLoopNumbers += array[0] + " ";
                }
            }

            Console.WriteLine(oddLoopNumbers);
            Console.WriteLine(evenLoopNumbers);
        }
    }
}

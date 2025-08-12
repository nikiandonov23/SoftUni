using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numSum = 0;

            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                numSum += input;

                if (numSum >= number)
                {
                    Console.WriteLine(numSum);
                    break;
                }

            }
        }
    }
}
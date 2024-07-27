using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal numberToSum = decimal.Parse(Console.ReadLine());
                total += numberToSum;

            }
            Console.WriteLine(total);
        }
    }
}

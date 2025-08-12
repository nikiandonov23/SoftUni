using System;

namespace _15_Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < n; i++)

            {
                int number = int.Parse(Console.ReadLine());

                {
                    if (i % 2 == 0)
                    {
                        sumEven += number;
                    }



                    if (i % 2 != 0)
                    {
                        sumOdd += number;
                    }


                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven-sumOdd)}");
            }
        }
    }
}
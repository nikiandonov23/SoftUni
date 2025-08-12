﻿using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;                               //  %2
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                { evenSum += number; }
                else if (i % 2 != 0)
                { oddSum += number; }

            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else if (oddSum != evenSum)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum-evenSum)}");

            }
        }
    }
}

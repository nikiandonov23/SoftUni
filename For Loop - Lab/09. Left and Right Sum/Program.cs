using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)                             //poma 4islata do n 
            {
                leftSum += int.Parse(Console.ReadLine());       
            }
            for (int i = 0; i < n; i++)                               //poma 4islata do n 
            {
                rightSum += int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
            { Console.WriteLine($"Yes, sum = {leftSum}"); }
            if (leftSum != rightSum)
            { Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}"); }

        }

    }
}

using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > maxNum)
                {
                    maxNum = number;

                }
            }
            if (sum - maxNum == maxNum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum - maxNum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs((maxNum)-(sum-maxNum))}");
            }

        }
    }
}

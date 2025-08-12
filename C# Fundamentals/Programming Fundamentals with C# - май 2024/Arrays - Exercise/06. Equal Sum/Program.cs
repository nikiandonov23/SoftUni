using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            // Edge case: if array has only one element
            if (array.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            int sum = array.Sum();

            int leftSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int rightSum = sum - leftSum - array[i];

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    break;
                }



                leftSum += array[i];
                if (i == array.Length - 1 && rightSum != leftSum)
                {

                    Console.WriteLine("no");

                }
            }


        }
    }
}
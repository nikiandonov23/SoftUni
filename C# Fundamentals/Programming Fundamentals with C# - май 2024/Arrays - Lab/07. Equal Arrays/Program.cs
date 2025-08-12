using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1= Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            bool arraysAreEqual = true;

            int sum = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i]!=array2[i])
                {
                    
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    arraysAreEqual = false;
                    break;
                }
                else
                {
                    
                    sum += array1[i];
                }
            }

            if (arraysAreEqual==true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}

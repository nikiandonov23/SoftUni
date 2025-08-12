using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int oddSum = 0;
            int evenSum = 0;

         

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i]%2==0)
                {
                   
                    evenSum += newArray[i];
                   

                }
                else if (newArray[i]%2!=0)
                {
                    oddSum += newArray[i];
                    
                }
            }

            Console.WriteLine($"{evenSum-oddSum}");

        }
    }
}

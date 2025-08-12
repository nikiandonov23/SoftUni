using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;


namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();                                         // 1 4 3 2



            int maxRight = int.MinValue;

            int[] newArray = new int[array.Length];


            int counter = 0;
            int B = 0;



            for (int i = array.Length - 1; i >= 0; i--)        //vurti 1 4 3 2     vzemam array[i]
            {

                if (array[i] > maxRight)
                {
                    
                    maxRight = array[i];
                    newArray[i] = maxRight;

                    counter++;

                }

            }

            int[] nikiArray = new int[counter];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i]!=0)
                {
                    nikiArray[B] = newArray[i];
                    B += 1;
                }
            }

            Console.WriteLine(string.Join(" ",nikiArray));
        }
    }
}

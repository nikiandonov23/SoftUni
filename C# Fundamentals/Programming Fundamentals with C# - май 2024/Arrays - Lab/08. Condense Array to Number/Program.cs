using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();


            while (array.Length > 1)
            {
                int[] newArray = new int[array.Length - 1];     //noviq v koito shte pishem stoinostite se namalq s 1 na vseki cikul

                for (int i = 0; i < array.Length - 1; i++)
                {
                    newArray[i] = array[i] + array[i + 1];
                }
                array = newArray;
            }

            Console.WriteLine(String.Join(" ",array));


        }
    }
}

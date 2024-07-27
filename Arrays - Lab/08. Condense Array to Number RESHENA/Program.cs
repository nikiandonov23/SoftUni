using System;
using System.Linq;

namespace _08._Condense_Array_to_Number_RESHENA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            while (array.Length>1)
            {
                int[] newArray = new int[array.Length - 1];

                for (int i = 0; i < array.Length-1; i++)
                {
                    newArray[i] = array[i] + array[i + 1];
                    
                }

                array = newArray;
            }


            Console.WriteLine(string.Join(" ",array));

        }
    }
}

﻿using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()                          //1 7 6 2 19 23
                                                                      // 8
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

           

            for (int i = 0; i < array.Length; i++)
            {


                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]+array[j]==n)
                    {
                        Console.Write(array[i]+" "+array[j]);
                        Console.WriteLine();
                    }
                }

            }

        }
    }
}

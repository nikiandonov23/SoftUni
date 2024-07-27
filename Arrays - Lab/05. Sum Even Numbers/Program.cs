﻿using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] newArry = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < newArry.Length; i++)
            {
                if (newArry[i]%2==0)
                {
                    sum += newArry[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}

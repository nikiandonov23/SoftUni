﻿using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = { "Monday" , "Tuesday" , "Wednesday" , "Thursday" , "Friday" ,"Saturday","Sunday"};
            int n = int.Parse(Console.ReadLine());

            if (n<1||n>7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(newArray[n - 1]);
            }
           


        }
    }
}

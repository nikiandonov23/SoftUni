﻿using System;

namespace _5._Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthNum = int.Parse(Console.ReadLine());

            string monthName = "";


            switch (monthNum)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;

            }

            if ((monthNum > 12) || (monthNum < 1))
            {
                Console.WriteLine($"Error!");
            }
            else
            {
                Console.WriteLine($"{monthName}");

            }
        }
    }
}

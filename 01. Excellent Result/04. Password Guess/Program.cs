﻿using System;

namespace _04._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {

            string password =(Console.ReadLine());
            if (password == "s3cr3t!P@ssw0rd")
                Console.WriteLine("Welcome");
            else
                Console.Write("Wrong password!");


        }
    }
}

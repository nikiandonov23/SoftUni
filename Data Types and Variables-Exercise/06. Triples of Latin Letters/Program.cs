﻿using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char firstLetter = (char)('a' + i);
                

                for (int k = 0; k < n; k++)
                {
                    char secondLetter = (char)('a' + k);
                    

                    for (int j = 0; j < n; j++)
                    {
                        char thirdLetter = (char)('a' + j);
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                       
                        
                    }
                }
            }

        }
    }
}

﻿using System;

class hello
{
    static void Main()
    {
        Double age = Double.Parse(Console.ReadLine());
        string sex = Console.ReadLine();

        if ((age >= 16) && (sex == "m"))
            Console.WriteLine("Mr.");

        else if ((age < 16) && (sex == "m"))
            Console.WriteLine("Master");

        else if ((age >= 16) && (sex == "f"))
            Console.WriteLine("Ms.");

        else if ((age < 16) && (sex == "f"))
            Console.WriteLine("Miss");




    }
}

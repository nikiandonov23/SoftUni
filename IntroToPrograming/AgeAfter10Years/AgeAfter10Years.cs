using static System.Console;
using System;

class Today
{
    static void Main()
    {
        Console.Write("Enter your birth date: " );
        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now ;
        int age = (int)((now - BirthDay).TotalDays / 365.242199);
        Console.WriteLine("After ten years you will be at the age of" + (age + 10));

        Console.ReadLine();
    }
}
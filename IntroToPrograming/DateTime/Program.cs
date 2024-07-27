using static System.Console;
using System;

class Today
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        WriteLine(now.ToString("F"));
        WriteLine("Millisecond: {0}", now.Millisecond);
        

            Console.ReadLine();
    }
}
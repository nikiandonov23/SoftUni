using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1990, 9, 27, 23, 23, 00);
            TimeSpan span = TimeSpan.FromSeconds(324356);

            Console.WriteLine(dateTime);
            Console.WriteLine(span);

            
            DateTime newDateTime =dateTime.Add(span);
            Console.WriteLine(newDateTime);

        }
    }
}

using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = Console.ReadLine().Split(" ");


            for (int i = newArray.Length-1; i >= 0; i--)
            {
                Console.Write(newArray[i]+" ");
               
            }
        }
    }
}

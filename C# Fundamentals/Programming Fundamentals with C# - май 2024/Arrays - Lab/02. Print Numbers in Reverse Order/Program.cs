using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] newArray=new string[n];                   //prazen array s n na broi elementa

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                newArray[i] = input;


            }

            for (int j = newArray.Length-1; j >= 0; j--)
            {
                Console.Write($"{newArray[j]} ");
            }
        }
    }
}

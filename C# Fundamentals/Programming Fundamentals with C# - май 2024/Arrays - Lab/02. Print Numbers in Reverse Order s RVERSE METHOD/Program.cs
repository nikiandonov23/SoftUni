using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order_s_RVERSE_METHOD
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] newArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                newArray[i] = Console.ReadLine();


            }

            Array.Reverse(newArray);


            for (int k = 0; k < newArray.Length; k++)
            {
                Console.Write($"{newArray[k]} ");
            }
       

            
        }
    }
}

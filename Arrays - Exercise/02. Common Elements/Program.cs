using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string[] oneArray = one.Split(" ");
            string two = Console.ReadLine();
            string[] twoArray = two.Split(" ");

            

            string final = "";

            for (int i = 0; i < twoArray.Length; i++)
            {

                for (int j = 0; j < oneArray.Length; j++)
                {
                    if (twoArray[i]==oneArray[j])
                    {
                        final += twoArray[i] + " ";
                    }
                }

            }

            Console.WriteLine(final);


        }
    }
}

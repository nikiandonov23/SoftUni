using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();                                     //51 47 32 61 21
                                                                //0   1  2  3  4
                                                                
            int rotations = int.Parse(Console.ReadLine());     //2


            int[] newArray = new int[array.Length];           //prazen array


            for (int i = 1; i <=rotations; i++)
            {

                for (int j = 0; j < array.Length; j++)      //j mi e indexa na array-a    0 1 2 3 4 
                {
                    
                }

            }

        }
    }
}

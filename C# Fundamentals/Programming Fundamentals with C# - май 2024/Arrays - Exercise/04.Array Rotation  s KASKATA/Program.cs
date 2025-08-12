using System;
using System.Linq;

namespace _04.Array_Rotation__s_KASKATA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
           
          


            int rotation = int.Parse(Console.ReadLine());

            for (int i = 1; i <=rotation; i++)                 //vurti rotaciqta
            {
                int num = array[0];


                for (int j = 0; j < array.Length-1; j++)        //vurti masiva
                {
                    

                    array[j] = array[j + 1];


                }

                array[array.Length-1] = num;
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}

using System;

namespace _03._Zig_Zag_Arrays_bez_mn_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int[] arrayEven = new int[n];
            int[] arrayOdd= new int[n];
            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int firstNum = int.Parse(input[0]);
                int secondNum = int.Parse(input[1]);

                if (i%2!=0)
                {
                    arrayOdd[i] = firstNum;
                    arrayEven[i] = secondNum;
                }

                else if (i%2==0)
                {
                    arrayOdd[i] = secondNum;
                    arrayEven[i] = firstNum;
                }


            }

            Console.WriteLine(string.Join(" ",arrayEven));
            Console.WriteLine(string.Join(" ", arrayOdd));



        }
    }
}

using System;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                BigInteger sum1 = 0;
                BigInteger sum2 = 0;

                string num = Console.ReadLine();

                string[] splitNum = num.Split(' ');


                BigInteger num1 = (BigInteger.Parse(splitNum[0]));
                BigInteger num1Copy = BigInteger.Abs(num1);

                while (num1Copy > 0)
                {
                    BigInteger digit = num1Copy % 10;
                    sum1 += digit;
                    num1Copy /= 10;
                }


                BigInteger num2 = (BigInteger.Parse(splitNum[1]));
                BigInteger num2Copy = BigInteger.Abs(num2);

                while (num2Copy > 0)
                {
                    BigInteger digit = num2Copy % 10;
                    sum2 += digit;
                    num2Copy /= 10;
                }

                if (num1 > num2)
                {
                    Console.WriteLine(sum1);
                }
                else 
                {
                    Console.WriteLine(sum2);
                }


            }


        }
    }
}
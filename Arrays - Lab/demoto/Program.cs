using System;
using System.Linq;
using System.Numerics;

namespace demoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                BigInteger leftSum = 0;
                BigInteger rightSum = 0;
                string number = Console.ReadLine();

                BigInteger[] sides = number.Split()
                    .Select(BigInteger.Parse)
                    .ToArray();

                BigInteger leftSide = sides[0];
                BigInteger leftSideCopy = BigInteger.Abs(leftSide);     //Сложих ти копие на числата защото по надолу ги намаляваш,вземайки последната цифра с %10 и /10
                                                                        //а на нас ще ни трябват оригиналните числа за да ги сравним по долу в " if (leftSide > rightSide)"


                BigInteger rightSide = sides[1];
                BigInteger righSideCopy = BigInteger.Abs(rightSide);    //И отново Math.Abs , на копията на оригиналните числа 
                                                                        //за да може оригиналните да бъдат правилно сравнени ако имаш отрицателен вход пример 1000 и -2000

                if (leftSide > rightSide)
                {
                    while (leftSideCopy > 0)
                    {
                        leftSum += leftSideCopy % 10;                //работиш с копията на числата за да запазиш оригиналните
                        leftSideCopy /= 10;
                    }

                    Console.WriteLine(leftSum);

                }
                else
                {
                    while (righSideCopy > 0)
                    {
                        rightSum += righSideCopy % 10;
                        righSideCopy /= 10;
                    }

                    Console.WriteLine(rightSum);
                }
            }
        }
    }
}

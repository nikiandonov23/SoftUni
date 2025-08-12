using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nCopy = n;    //15


            for (int i = 1; i <=n; i++)  // 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15
            {
                int numberCopy = i;
                int digitSum = 0;

                while (numberCopy>0)
                {
                    int digit =numberCopy% 10;
                    numberCopy /= 10;
                    digitSum += digit;

                }
                if (digitSum==5||digitSum==7||digitSum==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }


        }
    }
}

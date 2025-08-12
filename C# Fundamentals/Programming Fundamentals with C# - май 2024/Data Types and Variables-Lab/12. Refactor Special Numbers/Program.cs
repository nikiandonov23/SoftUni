using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberInput = int.Parse(Console.ReadLine());
            int sum = 0;
            int numberCopy = 0;
            bool isSpecialNum = false;
            for (int i = 1; i <= numberInput; i++)
            {
                numberCopy = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", numberCopy, isSpecialNum);
                sum = 0;
                i = numberCopy;
            }

        }
    }
}

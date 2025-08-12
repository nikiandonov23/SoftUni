using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string sum = "";

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();     // 222
                int numberOfDigits = input.Length;               //3

                char mainDigit = (input[0]);            //2
                int maindigitAsInt = mainDigit - '0';
                if (maindigitAsInt==0)
                {
                    sum += (char)(32);
                    continue;
                }

                
                int letterIndex = 0;

                if (maindigitAsInt != 8 || maindigitAsInt != 9)
                {
                    int offset = (maindigitAsInt - 2) * 3;
                     letterIndex = offset + numberOfDigits - 1;
                }
                if(maindigitAsInt == 8|| maindigitAsInt == 9)
                {
                    int offset = (maindigitAsInt - 2) * 3 + 1;
                     letterIndex = offset + numberOfDigits - 1;
                }

                char letter = (char)(letterIndex);
                char finalLetter =  (char)(letter+ 97);
                sum += finalLetter;



            }

            Console.WriteLine(sum);


        }
    }
}

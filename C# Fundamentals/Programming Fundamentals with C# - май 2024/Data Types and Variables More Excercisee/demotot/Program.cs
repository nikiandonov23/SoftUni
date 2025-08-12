using System;

namespace balanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftBracket = 0;
            int rightBraCket = 0;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                int inputLenght = input.Length;

                for (int j = 0; j < inputLenght; j++)           //vutri simvolite na stringa a b c 3 5 * 9 ( ) ........
                {
                    char digit = input[j];

                    if (digit == 40)
                    {
                        leftBracket++;

                    }

                    else if (digit == 41)
                    {
                        rightBraCket++;
                        if (leftBracket - rightBraCket != 0)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                    }
                }


            }
            if (leftBracket > rightBraCket + 1 || rightBraCket > leftBracket + 1)
            {
                Console.WriteLine("UNBALANCED");


            }

            else if (leftBracket == rightBraCket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
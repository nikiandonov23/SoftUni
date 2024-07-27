using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            for (int j = 1; j <= rows; j++)
            {
                string input = Console.ReadLine();

                int lenght = input.Length;

                int sum1 = 0;
                int sum2 = 0;

                int sumMax = 0;

                for (int i = 0; i < lenght; i++)
                {
                    char digit = input[i];


                    if (digit == 32)
                    {
                        for (int k = (i + 1); k < lenght; k++)
                        {
                            string m = input[k].ToString();
                            int number2 = int.Parse(m);
                            sum2 += number2;
                        }
                        break;
                    }

                    string n = input[i].ToString();
                    int number = int.Parse(n);
                    sum1 += number;



                }
                if (sum1 > sum2)
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

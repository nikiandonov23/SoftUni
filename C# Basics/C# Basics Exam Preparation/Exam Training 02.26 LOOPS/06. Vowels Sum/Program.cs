using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int letterNumber = text.Length;
            int sum = 0;

            for (int i = 0; i < letterNumber; i++)
            {
                char bukva = text[i];

                switch (bukva)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }


            }

            Console.WriteLine(sum);

        }
    }
}

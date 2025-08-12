using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] symbols = Console.ReadLine().Split();

            int bestCount = 0;
            string bestSymbol = "";

            for (int i = symbols.Length - 1; i >= 0; i--)     // 2  1 1  2  3 3  2 2 2  1
            {
                int count = 1;



                for (int j = i - 1; j >= 0; j--)
                {
                    if (symbols[i] == symbols[j])
                    {
                        count++;
                        if (bestCount <= count)
                        {
                            bestCount = count;
                            bestSymbol = symbols[i];
                        }

                    }
                    else
                    {
                        break;
                    }
                }

            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestSymbol+" ");
            }
        }
    }
}

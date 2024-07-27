using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] bestArray = new int[n];
            int bestSum = 0;
            int bestIndex = int.MaxValue;
            int bestSequenceLength = 0;
            int bestCounter = 0;
            int counter = 0;

            while (input != "Clone them!")
            {
                counter++;
                int[] array = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int currentSum = array.Sum();
                int currentBestLength = 0;
                int currentBestIndex = -1;

                int currentLength = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1)
                    {
                        currentLength++;
                        if (currentLength > currentBestLength)
                        {
                            currentBestLength = currentLength;
                            currentBestIndex = i - currentLength + 1;
                        }
                    }
                    else
                    {
                        currentLength = 0;
                    }
                }

                if (currentBestLength > bestSequenceLength ||
                    (currentBestLength == bestSequenceLength && currentBestIndex < bestIndex) ||
                    (currentBestLength == bestSequenceLength && currentBestIndex == bestIndex && currentSum > bestSum))
                {
                    bestArray = array;
                    bestSum = currentSum;
                    bestIndex = currentBestIndex;
                    bestSequenceLength = currentBestLength;
                    bestCounter = counter;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestArray));
        }
    }
}
using System;

namespace basimaikata
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int nLines = int.Parse(Console.ReadLine());

            string charSum = "";

            for (int i = 1; i <= nLines; i++)
            {
                char input = Char.Parse(Console.ReadLine());

                char nextLetter = (char)(input + key);
                charSum += nextLetter;



            }

            Console.WriteLine(charSum);
            
        }
    }
}
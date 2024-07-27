using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputAsString = Console.ReadLine();
            int minNum = int.MaxValue;

            while (inputAsString!= "Stop")
            {
                int inputAsNumber = int.Parse(inputAsString);
                if (inputAsNumber < minNum)
                {
                    minNum = inputAsNumber;
                }
                inputAsString = Console.ReadLine();
            }
            if (inputAsString == "Stop")
            {
                Console.WriteLine(minNum);
            }
        }
    }
}

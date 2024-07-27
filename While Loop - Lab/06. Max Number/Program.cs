using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int maxNum = int.MinValue;

            while (number!= "Stop")
            {
                int numberFromString = int.Parse(number);
                if (maxNum < numberFromString)
                {
                    maxNum = numberFromString;
                }
                number = Console.ReadLine();
            }
            if (number == "Stop")
            {
                Console.WriteLine(maxNum);
            }

        }
    }
}

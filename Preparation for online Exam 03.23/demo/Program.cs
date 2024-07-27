using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();

            for (char i = firstNum[0]; i <= secondNum[0]; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

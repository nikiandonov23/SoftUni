using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string number =Console.ReadLine();
            int lenght = number.Length;

            int numberToInt = int.Parse(number);

            char digit = number[lenght-1];
            string stringDigit = digit.ToString();

            string magicWord = "";

            switch (stringDigit)
            {
                case"1":
                    magicWord = "one";
                    break;
                case "2":
                    magicWord = "two";
                    break;
                case "3":
                    magicWord = "three";
                    break;
                case "4":
                    magicWord = "four";
                    break;
                case "5":
                    magicWord = "five";
                    break;
                case "6":
                    magicWord = "six";
                    break;
                case "7":
                    magicWord = "seven";
                    break;
                case "8":
                    magicWord = "eight";
                    break;
                case "9":
                    magicWord = "nine";
                    break;
                case "0":
                    magicWord = "zero";
                    break;
            }
            Console.WriteLine(magicWord);

        }
    }
}

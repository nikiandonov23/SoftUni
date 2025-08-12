using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(firstInt, secondInt));
                    break;

                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());

                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;

                case "string":

                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();

                    Console.WriteLine(GetMax(firstString, secondString));
                    break;


            }
        }

        static int GetMax(int first, int second)
        {
            return first > second ? first : second;
        }

        static char GetMax(char first, char second)
        {
            return first > second ? first : second;
        }

        static string GetMax(string first, string second)
        {
            return string.Compare(first, second) > 0 ? first : second;
        }
    }
}
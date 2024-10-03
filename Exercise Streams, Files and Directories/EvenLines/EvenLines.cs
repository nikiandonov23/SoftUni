using System.IO;
using System.Linq;

namespace EvenLines
{
    using System;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            string finalResult = "";
            string[] input=File.ReadAllLines(inputFilePath);
            for (int i = 0; i < input.Length; i+=2)
            {
                finalResult += CleaningText(input[i]);
            }

            return finalResult;
        }


        private static string CleaningText(string text)
        {
            string elements = "-,.!?";
            foreach (var character in elements)
            {
                text = text.Replace(character, '@');
            }
            string[] textArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] textArrayReversed = textArray.Reverse().ToArray();

            string finalResult = string.Join(" ", textArrayReversed);
            return finalResult;
        }
    }

}
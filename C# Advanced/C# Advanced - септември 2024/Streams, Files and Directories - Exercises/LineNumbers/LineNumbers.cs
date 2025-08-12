using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;

namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            List<string> outputText = new List<string>();
            string[] input=File.ReadAllLines(inputFilePath);
            for (int i = 0; i < input.Length; i++)
            {
                List<int> lettersAndPunct = AddLine(input[i]);
                int letters = lettersAndPunct[0];
                int punct=lettersAndPunct[1];

               outputText.Add($"Line {i + 1}: {input[i]} ({letters})({punct})");
            }
            File.WriteAllLines(outputFilePath, outputText);
           
            
        }

        private static List<int> AddLine(string text)
        {
            int letters = 0;
            int punct = 0;

            foreach (var character in text)
            {
                if (char.IsPunctuation(character))
                {
                    punct++;
                }
                else if (char.IsLetter(character))
                {
                    letters++;
                }
            }
            List<int> lettersAndPunct=new List<int>(){letters,punct};
            return lettersAndPunct;
        }
    }
}

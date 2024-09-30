using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {

            using (StreamReader readerWords = new StreamReader(@"..\..\..\Files\words.txt"))
            {
                StreamReader readerText = new StreamReader(@"..\..\..\Files\text.txt");
                Dictionary<string, int> allMatches = new Dictionary<string, int>();

                string words = readerWords.ReadToEnd();
                string[] wordsArray = words.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();  //dumite sa gotovi
                List<string> textArray = new List<string>();                                                       //texta e gotov

                string pattern = @"\w+";
                string input = readerText.ReadToEnd().ToLower();

                RegexOptions options = RegexOptions.Multiline;

                foreach (Match m in Regex.Matches(input, pattern, options))
                {
                    textArray.Add(m.Value);
                }

                foreach (var word in wordsArray)
                {
                    allMatches.Add(word, 0);
                }

                foreach (var text in textArray)
                {
                    if (allMatches.ContainsKey(text))
                    {
                        allMatches[text] += 1;
                    }
                }

                allMatches = allMatches
                  .OrderByDescending(kvp => kvp.Value)
                  .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                using (StreamWriter outputWriter=new StreamWriter(@"..\..\..\Files\output.txt"))
                {
                    foreach (var element in allMatches)
                    {
                        outputWriter.WriteLine($"{element.Key} - {element.Value}");
                    }
                    
                }

            }
        }



    }

}


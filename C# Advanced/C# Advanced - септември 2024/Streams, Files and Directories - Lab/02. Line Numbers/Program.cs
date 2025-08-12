using System.Diagnostics.Metrics;
using System.Reflection;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {

            using (StreamWriter writer = new StreamWriter(@"..\..\..\Files\output.txt"))
            {

                using (StreamReader reader=new StreamReader(@"..\..\..\Files\input.txt"))
                {

                    string textLine = reader.ReadLine();
                    int counter = 0;
                    while (textLine!=null)
                    {

                        counter++;
                        writer.WriteLine($"{counter}. {textLine}");
                        textLine =reader.ReadLine();
                    }
                }

                
            }

        }
    }
}



using System.Diagnostics.Metrics;
namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
          

            using (StreamWriter writer=new StreamWriter(@"..\..\..\Files\output.txt"))
            {
                using (StreamReader reader = new StreamReader(@"..\..\..\Files\input.txt"))
                {

                    string textLine = reader.ReadLine();
                    int counter = 1;
                    while (textLine != null)
                    {

                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(textLine);
                        }
                        textLine = reader.ReadLine();
                        counter++;

                    }


                }
            }
        }
    }
}









using System.Threading.Channels;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader reader1 = new StreamReader(@"..\..\..\Files\input1.txt"))
            {
                StreamReader reader2 = new StreamReader(@"..\..\..\Files\input2.txt");

                using (StreamWriter writer = new StreamWriter(@"..\..\..\Files\output.txt"))
                {
                    string input1Line = reader1.ReadLine();
                    string input2Line = reader2.ReadLine();
                    while (input1Line != null || input2Line != null)
                    {
                        if (input1Line != null)
                        {
                            writer.WriteLine(input1Line);
                            input1Line = reader1.ReadLine();
                        }

                        if (input2Line != null)
                        {
                            writer.WriteLine(input2Line);
                            input2Line = reader2.ReadLine();
                        }
                        
                    }


                }
            }
        }
    }
}
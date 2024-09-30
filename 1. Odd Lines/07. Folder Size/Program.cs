namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            string[] dirAllFiles = Directory.GetFiles(folderPath);
            long totalSize = 0;
            foreach (var file in dirAllFiles)
            {
                totalSize+=file.Length;
            }

            double total = totalSize / 1024.0;
          File.WriteAllText(outputFilePath,total.ToString());
        }
    }
}
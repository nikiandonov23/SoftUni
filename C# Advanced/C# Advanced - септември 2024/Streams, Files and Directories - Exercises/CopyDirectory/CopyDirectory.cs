using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace CopyDirectory
{
    using System;
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(inputPath);
            FileInfo[] files = dirInfo.GetFiles();

            DirectoryInfo dirInfoOutput=new DirectoryInfo(outputPath);
            if (dirInfoOutput.Exists)
            {
                dirInfoOutput.Delete(true);
            }
            dirInfoOutput.Create();
            
            foreach (FileInfo file in files)
            {
                string filePath = file.Name;
                string fullOutputPath=Path.Combine(outputPath, filePath);
                file.CopyTo(fullOutputPath);
            }


        }
    }
}

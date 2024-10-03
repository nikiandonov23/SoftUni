using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = "report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {




            DirectoryInfo dirInfo = new DirectoryInfo(inputFolderPath);
            FileInfo[] fileInfo = dirInfo.GetFiles();

            Dictionary<string, List<FileInfo>> allFiles = new Dictionary<string, List<FileInfo>>();

            foreach (var file in fileInfo)
            {
                if (!allFiles.ContainsKey(file.Extension))
                {
                    allFiles.Add(file.Extension, new List<FileInfo>());
                }
                allFiles[file.Extension].Add(file);

            }


            allFiles = allFiles.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            StringBuilder resultBuilder = new StringBuilder();
            foreach (var (extension, files) in allFiles)
            {
                resultBuilder.AppendLine(extension);

                foreach (var file in files)
                {
                    resultBuilder.AppendLine($"--{file.Name} - {file.Length / 1024.0}");
                }
            }

            return resultBuilder.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string destopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string savePath = Path.Combine(destopPath, reportFileName);
            File.WriteAllText(savePath, textContent);
            
        }
    }
}

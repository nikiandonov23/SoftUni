using System.Text;

string path= @"C:\Users\НАТАЛИ\source\repos\Exercise Streams, Files and Directories\CopyBinaryFile";

DirectoryInfo dirInfo=new DirectoryInfo(path);
FileInfo[] fileInfo=dirInfo.GetFiles();

Dictionary<string,List<FileInfo>>allFiles=new Dictionary<string,List<FileInfo>>();

foreach (var file in fileInfo)
{
    if (!allFiles.ContainsKey(file.Extension))
    {
        allFiles.Add(file.Extension,new List<FileInfo>());
    }
    allFiles[file.Extension].Add(file);
    
}

allFiles= allFiles.OrderByDescending(x=>x.Value.Count)
    .ThenBy(x=>x.Key)
    .ToDictionary(x=>x.Key,x=>x.Value);

StringBuilder resultBuilder=new StringBuilder();
foreach (var (extension,files) in allFiles)
{
    resultBuilder.AppendLine(extension);

    foreach (var file in files)
    {
        resultBuilder.AppendLine($"--{file.Name} - {file.Length / 1024.0}");
    }
}

Console.WriteLine(resultBuilder);
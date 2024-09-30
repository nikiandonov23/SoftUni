namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {

            byte[] allBytes = File.ReadAllBytes(sourceFilePath);
            int size1 = allBytes.Length / 2 + allBytes.Length % 2;
            int size2 = allBytes.Length / 2;

            using (FileStream writer1=new FileStream(partOneFilePath,FileMode.OpenOrCreate))
            {
                writer1.Write(allBytes,0,size1);
            }

            using (FileStream writer2 = new FileStream(partTwoFilePath,FileMode.OpenOrCreate))
            {
                writer2.Write(allBytes,size1,size2);
            }




        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] array1=File.ReadAllBytes(partOneFilePath);
            byte[] array2=File.ReadAllBytes(partTwoFilePath);

            byte[] allArrays=array1.Concat(array2).ToArray();
            using (FileStream writerAllArrays=new FileStream(joinedFilePath,FileMode.OpenOrCreate))
            {
                writerAllArrays.Write(allArrays,0,allArrays.Length);
            }



        }
    }
}
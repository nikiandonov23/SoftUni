namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {

            List<byte> targetBytes = new List<byte>();

            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    targetBytes.Add(byte.Parse(currentLine));
                    currentLine = reader.ReadLine();
                }
            }

            List<byte> extractedBytes = new List<byte>();
            using (FileStream reader = new FileStream(binaryFilePath, FileMode.OpenOrCreate))
            {
                int currentByte = reader.ReadByte();

                while (currentByte != -1)
                {
                    byte byteValue = (byte)currentByte;
                    if (targetBytes.Contains(byteValue))
                    {
                        extractedBytes.Add(byteValue);
                    }


                    currentByte = reader.ReadByte();
                }


            }

            using (FileStream writer = new FileStream(outputPath, FileMode.OpenOrCreate))
            {
                writer.Write(extractedBytes.ToArray());
               
            }
        }
    }
}
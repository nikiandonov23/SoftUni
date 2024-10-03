using System.Collections.Generic;
using System.IO;

namespace CopyBinaryFile
{
    using System;
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
                {


                    byte[] buffer = new byte[1024];         //razmer na bufera  .Cusumize
                    int readBytes;                           //broi procheteni bytove

                    while ((readBytes=reader.Read(buffer))!=0)   //dokato pro4etenite bytove ot filestreama sa !=0 produljavai da 4etesh
                    {
                        writer.Write(buffer,0,readBytes);  //zapisvash bufera ,ot poziciq 0,tolkova puti kolkoto bytove si pro4el
                    }

                }
            }
            





        }
    }
}

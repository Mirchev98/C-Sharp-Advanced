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
            using (FileStream stream = new FileStream(inputFilePath, FileMode.Open))
            {
                byte[] buffer = new byte[512];

                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
                {
                    while (true)
                    {
                        int size = stream.Read(buffer, 0, buffer.Length);

                        if (size == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, size);
                    }
                    
                }
            }
        }
    }
}

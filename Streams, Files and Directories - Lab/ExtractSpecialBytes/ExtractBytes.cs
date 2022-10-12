using System.Collections.Generic;
using System.Text;

namespace ExtractBytes
{
    using System;
    using System.IO;
    public class ExtractBytes
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
            byte[] bytesFromFile = File.ReadAllBytes(binaryFilePath);
            List<string> wantedBytes = new List<string>();
            StringBuilder sb = new StringBuilder();
            
            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                while (!reader.EndOfStream)
                {
                    wantedBytes.Add(reader.ReadLine());
                }

                foreach (var currentByte in bytesFromFile)
                {
                    if (wantedBytes.Contains(currentByte.ToString()))
                    {
                        sb.Append(currentByte.ToString());
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine(sb.ToString().Trim());
            }
        }
    }
}

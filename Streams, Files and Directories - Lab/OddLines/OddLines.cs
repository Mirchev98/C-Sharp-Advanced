﻿namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int counter = 0;

                string currentRow = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while (currentRow != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(currentRow);
                        }

                        currentRow = reader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}
using System.Collections.Generic;

namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<string> inputOne = new List<string>();
            List<string> inputTwo = new List<string>();

            using (StreamReader reader = new StreamReader(firstInputFilePath))
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    inputOne.Add(currentLine);

                    currentLine = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader(secondInputFilePath))
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    inputTwo.Add(currentLine);

                    currentLine = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < inputOne.Count; i++)
                {
                    writer.WriteLine(inputOne[i]);
                    writer.WriteLine(inputTwo[i]);
                }
            }
        }
    }
}

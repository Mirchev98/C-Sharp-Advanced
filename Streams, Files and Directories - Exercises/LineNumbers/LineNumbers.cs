﻿using System.IO;
using System.Linq;
using System.Text;

namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();

            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = lines[i].Count(ch => char.IsLetter(ch));
                int punctuationCount = lines[i].Count(ch => char.IsPunctuation(ch));

                sb.AppendLine(
                    $"Line {i + 1}: {lines[i]} ({letterCount})({punctuationCount})");
            }

            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}

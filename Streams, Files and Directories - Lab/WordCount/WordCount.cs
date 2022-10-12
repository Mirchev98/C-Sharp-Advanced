using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] wantedWords = new string[]{};

            Dictionary<string, int> count = new Dictionary<string, int>();

            using (StreamReader readerWords = new StreamReader(wordsFilePath))
            {
                wantedWords = readerWords.ReadToEnd().Split(" ");

            }

            using (StreamReader textReader = new StreamReader(textFilePath))
            {
                string text = textReader.ReadLine();

                while (text != null)
                {
                    string[] currentWords = text.ToLower().Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in currentWords)
                    {
                        foreach (var wantedWord in wantedWords)
                        {
                            if (word == wantedWord)
                            {
                                if (!count.ContainsKey(word))
                                {
                                    count.Add(wantedWord, 0);
                                }

                                count[wantedWord]++;
                            }
                        }

                    }

                    text = textReader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                count = count.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach (var element in count)
                {
                    writer.WriteLine($"{element.Key} - {element.Value}");
                }
            }
        }
    }
}

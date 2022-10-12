using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    using System;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            char[] toReplace = new[] { '-', ',', '.', '!', '?' };

            int counter = 0;

            StringBuilder sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    foreach (var character in toReplace)
                    {
                        line = line.Replace(character, '@');
                    }

                    string[] reversed = line.Split(' ').Reverse().ToArray();

                    string reversedWord = String.Join(" ", reversed);

                    if (counter % 2 == 0)
                    {
                        sb.AppendLine(reversedWord);
                    }
                    counter++;

                    line = reader.ReadLine();
                }
            }

            return sb.ToString();
        }
    }
}

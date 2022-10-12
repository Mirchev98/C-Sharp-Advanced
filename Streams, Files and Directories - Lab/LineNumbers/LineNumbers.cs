using System.Text;

namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();
                int counter = 1;
                StringBuilder sb = new StringBuilder();



                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while (line != null)
                    {
                        string currentLine = $"{counter}. {line}";
                        sb.Append(currentLine);

                        writer.WriteLine(sb.ToString());
                        sb = new StringBuilder();

                        counter++;
                        line = reader.ReadLine();
                    }
                    
                }
            }
        }
    }
}

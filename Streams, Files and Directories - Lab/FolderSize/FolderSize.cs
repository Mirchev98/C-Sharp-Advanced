namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            var files = Directory.GetFiles(folderPath);
            long sum = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            File.WriteAllText(outputFilePath, $"{sum} KB");
        }


    }
}

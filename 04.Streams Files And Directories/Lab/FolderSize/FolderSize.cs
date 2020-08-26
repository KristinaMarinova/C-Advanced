using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        public static void Main()
        {
            string directory = @"..\..\..\..\Resources\06. Folder Size\TestFolder";

            string[] allFiles = Directory.GetFiles(directory, "*", SearchOption.TopDirectoryOnly);

            double totalFilesSizeMiB = 0d;
            foreach (var file in allFiles)
            {
                using (var reader = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    double fileSizeMiB = reader.Length / 1_048_576.0;
                    totalFilesSizeMiB += fileSizeMiB;
                }
            }

            string outputPath = @"..\..\..\..\Resources\06. Folder Size\output.txt";
            using (var writer = new StreamWriter(outputPath))
            {
                writer.WriteLine(totalFilesSizeMiB);
            }
        }
    }
}
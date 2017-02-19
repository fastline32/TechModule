using System.Globalization;
using System.IO;

namespace _05.FolderSize
{
    class Program
    {
        static void Main()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var dirInfo = new DirectoryInfo(currentDirectory);
            if (dirInfo.Parent != null)
            {
                var rootDirectory = dirInfo.Parent.Parent;
                double sum = 0;

                if (rootDirectory != null)
                    foreach (var file in rootDirectory.GetFiles())
                    {
                        sum += file.Length;
                    }
                sum = (sum / 1024) / 1024;

                File.WriteAllText("output.txt", sum.ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}

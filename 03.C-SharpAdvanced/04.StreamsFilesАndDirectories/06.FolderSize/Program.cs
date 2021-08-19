using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filenames = Directory.GetFiles("../../../TestFolder");
            double totalSize = 0;

            foreach (var file in filenames)
            {
                FileInfo info = new FileInfo(file);
                totalSize += info.Length;
            }

            totalSize = totalSize / Math.Pow(1024, 2);
            File.WriteAllText("Megabites.txt", totalSize.ToString());
        }
    }
}

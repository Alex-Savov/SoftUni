using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _05.DirectoryTraversal2._0
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Dictionary<string, List<FileInfo>> fileByExtension = new Dictionary<string, List<FileInfo>>();
            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                string extension = info.Extension;

                if (!fileByExtension.ContainsKey(extension))
                {
                    fileByExtension.Add(extension, new List<FileInfo>());
                }
                fileByExtension[extension].Add(info);

                using (StreamWriter wrt = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt"))
                {
                    foreach (var ext in fileByExtension)
                    {
                        await wrt.WriteLineAsync(ext.Key);

                        foreach (var item in ext.Value.OrderBy(x => x.Length))
                        {
                           await wrt.WriteLineAsync($"--{item.Name} - {item.Length}");
                        }
                    }
                }
            }
        }
    }
}

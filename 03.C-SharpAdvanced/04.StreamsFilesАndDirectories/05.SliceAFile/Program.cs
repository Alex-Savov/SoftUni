using System;
using System.IO;
using System.Threading.Tasks;

namespace _05.SliceAFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int parts = 4;
            byte[] buffer = new byte[4096];
            int totalBytes = 0;

            using (FileStream fsRdr = new FileStream("sliceMe.txt", FileMode.Open, FileAccess.Read))
            {
                int partSize = (int)Math.Ceiling((decimal)fsRdr.Length / parts);

                for (int i = 1; i <= parts; i++)
                {
                    int readBytes = 0;

                    using (FileStream fsWrtr = new FileStream($"Part-{i}.txt", FileMode.Create, FileAccess.Write))
                    {
                        while (readBytes < partSize && totalBytes < fsRdr.Length)
                        {
                            int bytes = await fsRdr.ReadAsync(buffer, 0, Math.Min(buffer.Length, partSize - readBytes));
                            await fsWrtr.WriteAsync(buffer, 0, buffer.Length);

                            totalBytes += bytes;
                            readBytes += bytes;
                        }
                    }
                }
                
            }
        }
    }
}

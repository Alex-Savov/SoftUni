using System;
using System.IO;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("Input.txt"))
            {
                int currentLine = 0;
                string line = await reader.ReadLineAsync();

                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        if (currentLine % 2 != 0)
                        {
                            await writer.WriteLineAsync(line);
                        }

                        currentLine++;
                        line = await reader.ReadLineAsync();
                    }
                }
            }
        }
    }
}

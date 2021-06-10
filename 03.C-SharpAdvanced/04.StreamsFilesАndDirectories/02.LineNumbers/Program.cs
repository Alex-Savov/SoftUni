using System;
using System.IO;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader rdr = new StreamReader("input.txt"))
            {
                string line = await rdr.ReadLineAsync();
                int lineCounter = 1;

                using (StreamWriter wrt = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        await wrt.WriteLineAsync($"{lineCounter}. {line}");

                        lineCounter++;
                        line = await rdr.ReadLineAsync();
                    }
                }
            }
        }
    }
}

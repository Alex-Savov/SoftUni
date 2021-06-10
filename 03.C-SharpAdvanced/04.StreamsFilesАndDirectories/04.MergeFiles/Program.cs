using System;
using System.IO;
using System.Threading.Tasks;

namespace _04.MergeFiles
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader firstFileRdr = new StreamReader("input1.txt"))
            {
                string[] firstTextArr = (await firstFileRdr.ReadToEndAsync())
                    .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

                using (StreamReader secondFileRdr = new StreamReader("input2.txt"))
                {
                    string[] secondTextArr = (await secondFileRdr.ReadToEndAsync())
                        .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

                    using (StreamWriter outputWriter = new StreamWriter("output.txt"))
                    {
                        int counter = 0;
                        while (counter < firstTextArr.Length && counter < secondTextArr.Length)
                        {
                            await outputWriter.WriteLineAsync(firstTextArr[counter]);
                            await outputWriter.WriteLineAsync(secondTextArr[counter]);
                            counter++;
                        }
                        
                        if (counter == firstTextArr.Length)
                        {
                            for (int i = counter; i < secondTextArr.Length; i++)
                            {
                                await outputWriter.WriteLineAsync(secondTextArr[i]);
                            }
                        }
                        else if (counter == secondTextArr.Length)
                        {
                            for (int i = counter; i < firstTextArr.Length; i++)
                            {
                                await outputWriter.WriteLineAsync(firstTextArr[i]);
                            }
                        }
                    }
                }
            }
        }
    }
}

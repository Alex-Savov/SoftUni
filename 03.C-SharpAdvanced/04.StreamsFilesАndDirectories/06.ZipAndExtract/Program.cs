using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("./test", "./copy.zip");
            ZipFile.ExtractToDirectory("./copy.zip", "./extract");
        }
    }
}

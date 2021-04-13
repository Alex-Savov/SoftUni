using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcodePattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            Regex barcodeRgx = new Regex(barcodePattern);
            int lines = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < lines; i++)
            {
                string barcode = Console.ReadLine();
                Match match = barcodeRgx.Match(barcode);
                string productGroup = string.Empty;

                if (match.Success)
                {
                    foreach (var character in barcode)
                    {
                        if (char.IsDigit(character))
                        {
                            productGroup += character.ToString();
                        }
                    }

                    Console.WriteLine($"Product group: {(productGroup.Length == 0 ? "00" : productGroup)}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}

using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string alphabet = "";
            for (char ch = 'a'; ch <= 'z' ; ch++)
            {
                alphabet += ch.ToString();
            }

            for (int x1 = 1; x1 <= n; x1++)
            {
                for (int x2 = 1; x2 <= n; x2++)
                {
                    for (int x3 = 0; x3 < l ; x3++)
                    {
                        char symbol1 = alphabet[x3];
                        for (int x4 = 0; x4 < l; x4++)
                        {
                            char symbol2 = alphabet[x4];
                            for (int x5 = 1; x5 <= n; x5++)
                            {
                                if (x5 > x1 && x5 > x2)
                                {
                                    Console.Write($"{x1}{x2}{symbol1}{symbol2}{x5} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

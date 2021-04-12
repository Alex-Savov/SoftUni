using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = true;
                string number = i.ToString();

                for (int j = number.Length - 1; j >= 0; j--)
                {
                    int devider = int.Parse(number[j].ToString());

                    if (devider == 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    else if (n % devider != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

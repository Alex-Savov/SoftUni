using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms
{
    public class Recursion
    {
        public int RecursiveFactorial(int num)
        {
            if (num == 1)
            {
                return num;
            }

            return num * RecursiveFactorial(--num);
        }
        public int Sum(int[] arr, int index)
        {
            if (index == 0)
            {
                return arr[0];
            }

            return arr[index] + Sum(arr, --index);
        }
    }
}

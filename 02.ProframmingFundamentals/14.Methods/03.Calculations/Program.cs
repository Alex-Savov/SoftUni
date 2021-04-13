using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            string result = string.Empty;

            //add, multiply, subtract, divide
            switch (operation)
            {
                case "add": 
                    result = Sum(firstNumber, secondNumber); 
                    break;
                case "multiply":
                    result = Multiply(firstNumber, secondNumber);
                    break;
                case "subtract":
                    result = Substract(firstNumber, secondNumber);
                    break;
                case "divide":
                    result = Divide(firstNumber, secondNumber);
                    break;
                default:
                    break;
            }

            Console.WriteLine(result);
        }
        static string Sum(int a, int b)
        {
            string result = (a + b).ToString();
            return result;
        }

        static string Substract(int a, int b)
        {
            string result = (a - b).ToString();
            return result;
        }

        static string Multiply(int a, int b)
        {
            string result = (a * b).ToString();
            return result;
        }

        static string Divide(int a, int b)
        {
            string result = (a / ((double)b)).ToString();
            return result;
        }
    }
}

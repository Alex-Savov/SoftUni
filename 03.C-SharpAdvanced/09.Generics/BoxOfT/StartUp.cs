using System;

namespace BoxOfT
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            Box<string> names = new Box<string>();
            names.Add("Pesho");
            names.Add("Gosho");
            names.Add("Mimi");
            Console.WriteLine(names.Remove());
            names.Add("Kiro");
            names.Add("Valentina");
            Console.WriteLine(names.Remove());

            Box<int> numbers = new Box<int>();
            numbers.Add(56);
            numbers.Add(6);
            numbers.Add(89);
            Console.WriteLine(numbers.Remove());
            numbers.Add(6);
            numbers.Add(25);
            Console.WriteLine(numbers.Remove());
        }
    }
}

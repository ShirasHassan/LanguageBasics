using System;

namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            string statements = "Hello World!";
            Console.WriteLine(statements);
            StringExtensions.Sample(statements);
            CharExtensions.Sample(statements);
            Inheritance.Run();
        }
    }
}
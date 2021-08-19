using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string GuidKey = Guid.NewGuid().ToString();
            Console.WriteLine(GuidKey);
        }
    }
}

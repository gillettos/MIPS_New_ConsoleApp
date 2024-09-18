using System;
using MyLibrary;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            string message = myClass.SayHello("World");
            Console.WriteLine(message);
        }
    }
}
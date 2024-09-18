using System;
using TwinCAT.Ads;
using MyLibrary;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlcCommunicator plc = new PlcCommunicator();
            plc.ToggleBoolean("MAIN.fbAxis1.bEnable"); // Replace with your actual variable name
            Console.WriteLine("Boolean variable toggled.");
        }
    }
}

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


            int intValue = plc.ReadInteger("MAIN.nIntToRead"); // Replace with your actual integer variable name
            Console.WriteLine($"Integer value read from PLC: {intValue}");



            plc.mc_motors_on();
            Console.WriteLine("Motor 1 On.");
        }
    }
}

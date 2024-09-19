using System;
using TwinCAT.Ads;
using MyLibrary;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set PLC coms UP
            PlcCommunicator plc = new PlcCommunicator();

            //mc_motors_on  (AXIS 1 for now)
            plc.mc_motors_on();
            Console.WriteLine("Motor 1 On.");

            //i_stop
            plc.Mc_istop(1, 80.0f); // Example usage of Mc_istop
            Console.WriteLine("Motion command executed.");

            //Read an Int ie, position
            int intValue = plc.ReadInteger("MAIN.nIntToRead"); // Replace with your actual integer variable name
            Console.WriteLine($"Integer value read from PLC: {intValue}");

          /*  
            
            //toggle any boolean
            //PlcCommunicator plc = new PlcCommunicator();
            plc.ToggleBoolean("MAIN.fbAxis1.bEnable"); // Replace with your actual variable name
            Console.WriteLine("Boolean variable toggled.");

            */
        }
    }
}

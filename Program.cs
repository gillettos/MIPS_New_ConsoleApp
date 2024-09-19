using System;
using TwinCAT.Ads;
using MyLibrary;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
             
            //toggle any boolean
            PlcCommunicator plc = new PlcCommunicator();  //Set PLC coms UP
            plc.ToggleBoolean("MAIN.fbAxis1.bEnable"); // Replace with your actual variable name
            Console.WriteLine("Boolean variable toggled.");



            //mc_motors_on  (AXIS 1 for now)
            plc.mc_motors_on();
            Console.WriteLine("Motor 1 On.");

            //i_Move  (Moves specified axis to new absolute position)
            plc.Mc_imov(1, 100); // Example usage of Mc_istop
            Console.WriteLine("Motion command executed.");


            plc.Mc_ifast(1, 50);
            Console.WriteLine("New Speed command executed.");

            plc.Mc_iSet(1, 25); //Axis 1 goto postion of 25 deg
            Console.WriteLine("New Pos command executed.");

            plc.Mc_iMoveComplete(1);
            Console.WriteLine("Move Complete command executed.");

            plc.mc_ird(1);
            

            /*
            //i_stop (Stop all Movement but leave enabled)
            plc.Mc_istop(1, 80.0f); // Example usage of Mc_istop
            Console.WriteLine("Motion command executed.");

            //Read an Int ie, position
            int intValue = plc.ReadInteger("MAIN.nIntToRead"); // Replace with your actual integer variable name
            Console.WriteLine($"Integer value read from PLC: {intValue}");

*/





        }
    }
}

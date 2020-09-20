using System;

namespace AdapterExample
{
    /// <summary>
    /// 2 Incompatibile interfaces have to work together
    /// - interfaces incompatibile
    /// - inner functionality suits the needs
    /// 
    /// Adapter DP is usefull when working with some legacy code
    /// that has to work with newer classes
    /// 
    /// identified by: constructor that takes instance of different
    /// abstract/interface. Translation of parameters to other format
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Classic scenario
            Console.WriteLine("Pzkpfg VI Tiger\n\n");
            Pzkpfwg_VI_Tiger tank = new Pzkpfwg_VI_Tiger();

            tank.move(Thrust.FULL, true, Thrust.FULL, true);
            tank.shootMainCannon(Ammo.ARMOR_PIERCING_BC_HE, 32, 8);

            // Different vehicle
            Console.WriteLine("\n\nXC80\n\n");
            Teleporting_Battle_Machine_XC80 telxc = new Teleporting_Battle_Machine_XC80();

            telxc.DestroyTargetAt("MARS", 48.4, 12.1, 9);
            telxc.TeleportTo("PLUTO", 152.45, 0.2, -5);

            // Commander station New generation that needs to utilize older tanks has to do it via adapter
            Console.WriteLine("\n\nTiger adapted under teleport orders\n\n");

            Adapter_Tanks_commandedBy_Teleports adapted = new Adapter_Tanks_commandedBy_Teleports(tank);
            adapted.DestroyTargetAt("PLUTO", 52.45, 10.2, 5);
            adapted.TeleportTo("EARTH", 48.30763, 18.08453, 144);
            adapted.DestroyTargetAt("EARTH", 52.45, 10.2, 5);

            // Waiting for user input to close the cmd
            Console.ReadLine();
        }
    }
}

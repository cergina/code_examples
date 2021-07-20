using System;

namespace AdapterExample
{
    /// <summary>
    /// Adapter implements ITarget and inherits
    /// Adaptee class. It's the communication
    /// point between client and Adaptee
    /// 
    /// - contains Adaptee
    /// - Adaptee class will be used by Adapter
    /// </summary>
    class Adapter_Tanks_commandedBy_Teleports : IAdaptee_Tele
    {
        private ITarget_Tank tank;
        private Random rnd;

        public Adapter_Tanks_commandedBy_Teleports(ITarget_Tank tank)
        {
            this.tank = tank;
            rnd = new Random();
        }

        /* teleportating battle machines */
        public void DestroyTargetAt(string planet, double latitude, double longitude, double seaLevel)
        {
            Console.WriteLine($"\n    Pretending to be a teleport battle machine, by following order of destroyal.");
            
            if (RequiredRandomMovementSteps(planet))
                tank.shootMainCannon(Ammo.ARMOR_PIERCING_BC_HE, rnd.Next(360), rnd.Next(-20, 60));
        }

        public void TeleportTo(string planet, double latitude, double longitude, double seaLevel)
        {
            Console.WriteLine($"\n    Pretending to be a teleport battle machine, by following order of teleportation.");

            RequiredRandomMovementSteps(planet);
        }

        private bool RequiredRandomMovementSteps(string planet)
        {
            if (planet.ToUpper().Equals("EARTH") == false)
            {
                Console.WriteLine($"    This piece of technology cannot travel to planet {planet}");
                return false;
            }

            int stepsRequiredToGetThere = rnd.Next(1, 6);
            for (int i = 0; i < stepsRequiredToGetThere; i++)
            {
                // just random logic
                tank.move((Thrust)rnd.Next((int)Thrust.FULL + 1), (rnd.Next(100) < 50), 
                    (Thrust)rnd.Next((int)Thrust.FULL + 1), (rnd.Next(100) < 50));
            }

            Console.WriteLine("     Pretender arrived to specified coordinates.");
            return true;
        }
    }
}

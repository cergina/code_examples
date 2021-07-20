using System;

namespace AdapterExample
{
    class Teleporting_Battle_Machine_XC80 : IAdaptee_Tele
    {
        public void DestroyTargetAt(string planet, double latitude, double longitude, double seaLevel)
        {
            Console.WriteLine($"Destroying target at planet {planet}");
            Console.WriteLine($"Positioned at [latitude({latitude})], [longitude({longitude})] at [sea level({seaLevel}m)]");
        }

        public void TeleportTo(string planet, double latitude, double longitude, double seaLevel)
        {
            Console.WriteLine($"Teleporting to planet {planet}");
            Console.WriteLine($"Positioning at [latitude({latitude})], [longitude({longitude})] at [sea level({seaLevel}m)]");
        }
    }
}

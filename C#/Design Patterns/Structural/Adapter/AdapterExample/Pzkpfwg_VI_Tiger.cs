using System;

namespace AdapterExample
{
    class Pzkpfwg_VI_Tiger : ITarget_Tank
    {
        private KwK36 gun = new KwK36();
        
        #region public methods
        public void move(Thrust leftTrack, bool leftTrack_toFront, Thrust rightTrack, bool rightTrack_toFront)
        {
            Console.WriteLine($"    !! Tiger's movement is: {Transmission.ResultingMovement(leftTrack,leftTrack_toFront, rightTrack, rightTrack_toFront)}");
        }

        public void shootMainCannon(Ammo ammo, int turretRotation, int gunDepression)
        {
            Console.WriteLine($"    !! Tiger loading: {ammo}");
            Console.WriteLine($"    !! Tiger rotates turret to {Turret.CorrectRotation(turretRotation)} degrees");
            Console.WriteLine($"    !! Tiger is getting its KwK36 gun into: {KwK36.CorrectDepression(gunDepression)} angle");
            Console.WriteLine($"    !! Tiger shoots");
        }
        #endregion

        #region Nested Class
        class KwK36
        {
            public const int depressionLow = -8;
            public const int depressionHigh = 40;
            public const int caliber = 88;

            public static int CorrectDepression(int proposed)
            {
                if (proposed < depressionLow)
                    return depressionLow;

                if (proposed > depressionHigh)
                    return depressionHigh;

                return proposed;
            }
        }

        class Turret
        {
            public static int CorrectRotation(int proposed)
                => proposed % 360;
        }

        class Transmission
        {
            public static string ResultingMovement(Thrust leftTrack, bool leftTrack_toFront, Thrust rightTrack, bool rightTrack_toFront)
            {                
                int leftSpeed = ((leftTrack_toFront) ? 1 : -1) * (int)leftTrack;
                int rightSpeed = ((rightTrack_toFront) ? 1 : -1) * (int)rightTrack;

                if (leftSpeed == rightSpeed)
                {
                    if (leftSpeed > 0)
                        return "FRONTAL STRAIGHT MOVEMENT";
                    else if (leftSpeed == 0)
                        return "STANDING STILL";
                    else
                        return "BACKWARDS STRAIGHT MOVEMENT";

                } else
                {
                    if (leftSpeed > rightSpeed)
                        return "TURNING RIGHT";
                    else
                        return "TURNING LEFT";
                }
            }
        }
        #endregion
    }
}

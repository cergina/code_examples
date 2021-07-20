namespace AdapterExample
{
    /// <summary>
    /// interface which is used to achieve 
    /// requested functionality (LEGACY)
    /// 
    /// - CANNOT BE TOUCHED OR CHANGED -
    /// 
    /// </summary>
    interface ITarget_Tank
    {
        void move(Thrust leftTrack, bool leftTrack_toFront, Thrust rightTrack, bool rightTrack_toFront);
        void shootMainCannon(Ammo ammo, int turretRotation, int gunDepression);
    }
}

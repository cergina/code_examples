namespace AdapterExample
{

    interface IAdaptee_Tele
    {
        void TeleportTo(string planet, double latitude, double longitude, double seaLevel);

        void DestroyTargetAt(string planet, double latitude, double longitude, double seaLevel);
    }
}
